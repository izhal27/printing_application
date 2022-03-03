using Microsoft.Reporting.WinForms;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Presenters.Laporan
{
    public class LaporanStatusBarangPresenter : ILaporanStatusBarangPresenter
    {
        private ILaporanStatusBarangView _view;
        private IStatusBarangServices _services;
        private IStatusBarangModel _model;

        public ILaporanStatusBarangView GetView
        {
            get { return _view; }
        }

        public LaporanStatusBarangPresenter()
        {
            _view = new LaporanStatusBarangView();
            _services = new StatusBarangServices(new StatusBarangRepository());

            _view.OnLoadData += _view_OnLoadData;
            _view.OnDateTimePickerTanggalValueChanged += _view_OnDateTimePickerTanggalValueChanged;
            _view.OnButtonCetakClick += _view_OnButtonCetakClick;
        }

        private void _view_OnLoadData(object sender, EventArgs e)
        {
            SetLabelValues();
        }

        private void _view_OnDateTimePickerTanggalValueChanged(object sender, EventArgs e)
        {
            SetLabelValues();
        }

        private void SetLabelValues()
        {
            _model = _services.GetByDate(_view.DateTimePickerTanggal.Value.Date);

            var stokAwal = 0;
            var stokMasuk = 0;
            var stokKeluar = 0;
            var stokAkhir = 0;
            var penyesuaianStok = 0;
            var returnPenjualan = 0;
            var returnPembelian = 0;

            if (_model != null)
            {
                stokAwal = _model.stok_awal;
                stokMasuk = _model.stok_masuk;
                stokKeluar = _model.stok_terjual;
                stokAkhir = _model.stok_akhir;
                penyesuaianStok = _model.penyesuaian_stok;
                returnPenjualan = _model.penjualan_return_qty;
                returnPembelian = _model.pembelian_return_qty;
            }

            _view.LabelStokAwal.Text = stokAwal.ToString("N0");
            _view.LabelStokMasuk.Text = stokMasuk.ToString("N0");
            _view.LabelStokTerjual.Text = stokKeluar.ToString("N0");
            _view.LabelPenyesuaianStok.Text = penyesuaianStok.ToString("N0");
            _view.LabelStokAkhir.Text = stokAkhir.ToString("N0");
            _view.LabelReturnPenjualan.Text = returnPenjualan.ToString("N0");
            _view.LabelReturnPembelian.Text = returnPembelian.ToString("N0");
        }

        private void _view_OnButtonCetakClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                var reportDataSources = new List<ReportDataSource>()
            {
               new ReportDataSource {
                  Name = "DataSetStatusBarang",
                  Value = new BindingSource(_model, null)
               }
            };

                var parameters = new List<ReportParameter>()
            {
               new ReportParameter("Tanggal", _view.DateTimePickerTanggal.Value.Date.ToShortDateString())
            };

                new ReportView("Report Status Barang", "ReportViewerLaporanStatusBarang",
                               reportDataSources, parameters).ShowDialog();
            }
        }
    }
}
