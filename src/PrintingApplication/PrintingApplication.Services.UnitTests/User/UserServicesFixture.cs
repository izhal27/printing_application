using PrintingApplication.Domain.Models.User;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.User;

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
