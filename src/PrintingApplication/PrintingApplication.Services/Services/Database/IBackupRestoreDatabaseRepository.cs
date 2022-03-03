namespace PrintingApplication.Services.Services.Database
{
    public interface IBackupRestoreDatabaseRepository
    {
        void BackupDatabase(string fileLocation);
        void RestoreDatabase(string fileLocation);
    }
}
