using Microsoft.Reporting.WinForms;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Presenters.Laporan
{
    public class LaporanTransaksiByDatePresenter : ILaporanTransaksiByDatePresenter
    {
        private ILaporanTransaksiByDateView _view;
        private ITransaksiByDateServices _services;
        private ITransaksiByDateModel _model;

        public ILaporanTransaksiByDateView GetView
        {
            get { return _view; }
        }

        public LaporanTransaksiByDatePresenter()
        {
            _view = new LaporanTransaksiByDateView();
            _services = new TransaksiByDateServices(new TransaksiByDateRepository());

            _view.OnLoadData += _view_OnLoadData;
            _view.OnLabelSelisihTextChanged += _view_OnLabelSelisihTextChanged;
            _view.OnDateTimePickerTanggalValueChanged += _view_OnDateTimePickerTanggalValueChanged;
            _view.OnButtonCetakClick += _view_OnButtonCetakClick;
        }

        private void _view_OnLoadData(object sender, EventArgs e)
        {
            InsertValueToLabels();
        }

        private void _view_OnDateTimePickerTanggalValueChanged(object sender, EventArgs e)
        {
            InsertValueToLabels();
        }

        private void InsertValueToLabels()
        {
            using (new WaitCursorHandler())
            {
                _model = _services.Get(_view.DateTimePickerTanggal.Value.Date);

                if (_model != null)
                {
                    _view.LabelKasAwal.Text = _model.kas_awal.ToString("C");
                    _view.LabelTotalPenjualan.Text = _model.total_penjualan.ToString("C");
                    _view.LabelTotalDiskon.Text = _model.total_diskon.ToString("C");
                    _view.LabelTotalPengeluaran.Text = _model.total_pengeluaran.ToString("C");
                    _view.LabelTotalReturnPenjualan.Text = _model.total_return_penjualan.ToString("C");
                }

                _view.LabelSelisih.Text = _model.selisih.ToString("C");
            }
        }

        private void _view_OnLabelSelisihTextChanged(object sender, EventArgs e)
        {
            var labelSelisih = (Label)sender;
            var selisih = decimal.Parse(labelSelisih.Text, System.Globalization.NumberStyles.Currency);

            labelSelisih.ForeColor = selisih >= 0 ? SystemColors.ControlText : Color.Red;
        }

        private void _view_OnButtonCetakClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                var reportDataSources = new List<ReportDataSource>()
            {
               new ReportDataSource {
                  Name = "DataSetTransaksi",
                  Value = new BindingSource(_model, null)
               }
            };

                var parameters = new List<ReportParameter>()
            {
               new ReportParameter("Tanggal", _view.DateTimePickerTanggal.Value.Date.ToShortDateString())
            };

                new ReportView("Report Transaksi", "ReportViewerLaporanTransaksi",
                               reportDataSources, parameters).ShowDialog();
            }
        }
    }
}
