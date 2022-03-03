using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Login
{
    public interface ILoginView : IView
    {
        event EventHandler OnLoadView;
        event EventHandler OnButtonLoginClick;
        event EventHandler OnButtonSimpanClick;
        event EventHandler OnButtonTesKoneksiClick;

        TabControl TabControlLogin { get; }
        TabPage TabPageLogin { get; }
        TabPage TabPageDatabase { get; }

        BaseTextBox TextBoxLoginID { get; }
        BaseTextBox TextBoxPassword { get; }
        BaseTextBox TextBoxServer { get; }
        BaseTextBox TextBoxDatabase { get; }
        BaseTextBox TextBoxPort { get; }
        BaseTextBox TextBoxUser { get; }
        BaseTextBox TextBoxPasswordDatabase { get; }
    }
}