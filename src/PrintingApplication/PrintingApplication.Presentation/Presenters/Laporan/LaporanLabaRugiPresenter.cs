using Microsoft.Reporting.WinForms;
using PrintingApplication.Domain.Models.Laporan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Laporan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using PrintingApplication.Presentation.Views.Laporan;
using PrintingApplication.Services.Services.Laporan;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Presenters.Laporan
{
    public class LaporanLabaRugiPresenter : ILaporanLabaRugiPresenter
    {
        private ILaporanLabaRugiView _view;
        private ILabaRugiServices _services;
        private ILabaRugiModel _model;

        public ILaporanLabaRugiView GetView
        {
            get { return _view; }
        }

        public LaporanLabaRugiPresenter()
        {
            _view = new LaporanLabaRugiView();
            _services = new LabaRugiServices(new LabaRugiRepository());

            _view.OnLoadData += _view_OnLoadData;
            _view.OnComboBoxBulanSelectedIndexChanged += _view_OnComboBoxBulanSelectedIndexChanged;
            _view.OnNumericUpDownTahunValueChanged += _view_OnNumericUpDownTahunValueChanged;
            _view.OnLabelSelisihTextChanged += _view_OnLabelSelisihTextChanged;
            _view.OnButtonCetakClick += _view_OnButtonCetakClick;
        }

        private void _view_OnLoadData(object sender, EventArgs e)
        {
            _view.NumericUpDownTahun.Maximum = DateTime.Now.Year;
            SetLabelValues();
        }

        private void _view_OnComboBoxBulanSelectedIndexChanged(object sender, EventArgs e)
        {
            SetLabelValues();
        }

        private void _view_OnNumericUpDownTahunValueChanged(object sender, EventArgs e)
        {
            SetLabelValues();
        }

        private void SetLabelValues()
        {
            var bulan = (_view.ComboBoxBulan.SelectedIndex + 1);
            var tahun = _view.NumericUpDownTahun.Value;
            _model = _services.GetByMonthYear(bulan, tahun);


            _view.LabelOrderan.Text = _model.total_orderan.ToString("C");
            _view.LabelPengeluaran.Text = _model.total_pengeluaran.ToString("C");
            _view.LabelDiskonOrderan.Text = _model.total_diskon_orderan.ToString("C");
            _view.LabelTotalSelisih.Text = _model.selisih.ToString("C");
        }

        private void _view_OnLabelSelisihTextChanged(object sender, EventArgs e)
        {
            var labelSelisih = (Label)sender;
            var selisih = decimal.Parse(labelSelisih.Text, NumberStyles.Currency);

            labelSelisih.ForeColor = selisih >= 0 ? SystemColors.ControlText : Color.Red;
        }

        private void _view_OnButtonCetakClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                var reportDataSources = new List<ReportDataSource>()
            {
               new ReportDataSource {
                  Name = "DSLabaRugi",
                  Value = new BindingSource(_model, null)
               }
            };

                var parameters = new List<ReportParameter>()
            {
               new ReportParameter("Bulan", _view.ComboBoxBulan.Text),
               new ReportParameter("Tahun", _view.NumericUpDownTahun.Value.ToString())
            };

                new ReportView("Report Laba Rugi", "ReportViewerLaporanLabaRugi",
                               reportDataSources, parameters).ShowDialog();
            }
        }
    }
}
