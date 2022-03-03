using MySql.Data.MySqlClient;
using PrintingApplication.Services.Services.Database;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Database
{
    public class BackupRestoreDatabaseRepository : IBackupRestoreDatabaseRepository
    {
        public void BackupDatabase(string fileLocation)
        {
            try
            {
                using (var context = new DbContext())
                {
                    var mysqlBackup = new MySqlBackup();
                    mysqlBackup.Command = (MySqlCommand)context.Conn.CreateCommand();
                    mysqlBackup.ExportToFile(fileLocation);
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void RestoreDatabase(string fileLocation)
        {
            try
            {
                using (var context = new DbContext())
                {
                    var mysqlBackup = new MySqlBackup();
                    mysqlBackup.Command = (MySqlCommand)context.Conn.CreateCommand();
                    mysqlBackup.ImportFromFile(fileLocation);
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
