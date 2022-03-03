using PrintingApplication.Infrastructure.DataAccess.Repositories.Database;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.Database;
using PrintingApplication.Services.Services.Database;
using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Presenters.Database
{
    public class BackupRestoreDatabasePresenter : IBackupRestoreDatabasePresenter
    {
        private IBackupRestoreDatabaseView _view;
        private DatabaseMethod _databaseMethod;
        private IBackupRestoreDatabaseServices _services;

        public IBackupRestoreDatabaseView GetView
        {
            get { return _view; }
        }

        public BackupRestoreDatabasePresenter(DatabaseMethod databaseMethod)
        {
            _databaseMethod = databaseMethod;
            _view = new BackupRestoreDatabaseView(_databaseMethod);
            _services = new BackupRestoreDatabaseServices(new BackupRestoreDatabaseRepository());

            _view.OnButtonLocationClick += _view_OnButtonLocationClick;
            _view.OnButtonBackupRestoreClick += _view_OnButtonBackupRestoreClick;
        }

        private void _view_OnButtonLocationClick(object sender, EventArgs e)
        {
            var filter = "SQL Files|*.sql";

            if (_databaseMethod == DatabaseMethod.Backup)
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = filter;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lokasi yang akan dijadikan tempat file backup database
                    _view.TextBoxLokasi.Text = saveFileDialog.FileName;
                }
            }
            else if (_databaseMethod == DatabaseMethod.Restore)
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = filter;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lokasi yang akan dijadikan tempat file restore database
                    _view.TextBoxLokasi.Text = openFileDialog.FileName;
                }
            }
        }

        private void _view_OnButtonBackupRestoreClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                var view = (Form)sender;

                try
                {
                    view.Enabled = false;
                    var lokasiFile = _view.TextBoxLokasi.Text;

                    if (!string.IsNullOrWhiteSpace(lokasiFile))
                    {
                        if (_databaseMethod == DatabaseMethod.Backup)
                        {
                            _services.BackupDatabase(lokasiFile);
                            Messages.Info("Backup database berhasil.");
                        }
                        else if (_databaseMethod == DatabaseMethod.Restore)
                        {
                            _services.RestoreDatabase(lokasiFile);
                            Messages.Info("Restore database berhasil.");
                        }
                    }
                    else
                    {
                        Messages.Warning("Anda belum menentukan lokasi file SQL !!!");
                    }
                }
                catch (Exception ex)
                {
                    Messages.Error(ex);
                }
                finally
                {
                    view.Enabled = true;
                }
            }
        }
    }
}
