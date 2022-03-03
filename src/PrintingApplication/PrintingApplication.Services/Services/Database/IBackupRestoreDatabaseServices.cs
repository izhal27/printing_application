namespace PrintingApplication.Services.Services.Database
{
    public interface IBackupRestoreDatabaseServices
    {
        void BackupDatabase(string fileLocation);
        void RestoreDatabase(string fileLocation);
    }
}
