using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Database
{
    public interface IBackupRestoreDatabaseView : IView
    {
        event EventHandler OnButtonLocationClick;
        event EventHandler OnButtonBackupRestoreClick;

        TextBox TextBoxLokasi { get; }

        void ShowView();
    }
}