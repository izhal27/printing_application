using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingApplication.Services.UnitTests.Role
{
   public class FormActionServicesFixture : BaseServicesFixture<IFormActionModel, IFormActionServices>
   {
      public FormActionServicesFixture()
      {
         Model = new FormActionModel();
         Services = new FormActionServices(null, new ModelDataAnnotationCheck());
      }
   }
}
