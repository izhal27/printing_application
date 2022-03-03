using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Role;

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
