using PrintingApplication.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintingApplication.Domain.Models.GantiPassword;

namespace PrintingApplication.Services.Services.User
{
   public class UserServices : IUserServices
   {
      private IUserRepository _repo;
      private IModelDataAnnotationCheck _moelDAC;

      public UserServices(IUserRepository repo, IModelDataAnnotationCheck modelDAC)
      {
         _repo = repo;
         _moelDAC = modelDAC;
      }

      public void Insert(IUserModel model)
      {
         ValidateModel(model);
         _repo.Insert(model);
      }

      public void Update(IUserModel model)
      {
         ValidateModel(model);
         _repo.Update(model);
      }

      public void Delete(IUserModel model)
      {
         _repo.Delete(model);
      }

      public IEnumerable<IUserModel> GetAll()
      {
         return _repo.GetAll();
      }

      public IUserModel GetById(object id)
      {
         return _repo.GetById(id);
      }
      
      public IUserModel LogIn(string loginID, string password)
      {
         if (string.IsNullOrWhiteSpace(loginID))
         {
            throw new ArgumentException("Login ID harus diisi !!!");
         }
         else if (string.IsNullOrWhiteSpace(password))
         {
            throw new ArgumentException("Password harus diisi !!!");
         }

         return _repo.LogIn(loginID, password);
      }

      public void GantiPassword(IGantiPasswordModel model)
      {
         _moelDAC.ValidateModel(model);
         
         if (!model.password_baru.ToLower().Equals(model.konf_password_baru.ToLower()))
         {
            throw new ArgumentException("Password Baru dan Konfirmasi Password tidak sama !!!");
         }

         _repo.GantiPassword(model);
      }

      public void ValidateModel(IUserModel model)
      {
         _moelDAC.ValidateModel(model);
      }

   }
}
