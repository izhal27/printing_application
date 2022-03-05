using Equin.ApplicationFramework;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Domain.Models.Orderan;
using PrintingApplication.Domain.Models.OrderanDetail;
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

namespace PrintingApplication.Presentation.Presenters.Penjualan
{
    public class OrderanPresenter : IOrderanPresenter
    {
        private IOrderanView _view;
        private IOrderanServices _orderanServices;
        private IJenisOrderanServices _jenisOrderanServices;
        private List<OrderanDetailModel> _listOrderanDetails;
        private List<IJenisOrderanModel> _listsJenisOrderans;
        private BindingListView<OrderanDetailModel> _bindingView;
        private bool _statusBayar = false;
        private string _kodeOrNamaForSearching = "";
        private IOrderanModel _orderanModel;
        private decimal _uangKembali;
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
            _orderanServices = new PenjualanServices(new PenjualanRepository(), new ModelDataAnnotationCheck());
            _jenisOrderanServices = new BarangServices(new BarangRepository(), new ModelDataAnnotationCheck());
            _listsJenisOrderans = _jenisOrderanServices.GetAll().Where(b => b.harga_jual > 0).ToList();

            _view.OnLoadData += _view_OnLoadData;
            _view.OnCariData += _view_OnCariData;
            _view.OnHapusData += _view_OnHapusData;
            _view.OnSimpanData += _view_OnBayarPenjualan;
            _view.OnBersihkanData += _view_OnBersihkanData;
            _view.OnCetakNota += _view_OnCetakNota;
            _view.OnListDataGridCurrentCellKeyDown += _view_OnListDataGridCurrentCellKeyDown;
            _view.OnListDataGridCurrentCellActivated += _view_OnListDataGridCurrentCellActivated;
            _view.OnListDataGridCurrentCellEndEdit += _view_OnListDataGridCurrentCellEndEdit;
            _view.OnListDataGridPreviewKeyDown += _view_OnListDataGridPreviewKeyDown;
        }

        private void _view_OnLoadData(object sender, EventArgs e)
        {
            ((Form)_view).ActiveControl = _view.ListDataGrid;

            _listOrderanDetails = new List<OrderanDetailModel>();
            AddDummyPenjualanModel(30);

            _bindingView = new BindingListView<OrderanDetailModel>(_listOrderanDetails);
            _bindingView.ListChanged += _bindingView_ListChanged;
            _view.ListDataGrid.DataSource = _bindingView;

            _view.ListDataGrid.Columns[0].AllowEditing = true; // Kode
            _view.ListDataGrid.Columns[2].AllowEditing = true; // Qty

            _view.ListDataGrid.MoveToCurrentCell(new RowColumnIndex(1, 1));
            _view.ListDataGrid.CurrentCell.BeginEdit();
        }

        private void _bindingView_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            HitungGrandTotal();
        }

        private void _view_OnCariData(object sender, EventArgs e)
        {
            if (!_statusBayar)
            {
                var view = new CariBarangView(_listsJenisOrderans, TipePencarian.Penjualan, _kodeOrNamaForSearching);
                view.OnSendData += CariBarangView_OnSendData;
                view.OnFormClosing += CariBarangView_OnFormClosing;
                view.ShowDialog();
            }
        }

        private void CariBarangView_OnSendData(object sender, EventArgs e)
        {
            var listDataGrid = _view.ListDataGrid;
            var rowIndex = listDataGrid.CurrentCell.RowIndex;

            var view = (CariBarangView)sender;
            var jenisOrderanModel = ((ModelEventArgs<JenisOrderanModel>)e).Value;

            if (jenisOrderanModel != null)
            {
                _listOrderanDetails[(rowIndex - 1)].Barang = jenisOrderanModel;
                _listOrderanDetails[(rowIndex - 1)].barang_id = jenisOrderanModel.id;
                _listOrderanDetails[(rowIndex - 1)].qty = 1;
                _listOrderanDetails[(rowIndex - 1)].hpp = jenisOrderanModel.hpp;
                _listOrderanDetails[(rowIndex - 1)].harga_jual = jenisOrderanModel.harga_jual;

                _view.ListDataGrid.MoveToCurrentCell(new RowColumnIndex(listDataGrid.CurrentCell.RowIndex, 3));
                _view.ListDataGrid.CurrentCell.BeginEdit();
                view.Close();
            }
        }

        private void CariBarangView_OnFormClosing(object sender, EventArgs e)
        {
            _kodeOrNamaForSearching = string.Empty;
        }

        private void _view_OnHapusData(object sender, EventArgs e)
        {
            if (!_statusBayar && CurrCellValue != null)
            {
                if (!string.IsNullOrWhiteSpace(CurrCellValue.ToString()))
                {
                    _listOrderanDetails.RemoveAt((CurrCellRowIndex - 1));
                    _listOrderanDetails.Add(new OrderanDetailModel());
                    _bindingView.DataSource = _listOrderanDetails;
                }
            }
        }

        private void _view_OnBayarPenjualan(object sender, EventArgs e)
        {
            var status = _listOrderanDetails.Any(pd => pd.Barang.id != default(uint));

            try
            {
                if (!_statusBayar && status)
                {
                    var view = new BayarPenjualanEntryView(_listOrderanDetails);
                    view.OnBayarPenjualan += View_OnBayarPenjualan;

                    if (view.ShowDialog() == DialogResult.OK)
                    {
                        _view.LabelGrandTotal.Text = _grandTotal.ToString("N0");

                        if (Messages.Confirm("Cetak Nota Penjualan?"))
                        {
                            _view_OnCetakNota(null, null);
                        }

                        new UangKembaliView(_uangKembali).ShowDialog();
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

        private void View_OnBayarPenjualan(object sender, PembayaranEventArgs e)
        {
            try
            {
                var bayarPenjualanEntryView = ((Form)sender);
                var penjualanDetailsFixed = _listOrderanDetails.Where(pd => pd.Barang.id != default(int)).ToList();
                _uangKembali = e.Kembali;
                _grandTotal = e.GrandTotal;

                _orderanModel = new OrderanModel
                {
                    Pelanggan = e.Pelanggan,
                };

                _orderanServices.Insert(_orderanModel);
                Messages.Info("Data Penjualan berhasil disimpan.");
                _statusBayar = true;

                _view.ListDataGrid.Enabled = false;
                _view.TextBoxNoNota.Text = _orderanModel.no_nota;

                if (_orderanModel.total_diskon > 0)
                {
                    _view.LabelGrandTotal.Text = (_orderanModel.OrderanDetails.Sum(pd => pd.jumlah) - _orderanModel.total_diskon).ToString("N0");
                }

                bayarPenjualanEntryView.DialogResult = DialogResult.OK;
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
            //var status = _listOrderanDetails.Any(pd => pd.Barang.id != default(uint));

            if (status)
            {
                if (!_statusBayar)
                {
                    if (Messages.Confirm("Bersihkan data list penjualan?"))
                    {
                        BersihkanDataListPenjualan();
                    }
                }
                else
                {
                    BersihkanDataListPenjualan();
                }
            }
        }

        private void BersihkanDataListPenjualan()
        {
            if (_statusBayar)
            {
                _view.ListDataGrid.Enabled = true;
                _view.TextBoxNoNota.Text = string.Empty;
                _listsJenisOrderans = _jenisOrderanServices.GetAll().Where(b => b.harga_satuan > 0).ToList();
                _statusBayar = false;
            }

            _kodeOrNamaForSearching = string.Empty;
            _listOrderanDetails.Clear();
            AddDummyPenjualanModel(30);
            _bindingView.DataSource = _listOrderanDetails;
            _view.ListDataGrid.MoveToCurrentCell(new RowColumnIndex(1, 1));
        }

        private void _view_OnCetakNota(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                if (_statusBayar)
                {
                    ReportHelper.ShowNotaPenjualan(_orderanModel);
                }
            }
        }

        private void _view_OnListDataGridCurrentCellKeyDown(object sender, CurrentCellKeyEventArgs e)
        {
            if (e.KeyEventArgs.KeyCode == Keys.Return)
            {
                switch (e.ColumnIndex)
                {
                    case 1: // Kode

                        _view_OnListDataGridCellKodeKeyDown(sender, e);

                        break;

                    case 3: // Qty

                        _view_OnListDataGridCellQtyKeyDown(sender, e);

                        break;
                }
            }
        }

        private void _view_OnListDataGridCellKodeKeyDown(object sender, CurrentCellKeyEventArgs e)
        {
            var listDataGrid = _view.ListDataGrid;

            if (CurrCellValue != null)
            {
                var kode = CurrCellValue.ToString();
                var barangModel = _listsJenisOrderans.Where(b => b.kode.Equals(kode)).FirstOrDefault();

                if (barangModel != null)
                {
                    //_listOrderanDetails[(CurrCellRowIndex - 1)].Barang = barangModel;
                    //_listOrderanDetails[(CurrCellRowIndex - 1)].qty = 1;
                    //_listOrderanDetails[(CurrCellRowIndex - 1)].harga_jual = barangModel.harga_jual;

                    listDataGrid.MoveToCurrentCell(new RowColumnIndex(CurrCellRowIndex, (e.ColumnIndex + 2)));
                    listDataGrid.CurrentCell.BeginEdit();
                    e.KeyEventArgs.Handled = true;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(CurrCellValue.ToString()))
                    {
                        _kodeOrNamaForSearching = CurrCellValue.ToString();
                        _view_OnCariData(null, null);
                    }
                    else
                    {
                        _kodeOrNamaForSearching = "";
                        _view_OnCariData(null, null);
                    }

                    e.KeyEventArgs.Handled = true;
                }
            }
        }

        private void _view_OnListDataGridCellQtyKeyDown(object sender, CurrentCellKeyEventArgs e)
        {
            var listDataGrid = _view.ListDataGrid;

            if (CurrCellValue != null)
            {
                if (CurrCellRowIndex != (listDataGrid.RowCount - 1))
                {
                    if (decimal.Parse(CurrCellValue.ToString(), NumberStyles.Number) > 0)
                    {
                        listDataGrid.MoveToCurrentCell(new RowColumnIndex((CurrCellRowIndex + 1), 1));
                        listDataGrid.CurrentCell.BeginEdit();
                    }

                    e.KeyEventArgs.Handled = true;
                }
                else
                {
                    _listOrderanDetails.Add(new OrderanDetailModel());
                    listDataGrid.MoveToCurrentCell(new RowColumnIndex((CurrCellRowIndex + 1), 1));
                    listDataGrid.CurrentCell.BeginEdit();
                }
            }
        }

        private void _view_OnListDataGridCurrentCellActivated(object sender, CurrentCellActivatedEventArgs e)
        {
            _view.ListDataGrid.CurrentCell.BeginEdit();
        }

        private void _view_OnListDataGridCurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            HitungGrandTotal();
        }

        private void HitungGrandTotal()
        {
            _view.LabelGrandTotal.Text = _bindingView.Cast<IOrderanDetailModel>().Sum(pd => pd.jumlah).ToString("N0");
        }

        private void _view_OnListDataGridPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var listDataGrid = _view.ListDataGrid;

            if (!listDataGrid.CurrentCell.IsEditing)
            {
                listDataGrid.CurrentCell.BeginEdit();
            }
        }

        private void AddDummyPenjualanModel(int length)
        {
            for (int i = 0; i < length; i++)
            {
                _listOrderanDetails.Add(new OrderanDetailModel());
            }
        }
    }
}
