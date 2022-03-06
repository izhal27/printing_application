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
        event EventHandler<MainViewEventArgs> OnPelangganViewClick;
        event EventHandler<MainViewEventArgs> OnUserViewClick;
        event EventHandler<MainViewEventArgs> OnRoleViewClick;
        event EventHandler<MainViewEventArgs> OnOrderanViewClick;
        event EventHandler<MainViewEventArgs> OnPengeluaranViewClick;
        event EventHandler<MainViewEventArgs> OnLaporanOrderanViewClick;
        event EventHandler<MainViewEventArgs> OnLaporanPengeluaranViewClick;
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
