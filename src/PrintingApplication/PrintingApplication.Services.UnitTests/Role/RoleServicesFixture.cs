using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Role;

namespace PrintingApplication.Services.UnitTests.Role
{
    public class RoleServicesFixture : BaseServicesFixture<IRoleModel, IRoleServices>
    {
        public RoleServicesFixture()
        {
            Model = new RoleModel();
            Services = new RoleServices(null, new ModelDataAnnotationCheck());
        }
    }
}
