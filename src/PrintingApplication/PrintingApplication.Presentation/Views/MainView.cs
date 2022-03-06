using PrintingApplication.Presentation.Helper;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PrintingApplication.Presentation.Views
{
    public partial class MainView : DockContent, IMainView
    {
        private readonly DockPanel _dockPanel;
        private readonly MainViewEventArgs _eventArgs;

        public event EventHandler OnViewLoad;
        public event EventHandler OnLogOutClick;
        public event EventHandler OnGantiPasswordViewClick;
        public event EventHandler<MainViewEventArgs> OnJenisOrderanViewClick;
        public event EventHandler<MainViewEventArgs> OnSubTipeViewClick;
        public event EventHandler<MainViewEventArgs> OnSupplierViewClick;
        public event EventHandler<MainViewEventArgs> OnSatuanViewClick;
        public event EventHandler<MainViewEventArgs> OnBarangViewClick;
        public event EventHandler<MainViewEventArgs> OnPelangganViewClick;
        public event EventHandler<MainViewEventArgs> OnUserViewClick;
        public event EventHandler<MainViewEventArgs> OnRoleViewClick;
        public event EventHandler<MainViewEventArgs> OnPenyesuaianStokViewClick;
        public event EventHandler<MainViewEventArgs> OnHutangOperasionalViewClick;
        public event EventHandler OnKasAwalViewClick;
        public event EventHandler<MainViewEventArgs> OnOrderanViewClick;
        public event EventHandler<MainViewEventArgs> OnPembelianViewClick;
        public event EventHandler<MainViewEventArgs> OnPengeluaranViewClick;
        public event EventHandler<MainViewEventArgs> OnReturnPenjualanViewClick;
        public event EventHandler<MainViewEventArgs> OnReturnPembelianViewClick;
        public event EventHandler<MainViewEventArgs> OnLaporanPenjualanViewClick;
        public event EventHandler<MainViewEventArgs> OnLaporanPembelianViewClick;
        public event EventHandler<MainViewEventArgs> OnLaporanPengeluaranViewClick;
        public event EventHandler OnLaporanTransaksiByDateViewClick;
        public event EventHandler<MainViewEventArgs> OnLaporanReturnPenjualanViewClick;
        public event EventHandler<MainViewEventArgs> OnLaporanReturnPembelianViewClick;
        public event EventHandler OnLaporanStatusBarangViewClick;
        public event EventHandler<MainViewEventArgs> OnLaporanStatusPerBarangViewClick;
        public event EventHandler<MainViewEventArgs> OnLaporanGrafikBarangTerjualViewClick;
        public event EventHandler OnLaporanLabaRugiViewClick;
        public event EventHandler OnPengaturanViewClick;
        public event EventHandler OnBackupDatabaseViewClick;
        public event EventHandler OnRestoreDatabaseViewClick;
        public event EventHandler OnTentangViewClick;

        public MenuStrip MenuStrip
        {
            get { return menuStripMain; }
        }

        public ToolStrip ToolStrip
        {
            get { return toolStripMain; }
        }

        public StatusStrip StatusStrip
        {
            get { return statusStripMain; }
        }

        public MainView()
        {
            InitializeComponent();

            _dockPanel = new DockPanel();
            _dockPanel.Parent = this;
            _dockPanel.Dock = DockStyle.Fill;
            _dockPanel.BackgroundImageLayout = ImageLayout.Stretch;
            _dockPanel.BringToFront();
            _dockPanel.DocumentTabStripLocation = DocumentTabStripLocation.Top;
            _dockPanel.AllowEndUserDocking = false;
            _dockPanel.AllowEndUserNestedDocking = false;
            _dockPanel.ShowDocumentIcon = false;
            _dockPanel.Theme = DockpanelThemeHelper.GetTheme((int)MainProgram.Pengaturan.dockpanel_theme);

            _dockPanel.DockBackColor = Color.Transparent;

            // Jika gambar di config file tidak kosong dan file gambar tersedia,
            // atur gambar ke DockPanel BackgroudImage
            var gambar = MainProgram.Pengaturan.path_background;
            if (!string.IsNullOrWhiteSpace(gambar) && File.Exists(gambar))
                _dockPanel.BackgroundImage = Image.FromFile(gambar);

            _eventArgs = new MainViewEventArgs(_dockPanel);

            toolStripStatusLabelMachineName.Text = Environment.MachineName;
            toolStripStatusLabelTanggal.Text = DateTime.Now.ToShortDateString();
            var server = ConfigurationManager.AppSettings["Server"] ?? "";
            var port = ConfigurationManager.AppSettings["Port"] ?? "";
            toolStripStatusLabelServer.Text = server + ":" + port;
            toolStripStatusLabelUser.Text = MainProgram.UserActive.login_id;
            toolStripStatusLabelDatabase.Text = ConfigurationManager.AppSettings["Database"] ?? "";
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            OnViewLoad?.Invoke(sender, e);
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnLogOutClick?.Invoke(sender, e);
        }

        private void toolStripMenuItemGantiPassword_Click(object sender, EventArgs e)
        {
            OnGantiPasswordViewClick?.Invoke(sender, e);
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            OnLogOutClick?.Invoke(sender, e);
        }

        private void toolStripMenuItemTipe_Click(object sender, EventArgs e)
        {
            OnJenisOrderanViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemSubTipe_Click(object sender, EventArgs e)
        {
            OnSubTipeViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemSupplier_Click(object sender, EventArgs e)
        {
            OnSupplierViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemBarang_Click(object sender, EventArgs e)
        {
            OnBarangViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripButtonBarang_Click(object sender, EventArgs e)
        {
            toolStripMenuItemBarang_Click(sender, e);
        }

        private void toolStripMenuItemSatuan_Click(object sender, EventArgs e)
        {
            OnSatuanViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemPelanggan_Click(object sender, EventArgs e)
        {
            OnPelangganViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemUser_Click(object sender, EventArgs e)
        {
            OnUserViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemRole_Click(object sender, EventArgs e)
        {
            OnRoleViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemPenyesuaianStok_Click(object sender, EventArgs e)
        {
            OnPenyesuaianStokViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemHutangOperasional_Click(object sender, EventArgs e)
        {
            OnHutangOperasionalViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemKasAwal_Click(object sender, EventArgs e)
        {
            OnKasAwalViewClick?.Invoke(sender, e);
        }

        private void toolStripMenuItemPenjualan_Click(object sender, EventArgs e)
        {
            OnOrderanViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripButtonPenjualan_Click(object sender, EventArgs e)
        {
            toolStripMenuItemPenjualan_Click(sender, e);
        }

        private void toolStripMenuItemPembelian_Click(object sender, EventArgs e)
        {
            OnPembelianViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripButtonPembelian_Click(object sender, EventArgs e)
        {
            toolStripMenuItemPembelian_Click(sender, e);
        }

        private void toolStripMenuItemPengeluaran_Click(object sender, EventArgs e)
        {
            OnPengeluaranViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemReturnPenjualan_Click(object sender, EventArgs e)
        {
            OnReturnPenjualanViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemReturnPembelian_Click(object sender, EventArgs e)
        {
            OnReturnPembelianViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemLaporanPenjualan_Click(object sender, EventArgs e)
        {
            OnLaporanPenjualanViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemLaporanPembelian_Click(object sender, EventArgs e)
        {
            OnLaporanPembelianViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemLaporanPengeluaran_Click(object sender, EventArgs e)
        {
            OnLaporanPengeluaranViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemTransaksiByDate_Click(object sender, EventArgs e)
        {
            OnLaporanTransaksiByDateViewClick?.Invoke(sender, e);
        }

        private void toolStripMenuItemLaporanReturnPenjualan_Click(object sender, EventArgs e)
        {
            OnLaporanReturnPenjualanViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemLaporanReturnPembelian_Click(object sender, EventArgs e)
        {
            OnLaporanReturnPembelianViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemPerHari_Click(object sender, EventArgs e)
        {
            OnLaporanStatusBarangViewClick?.Invoke(sender, e);
        }

        private void toolStripMenuItemPerBarang_Click(object sender, EventArgs e)
        {
            OnLaporanStatusPerBarangViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemBarangTerjual_Click(object sender, EventArgs e)
        {
            OnLaporanGrafikBarangTerjualViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemLabaRugi_Click(object sender, EventArgs e)
        {
            OnLaporanLabaRugiViewClick?.Invoke(sender, e);
        }

        private void toolStripMenuItemPengaturan_Click(object sender, EventArgs e)
        {
            OnPengaturanViewClick?.Invoke(sender, e);
        }

        private void toolStripMenuItemBackupDatabase_Click(object sender, EventArgs e)
        {
            OnBackupDatabaseViewClick?.Invoke(sender, e);
        }

        private void toolStripMenuItemRestoreDatabase_Click(object sender, EventArgs e)
        {
            OnRestoreDatabaseViewClick?.Invoke(sender, e);
        }

        private void toolStripMenuItemTentang_Click(object sender, EventArgs e)
        {
            OnTentangViewClick?.Invoke(sender, e);
        }

        private void toolStripButtonLogOut_Click(object sender, EventArgs e)
        {
            OnLogOutClick?.Invoke(sender, e);
        }
    }
}
