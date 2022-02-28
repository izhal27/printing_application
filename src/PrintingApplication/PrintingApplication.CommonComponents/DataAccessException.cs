using System;

namespace PrintingApplication.CommonComponents
{
    public class DataAccessException : Exception
    {

        private DataAccessStatus _dataAccessStatus;

        public DataAccessStatus DataAccessStatusInfo
        {
            get { return _dataAccessStatus; }
            set { _dataAccessStatus = value; }
        }

        public DataAccessException()
        {
            //
        }

        public DataAccessException(DataAccessStatus dataAccessStatus)
        {
            _dataAccessStatus = dataAccessStatus;
        }

        public DataAccessException(string message, Exception innerException, DataAccessStatus dataAccessStatus)
           : base(message, innerException)
        {
            _dataAccessStatus = dataAccessStatus;
        }
    }
}
