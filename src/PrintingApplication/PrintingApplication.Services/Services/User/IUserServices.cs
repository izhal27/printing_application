using PrintingApplication.Domain.Models.GantiPassword;
using PrintingApplication.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingApplication.Services.Services.User
{
   public interface IUserServices : IBaseServices<IUserModel>
   {
      IUserModel LogIn(string loginID, string password);
      void GantiPassword(IGantiPasswordModel model);
   }
}
