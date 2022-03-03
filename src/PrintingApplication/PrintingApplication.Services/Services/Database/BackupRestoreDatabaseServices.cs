namespace PrintingApplication.Services.Services.Database
{
    public class BackupRestoreDatabaseServices : IBackupRestoreDatabaseServices
    {
        private IBackupRestoreDatabaseRepository _repo;

        public BackupRestoreDatabaseServices(IBackupRestoreDatabaseRepository repo)
        {
            _repo = repo;
        }

        public void BackupDatabase(string fileLocation)
        {
            _repo.BackupDatabase(fileLocation);
        }

        public void RestoreDatabase(string fileLocation)
        {
            _repo.RestoreDatabase(fileLocation);
        }
    }
}
