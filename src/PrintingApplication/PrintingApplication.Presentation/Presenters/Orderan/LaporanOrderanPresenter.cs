using Equin.ApplicationFramework;
using Microsoft.Reporting.WinForms;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Orderan;
using PrintingApplication.Domain.Models.OrderanDetail;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Orderan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using PrintingApplication.Presentation.Views.Orderan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Orderan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Presenters.Orderan
{
    public class LaporanOrderanPresenter : ILaporanOrderanPresenter
    {
        private ILaporanOrderanView _view;
        private IOrderanServices _services;
        private List<IOrderanModel> _listPenjualans;
        private BindingListView<OrderanModel> _bindingView;
        private string _typeName = "Orderan";
        private DateTime _tanggal = DateTime.Now.Date;
        private TampilkanStatus _tampilkanStatus = TampilkanStatus.Tanggal;
        private DateTime _tanggalAwal;
        private DateTime _tanggalAkhir;

        public ILaporanOrderanView GetView
        {
            get { return _view; }
        }

        public LaporanOrderanPresenter()
        {
            _view = new LaporanOrderanView();
            _services = new OrderanServices(new OrderanRepository(), new ModelDataAnnotationCheck());

            _view.OnLoadData += _view_OnLoadData;
            _view.OnTampilkanClick += _view_OnTampilkanClick;
            _view.OnDeleteClick += _view_OnDeleteClick;
            _view.OnPrintClick += _view_OnPrintData;
            _view.OnDetailClick += _view_OnDetailClick;
            _view.OnDataGridCellDoubleClick += _view_OnDataGridCellDoubleClick;
        }

        private void _view_OnLoadData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                _listPenjualans = _services.GetByDate(DateTime.Now.Date).ToList();
                _bindingView = new BindingListView<OrderanModel>(_listPenjualans);
                _view.ListDataGrid.DataSource = _bindingView;
            }
        }

        private void _view_OnDeleteClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                if (_view.ListDataGrid != null && _view.ListDataGrid.SelectedItem != null && Messages.ConfirmDelete(_typeName))
                {
                    try
                    {
                        var model = _services.GetById(((OrderanModel)_view.ListDataGrid.SelectedItem).id);

                        _services.Delete(model);
                        Messages.InfoDelete(_typeName);

                        if (_listPenjualans.Remove((OrderanModel)_view.ListDataGrid.SelectedItem))
                        {
                            _bindingView.DataSource = _listPenjualans;
                        }
                    }
                    catch (DataAccessException ex)
                    {
                        Messages.Error(ex);
                    }
                    finally
                    {
                        if (_view.ListDataGrid.SelectedItem != null)
                        {
                            _view.ListDataGrid.SelectedItem = null;
                        }
                    }
                }
            }
        }

        private void _view_OnPrintData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                if (_bindingView.DataSource.Count > 0)
                {
                    var parameters = new List<ReportParameter>();

                    var listObjs = new List<IOrderanReportModel>();

                    if (_tampilkanStatus == TampilkanStatus.Tanggal)
                    {
                        listObjs = _services.GetReportByDate(_tanggal).ToList();

                        parameters.Add(new ReportParameter("Tanggal", _tanggal.ToShortDateString()));
                    }
                    else if (_tampilkanStatus == TampilkanStatus.Periode)
                    {
                        listObjs = _services.GetReportByDate(_tanggalAwal, _tanggalAkhir).ToList();

                        parameters.Add(new ReportParameter("Tanggal", _tanggalAwal.ToShortDateString()));
                        parameters.Add(new ReportParameter("TanggalAkhir", _tanggalAkhir.ToShortDateString()));
                    }

                    var reportDataSources = new List<ReportDataSource>()
               {
                  new ReportDataSource {
                     Name = "DataSetPenjualan",
                     Value = listObjs
                  }
               };

                    new ReportView("Laporan Orderan", "ReportViewerLaporanPenjualan",
                                   reportDataSources, parameters).ShowDialog();
                }
            }
        }

        private void _view_OnDetailClick(object sender, EventArgs e)
        {
            var model = (OrderanModel)_view.ListDataGrid.SelectedItem;

            if (model != null)
            {
                var detailView = new DetailView("Detail Orderan", "barang_nama");
                detailView.OnLoadView += DetailView_OnLoadView;
                detailView.OnButtonCetakClick += DetailView_OnButtonCetakClick;
                detailView.ShowDialog();
            }
        }

        private void DetailView_OnLoadView(object sender, EventArgs e)
        {
            var modelDetails = ((OrderanModel)_view.ListDataGrid.SelectedItem).OrderanDetails.ToList();
            var detailView = (DetailView)sender;

            if (modelDetails != null && modelDetails.Count > 0)
            {
                var bindingDetialView = new BindingListView<OrderanDetailModel>(modelDetails);
                detailView.ListDataGrid.DataSource = bindingDetialView;
            }
        }

        private void DetailView_OnButtonCetakClick(object sender, EventArgs e)
        {
            var OrderanModel = (OrderanModel)_view.ListDataGrid.SelectedItem;

            //ReportHelper.ShowNotaPenjualan(OrderanModel);

            ((Form)sender).Close();
        }

        private void _view_OnTampilkanClick(object sender, FilterDateEventArgs e)
        {
            using (new WaitCursorHandler())
            {
                _tampilkanStatus = e.TampilkanStatus;

                switch (e.TampilkanStatus)
                {
                    case TampilkanStatus.Tanggal:

                        _listPenjualans = _services.GetByDate(e.Tanggal.Date).ToList();
                        _bindingView.DataSource = _listPenjualans;
                        _tanggal = e.Tanggal.Date;

                        break;
                    case TampilkanStatus.Periode:

                        _listPenjualans = _services.GetByDate(e.TanggalAwal.Date, e.TanggalAkhir.Date).ToList();
                        _bindingView.DataSource = _listPenjualans;
                        _tanggalAwal = e.TanggalAwal.Date;
                        _tanggalAkhir = e.TanggalAkhir.Date;

                        break;
                }

                if (_view.ListDataGrid.SelectedItem != null)
                {
                    _view.ListDataGrid.SelectedItem = null;
                }
            }
        }

        private void _view_OnDataGridCellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            _view_OnDetailClick(null, null);
        }
    }
}
