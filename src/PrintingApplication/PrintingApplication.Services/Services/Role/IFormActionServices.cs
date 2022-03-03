using PrintingApplication.Domain.Models.Role;
using System.Collections.Generic;

namespace PrintingApplication.Services.Services.Role
{
    public interface IFormActionServices : IBaseServices<IFormActionModel>
    {
        IEnumerable<IFormActionModel> GetAllByFormName(string formName);
        IFormActionModel GetByFormName(string formName);
        void DeleteAll();
    }
}
