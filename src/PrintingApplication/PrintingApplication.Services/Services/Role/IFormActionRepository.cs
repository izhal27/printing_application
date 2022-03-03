using PrintingApplication.Domain.Models.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingApplication.Services.Services.Role
{
   public interface IFormActionRepository : IBaseRepository<IFormActionModel>
   {
      IEnumerable<IFormActionModel> GetAllByFormName(string formName);
      IFormActionModel GetByFormName(string formName);
      void DeleteAll();
   }
}
