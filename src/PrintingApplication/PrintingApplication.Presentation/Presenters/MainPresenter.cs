using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Presenters.Database;
using PrintingApplication.Presentation.Presenters.GantiPassword;
//using PrintingApplication.Presentation.Presenters.Laporan;
using PrintingApplication.Presentation.Presenters.Login;
using PrintingApplication.Presentation.Presenters.Pelanggan;
using PrintingApplication.Presentation.Presenters.Pengaturan;
using PrintingApplication.Presentation.Presenters.Pengeluaran;
using PrintingApplication.Presentation.Presenters.Role;
using PrintingApplication.Presentation.Presenters.JenisOrderan;
using PrintingApplication.Presentation.Presenters.User;
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
            //// Operasi
            //_view.OnLogOutClick += _view_OnLogOutClick;
            //_view.OnGantiPasswordViewClick += _view_OnGantiPasswordViewClick;
            //// Master
            //_view.OnTipeViewClick += _view_OnTipeViewClick;
            //_view.OnSubTipeViewClick += _view_OnSubTipeViewClick;
            //_view.OnSupplierViewClick += _view_OnSupplierViewClick;
            //_view.OnBarangViewClick += _view_OnBarangViewClick;
            //_view.OnSatuanViewClick += _view_OnSatuanViewClick;
            //_view.OnPelangganViewClick += _view_OnPelangganViewClick;
            //_view.OnUserViewClick += _view_OnUserViewClick;
            //_view.OnRoleViewClick += _view_OnRoleViewClick;
            //// Data
            //_view.OnPenyesuaianStokViewClick += _view_OnPenyesuaianStokViewClick;
            //_view.OnHutangOperasionalViewClick += _view_OnHutangOperasionalViewClick;
            //// Transaksi
            //_view.OnKasAwalViewClick += _view_OnKasAwalViewClick;
            //_view.OnPenjualanViewClick += _view_OnPenjualanViewClick;
            //_view.OnPembelianViewClick += _view_OnPembelianViewClick;
            //_view.OnPengeluaranViewClick += _view_OnPengeluaranViewClick;
            //_view.OnReturnPenjualanViewClick += _view_OnReturnPenjualanViewClick;
            //_view.OnReturnPembelianViewClick += _view_OnReturnPembelianViewClick;
            //// Laporan
            //_view.OnLaporanPenjualanViewClick += _view_OnLaporanPenjualanViewClick;
            //_view.OnLaporanPembelianViewClick += _view_OnLaporanPembelianViewClick;
            //_view.OnLaporanPengeluaranViewClick += _view_OnLaporanPengeluaranViewClick;
            //_view.OnLaporanTransaksiByDateViewClick += _view_OnLaporanTransaksiByDateViewClick;
            //_view.OnLaporanReturnPenjualanViewClick += _view_OnLaporanReturnPenjualanViewClick;
            //_view.OnLaporanReturnPembelianViewClick += _view_OnLaporanReturnPembelianViewClick;
            //_view.OnLaporanStatusBarangViewClick += _view_OnLaporanStatusBarangViewClick;
            //_view.OnLaporanStatusPerBarangViewClick += _view_OnLaporanStatusPerBarangViewClick;
            //_view.OnLaporanGrafikBarangTerjualViewClick += _view_OnLaporanGrafikBarangTerjualViewClick;
            //_view.OnLaporanLabaRugiViewClick += _view_OnLaporanLabaRugiViewClick;
            //// Database
            //_view.OnBackupDatabaseViewClick += _view_OnBackupDatabaseViewClick;
            //_view.OnRestoreDatabaseViewClick += _view_OnRestoreDatabaseViewClick;
            //// Alat
            //_view.OnPengaturanViewClick += _view_OnPengaturanViewClick;
            //// Bantuan
            //_view.OnTentangViewClick += _view_OnTentangViewClick;
        }

        private void _view_OnViewLoad(object sender, EventArgs e)
        {
            _view.ToolStrip.Visible = MainProgram.Pengaturan.show_tool_strip;
            _view.StatusStrip.Visible = MainProgram.Pengaturan.show_status_strip;
        }

        //private void _view_OnLogOutClick(object sender, EventArgs e)
        //{
        //    if (!sender.GetType().Name.Equals(((Form)_view).GetType().Name))
        //    {
        //        if (!Messages.Confirm("Lanjutkan proses Logout?"))
        //        {
        //            return;
        //        }
        //    }

        //    MainProgram.UserActive = null;
        //    ((Form)_view).Dispose();
        //    ((Form)new LoginPresenter().GetView).ShowDialog();
        //}

        //private void _view_OnGantiPasswordViewClick(object sender, EventArgs e)
        //{
        //    using (new WaitCursorHandler())
        //    {
        //        new GantiPasswordPresenter().GetView.ShowView();
        //    }
        //}

        //private void _view_OnTipeViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new TipePresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnSubTipeViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new SubTipePresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnSupplierViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new SupplierPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnBarangViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new BarangPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnSatuanViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new SatuanPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnPelangganViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new PelangganPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnUserViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new UserPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnRoleViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new RolePresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnKasAwalViewClick(object sender, EventArgs e)
        //{
        //    using (new WaitCursorHandler())
        //    {
        //        new KasAwalPresenter().GetView.ShowView();
        //    }
        //}

        //private void _view_OnHutangOperasionalViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new HutangOperasionalPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnPenjualanViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new PenjualanPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnPembelianViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new PembelianPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnPengeluaranViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new PengeluaranPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnReturnPenjualanViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new PenjualanReturnPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnReturnPembelianViewClick(object sender, MainViewEventArgs e)
        //{

        //    var view = (DockContent)new PembelianReturnPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnPenyesuaianStokViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new PenyesuaianStokPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnLaporanPenjualanViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new LaporanPenjualanPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnLaporanPembelianViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new LaporanPembelianPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnLaporanPengeluaranViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new LaporanPengeluaranPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnLaporanTransaksiByDateViewClick(object sender, EventArgs e)
        //{
        //    using (new WaitCursorHandler())
        //    {
        //        new LaporanTransaksiByDatePresenter().GetView.ShowView();
        //    }
        //}

        //private void _view_OnLaporanReturnPenjualanViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new LaporanReturnPenjualanPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnLaporanReturnPembelianViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new LaporanReturnPembelianPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnLaporanStatusBarangViewClick(object sender, EventArgs e)
        //{
        //    using (new WaitCursorHandler())
        //    {
        //        new LaporanStatusBarangPresenter().GetView.ShowView();
        //    }
        //}

        //private void _view_OnLaporanStatusPerBarangViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new LaporanStatusPerBarangPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnLaporanGrafikBarangTerjualViewClick(object sender, MainViewEventArgs e)
        //{
        //    var view = (DockContent)new GrafikBarangTerjualPresenter().GetView;
        //    ShowChildForm(view, e);
        //}

        //private void _view_OnLaporanLabaRugiViewClick(object sender, EventArgs e)
        //{
        //    using (new WaitCursorHandler())
        //    {
        //        new LaporanLabaRugiPresenter().GetView.ShowView();
        //    }
        //}

        //private void _view_OnPengaturanViewClick(object sender, EventArgs e)
        //{
        //    using (new WaitCursorHandler())
        //    {
        //        var view = new PengaturanPresenter().GetView;
        //        if (((Form)view).ShowDialog() == DialogResult.OK)
        //        {
        //            _view.ToolStrip.Visible = MainProgram.Pengaturan.show_tool_strip;
        //            _view.StatusStrip.Visible = MainProgram.Pengaturan.show_status_strip;
        //        }
        //    }
        //}

        //private void _view_OnBackupDatabaseViewClick(object sender, EventArgs e)
        //{
        //    using (new WaitCursorHandler())
        //    {
        //        new BackupRestoreDatabasePresenter(DatabaseMethod.Backup).GetView.ShowView();
        //    }
        //}

        //private void _view_OnRestoreDatabaseViewClick(object sender, EventArgs e)
        //{
        //    using (new WaitCursorHandler())
        //    {
        //        new BackupRestoreDatabasePresenter(DatabaseMethod.Restore).GetView.ShowView();
        //    }
        //}

        //private void _view_OnTentangViewClick(object sender, EventArgs e)
        //{
        //    using (new WaitCursorHandler())
        //    {
        //        new TentangPresenter().GetView.ShowView();
        //    }
        //}

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
