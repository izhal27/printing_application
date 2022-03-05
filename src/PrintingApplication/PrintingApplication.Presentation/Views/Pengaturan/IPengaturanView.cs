using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Pengaturan
{
    public interface IPengaturanView : IView
    {
        event EventHandler OnLoadData;
        event EventHandler OnButtonDefaultClick;
        event EventHandler OnButtonSaveClick;

        PropertyGrid PropertyGridPengaturan { get; }

        void ShowView();
        void CloseView();
    }
}
