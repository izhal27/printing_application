using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Presenters.Database;
using PrintingApplication.Presentation.Presenters.GantiPassword;
using PrintingApplication.Presentation.Presenters.JenisOrderan;
using PrintingApplication.Presentation.Presenters.Login;
using PrintingApplication.Presentation.Presenters.Pelanggan;
using PrintingApplication.Presentation.Presenters.Pengaturan;
using PrintingApplication.Presentation.Presenters.Pengeluaran;
using PrintingApplication.Presentation.Presenters.Role;
using PrintingApplication.Presentation.Presenters.Tentang;
using PrintingApplication.Presentation.Presenters.User;
//using PrintingApplication.Presentation.Presenters.Laporan;
using PrintingApplication.Presentation.Views;
using PrintingApplication.Presentation.Views.Database;
using System;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PrintingApplication.Presentation.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private IMainView _view;

        public IMainView GetView
        {
            get { return _view; }
        }

        public MainPresenter()
        {
            _view = new MainView();

            // Inisialisai data class RoleManager
            RoleManager.MenuStrip = _view.MenuStrip;
            RoleManager.ToolStrip = _view.ToolStrip;
            RoleManager.RoleKode = MainProgram.UserActive.role_kode;

            var roleManager = new RoleManager();

            // DEVELOPER MODE
            //
            // AKtifkan pemanggilan method dibawah ini untuk mereset data pada tabel form_action dan role_detail ketika anda menambahkan Menu, Form, atau control baru,
            // jangan lupa nonaktifkan kembali, agar tidak melakukan reset setiap kali aplikasi dijalankan.
            //
            // roleManager.ResetFormAction(Assembly.GetExecutingAssembly());

            // Enable/Disable MenuStrip dan ToolStrip sesuai Role operator
            roleManager.PopulateRoleDetailToMenuStripAndToolStrip();

            _view.OnViewLoad += _view_OnViewLoad;
            // Operasi
            _view.OnLogOutClick += _view_OnLogOutClick;
            _view.OnGantiPasswordViewClick += _view_OnGantiPasswordViewClick;
            // Master
            _view.OnJenisOrderanViewClick += _view_OnJenisOrderanViewClick;
            _view.OnPelangganViewClick += _view_OnPelangganViewClick;
            _view.OnUserViewClick += _view_OnUserViewClick;
            _view.OnRoleViewClick += _view_OnRoleViewClick;
            // Transaksi
            _view.OnOrderanViewClick += _view_OnOrderanViewClick;
            _view.OnPengeluaranViewClick += _view_OnPengeluaranViewClick;
            // Laporan
            _view.OnLaporanPenjualanViewClick += _view_OnLaporanPenjualanViewClick;
            _view.OnLaporanPengeluaranViewClick += _view_OnLaporanPengeluaranViewClick;
            // Database
            _view.OnBackupDatabaseViewClick += _view_OnBackupDatabaseViewClick;
            _view.OnRestoreDatabaseViewClick += _view_OnRestoreDatabaseViewClick;
            // Alat
            _view.OnPengaturanViewClick += _view_OnPengaturanViewClick;
            // Bantuan
            _view.OnTentangViewClick += _view_OnTentangViewClick;
        }

        private void _view_OnViewLoad(object sender, EventArgs e)
        {
            _view.ToolStrip.Visible = MainProgram.Pengaturan.show_tool_strip;
            _view.StatusStrip.Visible = MainProgram.Pengaturan.show_status_strip;
        }

        private void _view_OnLogOutClick(object sender, EventArgs e)
        {
            if (!sender.GetType().Name.Equals(((Form)_view).GetType().Name))
            {
                if (!Messages.Confirm("Lanjutkan proses Logout?"))
                {
                    return;
                }
            }

            MainProgram.UserActive = null;
            ((Form)_view).Dispose();
            ((Form)new LoginPresenter().GetView).ShowDialog();
        }

        private void _view_OnGantiPasswordViewClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                new GantiPasswordPresenter().GetView.ShowView();
            }
        }

        private void _view_OnJenisOrderanViewClick(object sender, MainViewEventArgs e)
        {
            var view = (DockContent)new JenisOrderanPresenter().GetView;
            ShowChildForm(view, e);
        }

        private void _view_OnPelangganViewClick(object sender, MainViewEventArgs e)
        {
            var view = (DockContent)new PelangganPresenter().GetView;
            ShowChildForm(view, e);
        }

        private void _view_OnUserViewClick(object sender, MainViewEventArgs e)
        {
            var view = (DockContent)new UserPresenter().GetView;
            ShowChildForm(view, e);
        }

        private void _view_OnRoleViewClick(object sender, MainViewEventArgs e)
        {
            var view = (DockContent)new RolePresenter().GetView;
            ShowChildForm(view, e);
        }

        private void _view_OnOrderanViewClick(object sender, MainViewEventArgs e)
        {
            var view = (DockContent)new OrderanPresenter().GetView;
            ShowChildForm(view, e);
        }

        private void _view_OnPengeluaranViewClick(object sender, MainViewEventArgs e)
        {
            var view = (DockContent)new PengeluaranPresenter().GetView;
            ShowChildForm(view, e);
        }

        private void _view_OnLaporanPenjualanViewClick(object sender, MainViewEventArgs e)
        {
            var view = (DockContent)new LaporanPenjualanPresenter().GetView;
            ShowChildForm(view, e);
        }

        private void _view_OnLaporanPengeluaranViewClick(object sender, MainViewEventArgs e)
        {
            var view = (DockContent)new LaporanPengeluaranPresenter().GetView;
            ShowChildForm(view, e);
        }

        private void _view_OnPengaturanViewClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                var view = new PengaturanPresenter().GetView;
                if (((Form)view).ShowDialog() == DialogResult.OK)
                {
                    _view.ToolStrip.Visible = MainProgram.Pengaturan.show_tool_strip;
                    _view.StatusStrip.Visible = MainProgram.Pengaturan.show_status_strip;
                }
            }
        }

        private void _view_OnBackupDatabaseViewClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                new BackupRestoreDatabasePresenter(DatabaseMethod.Backup).GetView.ShowView();
            }
        }

        private void _view_OnRestoreDatabaseViewClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                new BackupRestoreDatabasePresenter(DatabaseMethod.Restore).GetView.ShowView();
            }
        }

        private void _view_OnTentangViewClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                new TentangPresenter().GetView.ShowView();
            }
        }

        /// <summary>
        /// Method untuk menampilkan Form child
        /// </summary>
        /// <param name="form">Form child</param>
        private void ShowChildForm(DockContent form, MainViewEventArgs e)
        {
            using (new WaitCursorHandler())
            {
                // List form yang active
                var formList = ((Form)_view).MdiChildren;

                // Cek jika form belum ada di list, maka buka form baru,
                // sebaliknya aktifkan form jika sudah ada.
                if (!formList.Any(frm => frm.Name == form.Name))
                {
                    form.Owner = ((Form)_view);
                    form.Show(e.DockPanel, DockState.Document);
                }
                else
                {
                    var activeForm = formList.Where(frm => frm.Name == form.Name)
                                     .FirstOrDefault();
                    activeForm.Activate();
                }
            }

            // Enable buttons child form
            new RoleManager().EnableButtons(form);
        }
    }
}
