using PrintingApplication.Domain.Models.User;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingApplication.Services.UnitTests.User
{
   public class UserServicesFixture : BaseServicesFixture<IUserModel, IUserServices>
   {
      public UserServicesFixture()
      {
         Model = new UserModel();
         Services = new UserServices(null, new ModelDataAnnotationCheck());
      }
   }
}
