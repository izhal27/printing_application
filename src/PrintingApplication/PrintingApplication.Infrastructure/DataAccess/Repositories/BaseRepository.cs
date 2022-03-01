using Dapper;
using MySql.Data.MySqlClient;
using PrintingApplication.CommonComponents;
using System;
using System.Collections.Generic;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories
{
    public class BaseRepository<TDomainModel>
    {
        protected enum TypeOfExistenceCheck
        {
            DoesExistInDB,
            DoesNotExistInDB
        }

        protected enum RequestType
        {
            //Insert,
            Update,
            Delete,
            ConfirmInsert,
            ConfirmDelete,
            GetById
        }

        protected enum ErrorMessageType
        {
            Insert,
            AfterInsert,
            ModelNotFound,
            Update,
            Delete,
            FailedDelete,
            GetList,
            GetById,
            QtyEmpty
        }

        protected enum ProcessType
        {
            Insert,
            Update,
            Delete
        }

        protected static string _modelName = "";

        protected void Insert(TDomainModel model, Action insertMethod, DataAccessStatus dataAccessStatus,
                              Func<bool> checkIAftertInsert)
        {
            try
            {
                insertMethod();
            }
            catch (MySqlException ex)
            {
                dataAccessStatus = SetDataAccessValues(ex, ErrorMessageType.Insert);
                throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                              dataAccessStatus: dataAccessStatus);
            }

            try
            {
                RecordExistsCheck(model, TypeOfExistenceCheck.DoesExistInDB, RequestType.ConfirmInsert,
                                  checkAfterInsert: checkIAftertInsert());
            }
            catch (DataAccessException ex)
            {
                SetDataAccessValues(ex, ErrorMessageType.AfterInsert);
                throw ex;
            }
        }

        protected void Update(TDomainModel model, Action updatetMethod, DataAccessStatus dataAccessStatus,
                                          Func<bool> checkExist)
        {
            try
            {
                RecordExistsCheck(model, TypeOfExistenceCheck.DoesExistInDB, RequestType.Update,
                                  checkExist: checkExist());
            }
            catch (DataAccessException ex)
            {
                SetDataAccessValues(ex, ErrorMessageType.ModelNotFound);
                throw ex;
            }

            try
            {
                updatetMethod();
            }
            catch (MySqlException ex)
            {
                dataAccessStatus = SetDataAccessValues(ex, ErrorMessageType.Update);
                throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                              dataAccessStatus: dataAccessStatus);
            }
        }

        protected void Delete(TDomainModel model, Action deleteMethod, DataAccessStatus dataAccessStatus,
                                  Func<bool> checkExist)
        {
            try
            {
                RecordExistsCheck(model, TypeOfExistenceCheck.DoesExistInDB, RequestType.Delete,
                                  checkExist: checkExist());
            }
            catch (DataAccessException ex)
            {
                SetDataAccessValues(ex, ErrorMessageType.ModelNotFound);
                throw ex;
            }

            try
            {
                deleteMethod();
            }
            catch (MySqlException ex)
            {
                dataAccessStatus = SetDataAccessValues(ex, ErrorMessageType.Delete);
                throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                              dataAccessStatus: dataAccessStatus);
            }

            try
            {
                RecordExistsCheck(model, TypeOfExistenceCheck.DoesNotExistInDB, RequestType.ConfirmDelete,
                                  checkExist: checkExist());
            }
            catch (DataAccessException ex)
            {
                SetDataAccessValues(ex, ErrorMessageType.FailedDelete);
                throw ex;
            }
        }

        protected IEnumerable<TDomainModel> GetAll(Func<IEnumerable<TDomainModel>> getAllMethod,
                                                   DataAccessStatus dataAccessStatus)
        {
            IEnumerable<TDomainModel> listObj = new List<TDomainModel>();

            try
            {
                listObj = getAllMethod();
            }
            catch (MySqlException ex)
            {
                dataAccessStatus = SetDataAccessValues(ex, ErrorMessageType.GetList);
                throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                              dataAccessStatus: dataAccessStatus);
            }

            return listObj;
        }

        protected TDomainModel GetBy(Func<TDomainModel> getByMethod, DataAccessStatus dataAccessStatus,
                                     Func<bool> checkExist)
        {
            TDomainModel model = default(TDomainModel);

            try
            {
                RecordExistsCheck(model, TypeOfExistenceCheck.DoesExistInDB, RequestType.Delete,
                                  checkExist: checkExist());
            }
            catch (DataAccessException ex)
            {
                SetDataAccessValues(ex, ErrorMessageType.ModelNotFound);
                throw ex;
            }

            try
            {
                model = getByMethod();
            }
            catch (MySqlException ex)
            {
                dataAccessStatus = SetDataAccessValues(ex, ErrorMessageType.GetById);
                throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                              dataAccessStatus: dataAccessStatus);
            }

            if (model == null)
            {
                var ex = new DataAccessException(dataAccessStatus);
                SetDataAccessValues(ex, ErrorMessageType.ModelNotFound);
                throw ex;
            }

            return model;
        }

        protected DataAccessStatus SetDataAccessValues(MySqlException ex, ErrorMessageType errorMessageType)
        {
            var customMessage = "";

            switch (errorMessageType)
            {
                case ErrorMessageType.Insert:
                    customMessage = $"Terjadi kesalahan saat menambahkan data {_modelName}.";
                    break;
                case ErrorMessageType.Update:
                    customMessage = $"Terjadi kesalahan saat menyimpan data {_modelName}.";
                    break;
                case ErrorMessageType.Delete:
                    customMessage = $"Terjadi kesalahan saat menghapus data {_modelName}. " +
                                     "Kemungkinan data sedang digunakan oleh data yang lain.";
                    break;
                case ErrorMessageType.GetList:
                    customMessage = $"Gagal mengambil data list {_modelName}.";
                    break;
                case ErrorMessageType.GetById:
                    customMessage = $"Gagal mengambil data {_modelName} yang sesuai dengan id yang diminta.";
                    break;
                default:
                    customMessage = "Terjadi keslahan saat melakukan operasi yang diminta.";
                    break;
            }

            var dataAccessStatus = new DataAccessStatus();
            dataAccessStatus.SetValues(status: "Error", operationSucceeded: false, exceptionMessage: ex.Message,
                                       customMessage: customMessage,
                                       helpLink: ex.HelpLink, errorCode: ex.ErrorCode, stackTrace: ex.StackTrace);

            return SetDataAccessValues(ex, customMessage);
        }

        protected DataAccessStatus SetDataAccessValues(MySqlException ex, string customMessage)
        {
            var dataAccessStatus = new DataAccessStatus();
            dataAccessStatus.SetValues(status: "Error", operationSucceeded: false, exceptionMessage: ex.Message,
                                       customMessage: customMessage,
                                       helpLink: ex.HelpLink, errorCode: ex.ErrorCode, stackTrace: ex.StackTrace);

            return dataAccessStatus;
        }

        protected void SetDataAccessValues(DataAccessException ex, ErrorMessageType errorMessageType)
        {
            var customMessage = "";

            switch (errorMessageType)
            {
                case ErrorMessageType.AfterInsert:
                    customMessage = $"Gagal menemukan data {_modelName} " +
                                     "di database setelah sukses menambahkan data.";
                    break;
                case ErrorMessageType.ModelNotFound:
                    customMessage = $"{_modelName.FirstToUpper()} tidak dapat diproses, dikarenakan data {_modelName} " +
                                     "yang ingin di proses tidak ditemukan/sudah dihapus.";
                    break;
                case ErrorMessageType.FailedDelete:
                    customMessage = $"Gagal menghapus data {_modelName}. Kemungkinan data sedang digunakan oleh data yang lain";
                    break;
                case ErrorMessageType.QtyEmpty:
                    customMessage = $"Qty {_modelName} yang ingin di proses bernilai 0 (Nol).";
                    break;
                default:
                    customMessage = "Terjadi keslahan saat melakukan operasi yang diminta.";
                    break;
            }

            SetDataAccessValues(ex, customMessage);
        }

        protected void SetDataAccessValues(DataAccessException ex, string customMessage)
        {
            ex.DataAccessStatusInfo.Status = "Error";
            ex.DataAccessStatusInfo.OperationSucceeded = false;
            ex.DataAccessStatusInfo.CustomMessage = customMessage;
            ex.DataAccessStatusInfo.ExceptionMessage = !string.IsNullOrWhiteSpace(ex.Message) ? string.Copy(ex.Message) : "";
            ex.DataAccessStatusInfo.StackTrace = !string.IsNullOrWhiteSpace(ex.StackTrace) ? string.Copy(ex.StackTrace) : "";
        }

        private void RecordExistsCheck(TDomainModel model, TypeOfExistenceCheck typeOfExistenceCheck,
                                       RequestType requestType, bool checkAfterInsert = false,
                                       bool checkExist = false)
        {
            bool exists = false;

            try
            {
                switch (requestType)
                {
                    //case RequestType.Insert:
                    case RequestType.ConfirmInsert:

                        exists = checkAfterInsert;

                        break;
                    case RequestType.Update:
                    case RequestType.Delete:
                    case RequestType.ConfirmDelete:
                    case RequestType.GetById:

                        exists = checkExist;

                        break;
                }
            }
            catch (MySqlException ex)
            {
                var dataAccessStatus = new DataAccessStatus();

                dataAccessStatus = SetDataAccessValues(ex, ErrorMessageType.Delete);
                throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                              dataAccessStatus: dataAccessStatus);
            }

            if ((typeOfExistenceCheck == TypeOfExistenceCheck.DoesExistInDB) && !exists)
            {
                throw new DataAccessException(new DataAccessStatus());
            }
            else if ((typeOfExistenceCheck == TypeOfExistenceCheck.DoesNotExistInDB) && exists)
            {
                throw new DataAccessException(new DataAccessStatus());
            }
        }

        protected bool CheckAfterInsert(DbContext context, string queryStr, object param)
        {
            return context.Conn.ExecuteScalar<bool>(queryStr, param);
        }

        protected bool CheckModelExist(DbContext context, string queryStr, object param)
        {
            return context.Conn.ExecuteScalar<bool>(queryStr, param);
        }
    }
}
