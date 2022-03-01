using MySql.Data.MySqlClient;
using PrintingApplication.CommonComponents;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories
{
    public class DbContext : IDisposable
    {
        private IDbConnection _conn;
        private IDbTransaction _transaction;
        private readonly string _connString;
        private static readonly string _providerName = @"MySql.Data.MySqlClient";

        public IDbConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection(_connString, _providerName)); }
        }

        public IDbTransaction Transaction
        {
            get { return _transaction; }
        }

        public DbContext()
        {
            var server = ConfigurationManager.AppSettings["Server"] ?? "";
            var port = ConfigurationManager.AppSettings["Port"] ?? "";
            var database = ConfigurationManager.AppSettings["Database"] ?? "";
            var user = ConfigurationManager.AppSettings["User"] ?? "";
            var password = ConfigurationManager.AppSettings["Password"] ?? "";

            _connString = $@"server={server};port={port};database={database};username={user};password={password};";

            if (_conn == null)
            {
                _conn = GetOpenConnection(_connString, _providerName);
            }
        }

        public DbContext(string server, string port, string database, string user, string password = "")
        {
            server = !string.IsNullOrWhiteSpace(server) ? server : "localhost";
            port = !string.IsNullOrWhiteSpace(port) ? port : "3306";
            user = !string.IsNullOrWhiteSpace(user) ? user : "root";

            _connString = $@"server={server};port={port};database={database};username={user};password={password};";

            if (_conn == null)
            {
                _conn = GetOpenConnection(_connString, _providerName);
            }
        }

        private IDbConnection GetOpenConnection(string connString, string providerName)
        {
            IDbConnection conn = null;
            var dataAccessStatus = new DataAccessStatus();

            try
            {
                var provider = DbProviderFactories.GetFactory(providerName);
                conn = provider.CreateConnection();
                conn.ConnectionString = connString;
                conn.Open();
            }
            catch (MySqlException ex)
            {
                dataAccessStatus.SetValues(status: "Error", operationSucceeded: false, exceptionMessage: ex.Message,
                                           customMessage: "Tidak dapat membuka koneksi ke Database.\n" +
                                           "Periksa data Database, Port, User dan Password database.",
                                           helpLink: ex.HelpLink, errorCode: ex.ErrorCode, stackTrace: ex.StackTrace);
                throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                              dataAccessStatus: dataAccessStatus);
            }

            return conn;
        }

        public bool TesKoneksi()
        {
            var isConnected = false;

            try
            {
                using (var conn = GetOpenConnection(_connString, _providerName))
                {
                    isConnected = conn.State == ConnectionState.Open;
                }
            }
            catch
            {
            }

            return isConnected;
        }

        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            if (_transaction == null)
            {
                _transaction = Conn.BeginTransaction(isolationLevel);
            }
        }

        public void Commit()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
                _transaction = null;
            }
        }

        public void RollBack()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State == ConnectionState.Open)
                    {
                        RollBack();
                        _conn.Close();
                    }
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
