using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PrintingApplication.Presentation.Views
{
    public interface IMainView : IView
    {
        event EventHandler OnViewLoad;
        event EventHandler OnLogOutClick;
        event EventHandler OnGantiPasswordViewClick;
        event EventHandler<MainViewEventArgs> OnJenisOrderanViewClick;
        event EventHandler<MainViewEventArgs> OnSubTipeViewClick;
        event EventHandler<MainViewEventArgs> OnSupplierViewClick;
        event EventHandler<MainViewEventArgs> OnSatuanViewClick;
        event EventHandler<MainViewEventArgs> OnBarangViewClick;
        event EventHandler<MainViewEventArgs> OnPelangganViewClick;
        event EventHandler<MainViewEventArgs> OnUserViewClick;
        event EventHandler<MainViewEventArgs> OnRoleViewClick;
        event EventHandler<MainViewEventArgs> OnPenyesuaianStokViewClick;
        event EventHandler<MainViewEventArgs> OnHutangOperasionalViewClick;
        event EventHandler OnKasAwalViewClick;
        event EventHandler<MainViewEventArgs> OnOrderanViewClick;
        event EventHandler<MainViewEventArgs> OnPembelianViewClick;
        event EventHandler<MainViewEventArgs> OnPengeluaranViewClick;
        event EventHandler<MainViewEventArgs> OnLaporanPenjualanViewClick;
        event EventHandler<MainViewEventArgs> OnLaporanPembelianViewClick;
        event EventHandler<MainViewEventArgs> OnLaporanPengeluaranViewClick;
        event EventHandler<MainViewEventArgs> OnReturnPenjualanViewClick;
        event EventHandler<MainViewEventArgs> OnReturnPembelianViewClick;
        event EventHandler OnLaporanTransaksiByDateViewClick;
        event EventHandler<MainViewEventArgs> OnLaporanReturnPenjualanViewClick;
        event EventHandler<MainViewEventArgs> OnLaporanReturnPembelianViewClick;
        event EventHandler OnLaporanStatusBarangViewClick;
        event EventHandler<MainViewEventArgs> OnLaporanStatusPerBarangViewClick;
        event EventHandler<MainViewEventArgs> OnLaporanGrafikBarangTerjualViewClick;
        event EventHandler OnLaporanLabaRugiViewClick;
        event EventHandler OnPengaturanViewClick;
        event EventHandler OnBackupDatabaseViewClick;
        event EventHandler OnRestoreDatabaseViewClick;
        event EventHandler OnTentangViewClick;

        MenuStrip MenuStrip { get; }
        ToolStrip ToolStrip { get; }
        StatusStrip StatusStrip { get; }
    }

    public class MainViewEventArgs : EventArgs
    {
        public DockPanel DockPanel { get; }

        public MainViewEventArgs(DockPanel dockPanel)
        {
            DockPanel = dockPanel;
        }
    }
}
