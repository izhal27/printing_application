using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett.CommonComponents
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
