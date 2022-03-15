using Equin.ApplicationFramework;
using Microsoft.Reporting.WinForms;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengeluaran;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Pengeluaran;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using PrintingApplication.Presentation.Views.Pengeluaran;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pengeluaran;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintingApplication.Presentation.Presenters.Pengeluaran
{
    public class LaporanPengeluaranPresenter : ILaporanPengeluaranPresenter
    {
        private ILaporanPengeluaranView _view;
        private IPengeluaranServices _services;
        private List<IPengeluaranModel> _listPengeluarans;
        private BindingListView<PengeluaranModel> _bindingView;
        private string _typeName = "Pengeluaran";
        private TampilkanStatus _tampilkanStatus = TampilkanStatus.Tanggal;
        private DateTime _tanggal = DateTime.Now.Date;
        private DateTime _tanggalAwal;
        private DateTime _tanggalAkhir;

        public ILaporanPengeluaranView GetView
        {
            get { return _view; }
        }

        public LaporanPengeluaranPresenter()
        {
            _view = new LaporanPengeluaranView();
            _services = new PengeluaranServices(new PengeluaranRepository(), new ModelDataAnnotationCheck());

            _view.OnLoadData += _view_OnLoadData;
            _view.OnTampilkanClick += _view_OnTampilkanClick;
            _view.OnDeleteClick += _view_OnDeleteClick;
            _view.OnPrintClick += _view_OnPrintData;
        }

        private void _view_OnLoadData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                _listPengeluarans = _services.GetByDate(DateTime.Now.Date).ToList();
                _bindingView = new BindingListView<PengeluaranModel>(_listPengeluarans);
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
                        var model = _services.GetById(((PengeluaranModel)_view.ListDataGrid.SelectedItem).id);

                        _services.Delete(model);
                        Messages.InfoDelete(_typeName);

                        if (_listPengeluarans.Remove((PengeluaranModel)_view.ListDataGrid.SelectedItem))
                        {
                            _bindingView.DataSource = _listPengeluarans;
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

                    if (_tampilkanStatus == TampilkanStatus.Tanggal)
                    {
                        parameters.Add(new ReportParameter("Tanggal", _tanggal.ToShortDateString()));
                    }
                    else if (_tampilkanStatus == TampilkanStatus.Periode)
                    {
                        parameters.Add(new ReportParameter("Tanggal", _tanggalAwal.ToShortDateString()));
                        parameters.Add(new ReportParameter("TanggalAkhir", _tanggalAkhir.ToShortDateString()));
                    }

                    var reportDataSources = new List<ReportDataSource>()
               {
                  new ReportDataSource {
                     Name = "DSPengeluaran",
                     Value = _bindingView.DataSource
                  }
               };

                    new ReportView("Report Pengeluaran", "ReportViewerLaporanPengeluaran",
                                   reportDataSources, parameters).ShowDialog();
                }
            }
        }

        private void _view_OnTampilkanClick(object sender, FilterDateEventArgs e)
        {
            using (new WaitCursorHandler())
            {
                switch (e.TampilkanStatus)
                {
                    case TampilkanStatus.Tanggal:

                        _listPengeluarans = _services.GetByDate(e.Tanggal.Date).ToList();
                        _bindingView.DataSource = _listPengeluarans;
                        _tanggal = e.Tanggal;

                        break;
                    case TampilkanStatus.Periode:

                        _listPengeluarans = _services.GetByDate(e.TanggalAwal.Date, e.TanggalAkhir.Date).ToList();
                        _bindingView.DataSource = _listPengeluarans;
                        _tanggalAwal = e.TanggalAwal;
                        _tanggalAkhir = e.TanggalAkhir;

                        break;
                }

                _tampilkanStatus = e.TampilkanStatus;
            }
        }
    }
}
