using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Database
{
    public partial class BackupRestoreDatabaseView : Form, IBackupRestoreDatabaseView
    {
        public event EventHandler OnButtonBackupRestoreClick;
        public event EventHandler OnButtonLocationClick;

        public TextBox TextBoxLokasi
        {
            get { return textBoxLokasi; }
        }

        public BackupRestoreDatabaseView(DatabaseMethod databaseMethod)
        {
            InitializeComponent();

            switch (databaseMethod)
            {
                case DatabaseMethod.Backup:

                    Text = "Backup Database";
                    panelUp.LabelInfo = Text.ToUpper();
                    operationButtons.ButtonSave.Text = "Backup";

                    break;
                case DatabaseMethod.Restore:

                    Text = "Restore Database";
                    panelUp.LabelInfo = Text.ToUpper();
                    operationButtons.ButtonSave.Text = "Restore";

                    break;
            }

            operationButtons.ButtonSave.Click += ButtonSave_Click;
        }

        public void ShowView()
        {
            ShowDialog();
        }

        private void BackupRestoreDatabaseView_Load(object sender, EventArgs e)
        {
            operationButtons.ButtonCancel.DialogResult = DialogResult.Cancel;
            ActiveControl = operationButtons.ButtonCancel;
        }


        private void buttonLokasi_Click(object sender, EventArgs e)
        {
            OnButtonLocationClick?.Invoke(sender, e);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            OnButtonBackupRestoreClick?.Invoke(this, e);
        }
    }

    public enum DatabaseMethod
    {
        Backup,
        Restore
    }
}
