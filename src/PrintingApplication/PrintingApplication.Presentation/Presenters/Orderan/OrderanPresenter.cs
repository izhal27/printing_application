using Equin.ApplicationFramework;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Domain.Models.Orderan;
using PrintingApplication.Domain.Models.OrderanDetail;
using PrintingApplication.Infrastructure.DataAccess.Repositories.JenisOrderan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Orderan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.ModelControls;
using PrintingApplication.Presentation.Views.Orderan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.JenisOrderan;
using PrintingApplication.Services.Services.Orderan;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Presenters.Orderan
{
    public class OrderanPresenter : IOrderanPresenter
    {
        private IOrderanView _view;
        private IOrderanServices _orderanServices;
        private IJenisOrderanServices _jenisOrderanServices;
        private List<OrderanDetailModel> _listOrderanDetails;
        private List<IJenisOrderanModel> _listsJenisOrderans;
        private BindingListView<OrderanDetailModel> _bindingView;
        private bool _statusPembayaran = false;
        private string _kodeOrNamaForSearching = "";
        private IOrderanModel _orderanModel;
        private decimal _grandTotal;

        public IOrderanView GetView
        {
            get { return _view; }
        }

        private int CurrCellRowIndex
        {
            get { return _view.ListDataGrid.CurrentCell.RowIndex; }
        }

        private object CurrCellValue
        {
            get
            {
                return _view.ListDataGrid.CurrentCell.CellRenderer.GetControlValue();
            }
        }

        public OrderanPresenter()
        {
            _view = new OrderanView();
            _orderanServices = new OrderanServices(new OrderanRepository(), new ModelDataAnnotationCheck());
            _jenisOrderanServices = new JenisOrderanServices(new JenisOrderanRepository(), new ModelDataAnnotationCheck());
            _listsJenisOrderans = _jenisOrderanServices.GetAll().ToList();

            _view.OnLoadData += _view_OnLoadData;
            _view.OnCariData += _view_OnCariData;
            _view.OnHapusData += _view_OnHapusData;
            _view.OnSimpanData += _view_OnBayarOrderan;
            _view.OnBersihkanData += _view_OnBersihkanData;
            _view.OnCetakNota += _view_OnCetakNota;
            _view.OnListDataGridCurrentCellActivated += _view_OnListDataGridCurrentCellActivated;
            _view.OnListDataGridCurrentCellEndEdit += _view_OnListDataGridCurrentCellEndEdit;
            _view.OnListDataGridPreviewKeyDown += _view_OnListDataGridPreviewKeyDown;
        }

        private void _view_OnLoadData(object sender, EventArgs e)
        {
            ((Form)_view).ActiveControl = _view.ListDataGrid;

            _listOrderanDetails = new List<OrderanDetailModel>();

            _bindingView = new BindingListView<OrderanDetailModel>(_listOrderanDetails);
            _bindingView.ListChanged += _bindingView_ListChanged;
            _view.ListDataGrid.DataSource = _bindingView;

            _view.ListDataGrid.Columns[3].AllowEditing = true; // Jumlah
            _view.ListDataGrid.Columns[3].Format = "0";
            _view.ListDataGrid.Columns[3].AdvancedFilterType = Syncfusion.WinForms.GridCommon.AdvancedFilterType.NumberFilter;
            _view.ListDataGrid.Columns[4].AllowEditing = true; // Diskon
            _view.ListDataGrid.Columns[4].Format = "C";

            _view.ListDataGrid.MoveToCurrentCell(new RowColumnIndex(1, 1));
            _view.ListDataGrid.CurrentCell.BeginEdit();
        }

        private void _bindingView_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            HitungGrandTotal();
        }

        private void _view_OnCariData(object sender, EventArgs e)
        {
            if (!_statusPembayaran)
            {
                var view = new CariJenisOrderanView(_listsJenisOrderans, TipePencarian.Orderan, _kodeOrNamaForSearching);
                view.OnSendData += CariBarangView_OnSendData;
                view.OnFormClosing += CariBarangView_OnFormClosing;
                view.ShowDialog();
            }
        }

        private void CariBarangView_OnSendData(object sender, EventArgs e)
        {
            var listDataGrid = _view.ListDataGrid;
            var rowIndex = listDataGrid.RowCount == 0 ? 1 : listDataGrid.RowCount;

            var view = (CariJenisOrderanView)sender;
            var jenisOrderanModel = ((ModelEventArgs<JenisOrderanModel>)e).Value;

            if (jenisOrderanModel != null)
            {
                _listOrderanDetails.Add(new OrderanDetailModel());
                _bindingView.Refresh();

                _listOrderanDetails[(rowIndex - 1)].kode_jenis_orderan = jenisOrderanModel.kode;
                _listOrderanDetails[(rowIndex - 1)].nama_jenis_orderan = jenisOrderanModel.nama;
                _listOrderanDetails[(rowIndex - 1)].harga_satuan = jenisOrderanModel.harga_satuan;
                _listOrderanDetails[(rowIndex - 1)].jumlah = 1;
                _listOrderanDetails[(rowIndex - 1)].harga_satuan = jenisOrderanModel.harga_satuan;
                _listOrderanDetails[(rowIndex - 1)].diskon = 0;

                HitungGrandTotal();
                view.Close();
            }
        }

        private void CariBarangView_OnFormClosing(object sender, EventArgs e)
        {
            _kodeOrNamaForSearching = string.Empty;
        }

        private void _view_OnHapusData(object sender, EventArgs e)
        {
            if (!_statusPembayaran && CurrCellValue != null)
            {
                if (!string.IsNullOrWhiteSpace(CurrCellValue.ToString()))
                {
                    _listOrderanDetails.RemoveAt((CurrCellRowIndex - 1));

                    _bindingView.Refresh();
                    HitungGrandTotal();
                }
            }
        }

        private void _view_OnBayarOrderan(object sender, EventArgs e)
        {
            var isValid = _listOrderanDetails.Any(od => this.isDataValid(od));

            try
            {
                if (!_statusPembayaran && isValid)
                {
                    var view = new BayarOrderanEntryView(_listOrderanDetails);
                    view.OnBayarOrderan += View_OnBayarOrderan;

                    if (view.ShowDialog() == DialogResult.OK)
                    {
                        _view.LabelGrandTotal.Text = _grandTotal.ToString("N0");

                        if (Messages.Confirm("Cetak Nota Orderan?"))
                        {
                            _view_OnCetakNota(null, null);
                        }
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Messages.Error(ex);
            }
            catch (DataAccessException ex)
            {
                Messages.Error(ex);
            }
        }

        private void View_OnBayarOrderan(object sender, OrderanEventArgs e)
        {
            try
            {
                var bayarOrderanEntryView = ((Form)sender);
                var penjualanDetailsFixed = _listOrderanDetails.Where(od => this.isDataValid(od)).ToList();
                _grandTotal = e.GrandTotal;

                // isi data orderan
                _orderanModel = new OrderanModel
                {
                    tanggal = e.Tanggal,
                    Pelanggan = e.Pelanggan,
                };

                _orderanServices.Insert(_orderanModel);
                Messages.Info("Data Orderan berhasil disimpan.");
                _statusPembayaran = true;

                _view.ListDataGrid.Enabled = false;
                _view.TextBoxNoNota.Text = _orderanModel.no_nota;

                if (_orderanModel.total_diskon > 0)
                {
                    _view.LabelGrandTotal.Text = (_orderanModel.OrderanDetails.Sum(pd => pd.jumlah) - _orderanModel.total_diskon).ToString("N0");
                }

                bayarOrderanEntryView.DialogResult = DialogResult.OK;
                ((Form)_view).ActiveControl = _view.TextBoxNoNota;
            }
            catch (ArgumentException ex)
            {
                Messages.Error(ex);
            }
            catch (DataAccessException ex)
            {
                Messages.Error(ex);
            }
        }

        private void _view_OnBersihkanData(object sender, EventArgs e)
        {
            var status = _listOrderanDetails.Any(od => this.isDataValid(od));

            if (status)
            {
                if (!_statusPembayaran)
                {
                    if (Messages.Confirm("Bersihkan data list penjualan?"))
                    {
                        BersihkanDataListOrderan();
                    }
                }
                else
                {
                    BersihkanDataListOrderan();
                }
            }
        }

        private void BersihkanDataListOrderan()
        {
            if (_statusPembayaran)
            {
                _view.ListDataGrid.Enabled = true;
                _view.TextBoxNoNota.Text = string.Empty;
                _listsJenisOrderans = _jenisOrderanServices.GetAll().Where(b => b.harga_satuan > 0).ToList();
                _statusPembayaran = false;
            }

            _kodeOrNamaForSearching = string.Empty;
            _listOrderanDetails.Clear();
            _bindingView.DataSource = _listOrderanDetails;
        }

        private void _view_OnCetakNota(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                if (_statusPembayaran)
                {
                    //ReportHelper.ShowNotaOrderan(_orderanModel);
                }
            }
        }

        private void _view_OnListDataGridCurrentCellActivated(object sender, CurrentCellActivatedEventArgs e)
        {
            _view.ListDataGrid.CurrentCell.BeginEdit();
        }

        private void _view_OnListDataGridCurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            if (CurrCellValue != null)
            {
                var orderDetailCurrentRow = _listOrderanDetails[e.DataRow.Index - 1];
                var subTotal = orderDetailCurrentRow.jumlah * orderDetailCurrentRow.harga_satuan;

                // jika diskon dimasukkan lebih besar dari jumlah orderan
                // set diskon menjadi sub total
                if (decimal.Parse(CurrCellValue.ToString(), NumberStyles.Number) > 0 &&
                    decimal.Parse(CurrCellValue.ToString(), NumberStyles.Number) > subTotal)
                {
                    orderDetailCurrentRow.diskon = subTotal;
                }
            }

            HitungGrandTotal();
        }

        private void HitungGrandTotal()
        {
            _view.LabelGrandTotal.Text = _bindingView.Cast<IOrderanDetailModel>().Sum(pd => pd.sub_total).ToString("N0");
        }

        private void _view_OnListDataGridPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var listDataGrid = _view.ListDataGrid;

            if (!listDataGrid.CurrentCell.IsEditing)
            {
                listDataGrid.CurrentCell.BeginEdit();
            }
        }

        private bool isDataValid(IOrderanDetailModel model)
        {
            return model.kode_jenis_orderan != default && model.nama_jenis_orderan != default;
        }
    }
}
