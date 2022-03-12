using ExceptionReporting;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Domain.Models.User;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Pengaturan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Presenters.Login;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pengaturan;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace PrintingApplication.Presentation
{
    internal static class MainProgram
    {
        private static IPengaturanModel _pengaturan;

        public static IPengaturanModel Pengaturan
        {
            get { return _pengaturan ?? (_pengaturan = PengaturanServices.GetModel); }
            set { _pengaturan = value; }
        }

        private static IPengaturanServices _pengaturanServices;

        public static IPengaturanServices PengaturanServices
        {
            get
            {
                return null;
                //return _pengaturanServices ?? (_pengaturanServices = new PengaturanServices(new PengaturanRepository(), new ModelDataAnnotationCheck()));
            }
        }

        public static IUserModel UserActive { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Mengubah Exception dihandle oleh ExceptionReporter
            Application.ThreadException += new ThreadExceptionEventHandler(ReportCrash);

            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                Messages.Error("Aplikasi Sedang Berjalan !!!");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new LoginPresenter().GetView;
            Application.Run((Form)view);
        }

        /// <summary>
        /// Method yang mengubah exception default menjadi ExceptionReporter
        /// </summary>
        /// <param name="e">Exception EventArgs</param>
        public static void ReportCrash(object sender, ThreadExceptionEventArgs e)
        {
            var reporter = new ExceptionReporter();

            reporter.Config.ShowLessDetailButton = true;

            var productName = Application.ProductName;
            var productVersion = Application.ProductVersion;
            // Title form ExceptionReporter
            reporter.Config.TitleText = $"{productName} {productVersion} Exception Report";

            reporter.Show(e.Exception);
        }
    }
}
