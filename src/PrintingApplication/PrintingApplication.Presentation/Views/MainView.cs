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
        public event EventHandler<MainViewEventArgs> OnPelangganViewClick;
        public event EventHandler<MainViewEventArgs> OnUserViewClick;
        public event EventHandler<MainViewEventArgs> OnRoleViewClick;
        public event EventHandler<MainViewEventArgs> OnOrderanViewClick;
        public event EventHandler<MainViewEventArgs> OnPengeluaranViewClick;
        public event EventHandler<MainViewEventArgs> OnLaporanOrderanViewClick;
        public event EventHandler<MainViewEventArgs> OnLaporanPengeluaranViewClick;
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
            _dockPanel.Theme = new VS2005Theme();

            _dockPanel.DockBackColor = Color.Transparent;

            // Jika gambar di config file tidak kosong dan file gambar tersedia,
            // atur gambar ke DockPanel BackgroudImage
            var gambar = MainProgram.PengaturanModel.path_background;
            if (!string.IsNullOrWhiteSpace(gambar) && File.Exists(gambar))
            {
                _dockPanel.BackgroundImage = Image.FromFile(gambar);
            }

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

        private void toolStripMenuItemPelanggan_Click(object sender, EventArgs e)
        {
            OnPelangganViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripButtonPelanggan_Click(object sender, EventArgs e)
        {
            toolStripMenuItemPelanggan_Click(sender, e);
        }

        private void toolStripMenuItemUser_Click(object sender, EventArgs e)
        {
            OnUserViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemRole_Click(object sender, EventArgs e)
        {
            OnRoleViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemOrderan_Click(object sender, EventArgs e)
        {
            OnOrderanViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripButtonOrderan_Click(object sender, EventArgs e)
        {
            toolStripMenuItemOrderan_Click(sender, e);
        }

        private void toolStripMenuItemJenisOrderan_Click(object sender, EventArgs e)
        {
            OnJenisOrderanViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripButtonJenisOrderan_Click(object sender, EventArgs e)
        {
            toolStripMenuItemJenisOrderan_Click(sender, e);
        }

        private void toolStripMenuItemPengeluaran_Click(object sender, EventArgs e)
        {
            OnPengeluaranViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemLaporanPenjualan_Click(object sender, EventArgs e)
        {
            OnLaporanOrderanViewClick?.Invoke(sender, _eventArgs);
        }

        private void toolStripMenuItemLaporanPengeluaran_Click(object sender, EventArgs e)
        {
            OnLaporanPengeluaranViewClick?.Invoke(sender, _eventArgs);
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
