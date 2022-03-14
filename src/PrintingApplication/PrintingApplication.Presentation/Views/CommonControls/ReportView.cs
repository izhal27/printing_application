using Microsoft.Reporting.WinForms;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Presentation.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public partial class ReportView : Form
    {

        #region >> Fields <<

        private string _reportNameSpace = @"PrintingApplication.Report.{0}.rdlc";
        private Assembly _assemblyReport;

        #endregion

        // ----------------------------------------------------------------------//

        #region >> Constructor <<

        public ReportView(string textForm, string reportName, IEnumerable<ReportDataSource> reportDataSource
           , IEnumerable<ReportParameter> parameters = null)
        {
            InitializeComponent();

            try
            {
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;

                _assemblyReport = Assembly.LoadFrom("PrintingApplication.Report.dll");

                Text = textForm; // Title Form preview

                reportName = string.Format(_reportNameSpace, reportName);
                var reportDefinition = _assemblyReport.GetManifestResourceStream(reportName);

                reportViewer.LocalReport.DataSources.Clear();

                var reportDatasourcePengaturan = new ReportDataSource
                {
                    Name = "DSPengaturan",
                    Value = new BindingSource(MainProgram.PengaturanModel ?? new PengaturanModel(), null)
                };

                if (reportDataSource != null)
                    reportDataSource.ToList().ForEach(rd => reportViewer.LocalReport.DataSources.Add(rd));

                reportViewer.LocalReport.DataSources.Add(reportDatasourcePengaturan);
                reportViewer.LocalReport.LoadReportDefinition(reportDefinition);
                reportViewer.LocalReport.EnableExternalImages = true;

                if (parameters != null)
                    reportViewer.LocalReport.SetParameters(parameters);

                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                Messages.Error(ex);
            }
        }

        #endregion

    }
}
