using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Services.Services.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Role
{
   public class FormActionRepository : BaseRepository<IFormActionModel>, IFormActionRepository
   {
      public FormActionRepository()
      {
         _modelName = "form action";
      }

      public void Insert(IFormActionModel model)
      {
         var dataAccessStatus = new DataAccessStatus();

         try
         {
            using (var context = new DbContext())
            {
               ValidateModel(context, model, dataAccessStatus);

               context.Conn.Insert((FormActionModel)model);
            }
         }
         catch (MySqlException ex)
         {
            dataAccessStatus = SetDataAccessValues(ex, ErrorMessageType.Insert);
            throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                          dataAccessStatus: dataAccessStatus);
         }
      }

      public void Update(IFormActionModel model)
      {
         throw new NotImplementedException();
      }
      public void Delete(IFormActionModel model)
      {
         throw new NotImplementedException();
      }

      public void DeleteAll()
      {
         var dataAccessStatus = new DataAccessStatus();

         try
         {
            using (var context = new DbContext())
            {
               context.Conn.DeleteAll<FormActionModel>();
            }
         }
         catch (MySqlException ex)
         {
            dataAccessStatus = SetDataAccessValues(ex, ErrorMessageType.Insert);
            throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                          dataAccessStatus: dataAccessStatus);
         }
      }

      public IEnumerable<IFormActionModel> GetAll()
      {
         var dataAccessStatus = new DataAccessStatus();

         using (var context = new DbContext())
         {
            return GetAll(() => context.Conn.GetAll<FormActionModel>(), dataAccessStatus);
         }
      }

      public IEnumerable<IFormActionModel> GetAllByFormName(string formName)
      {
         var dataAccessStatus = new DataAccessStatus();

         using (var context = new DbContext())
         {
            return GetAll(() =>
            {
               var queryStr = "SELECT * FROM form_action WHERE form_name = @formName";
               return context.Conn.Query<FormActionModel>(queryStr, new { formName });
            }, dataAccessStatus);
         }
      }

      public IFormActionModel GetById(object id)
      {
         throw new NotImplementedException();
      }

      public IFormActionModel GetByFormName(string formName)
      {
         var dataAccessStatus = new DataAccessStatus();

         using (var context = new DbContext())
         {
            return GetBy(() =>
            {
               var queryStr = "SELECT * FROM form_action WHERE form_name = @formName";
               return context.Conn.Query<FormActionModel>(queryStr, new { formName }).FirstOrDefault();
            }, dataAccessStatus, () => CheckModelExist(context, formName));
         }
      }

      private void ValidateModel(DbContext context, IFormActionModel model, DataAccessStatus dataAccessStatus)
      {
         var existsNama = context.Conn.ExecuteScalar<bool>("SELECT COUNT(1) FROM form_action WHERE form_name = @form_name",
                                                             new { model.form_name });

         if (existsNama)
         {
            dataAccessStatus.Status = "Error";
            dataAccessStatus.CustomMessage = StringHelper.DuplicateEntry("form name", _modelName);

            throw new DataAccessException(dataAccessStatus); ;
         }
      }

      private bool CheckModelExist(DbContext context, string formName)
      {
         return CheckModelExist(context, "SELECT COUNT(1) FROM form_action WHERE form_name = @formName",
                                                  new { formName });
      }
   }
}
