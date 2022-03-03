using PrintingApplication.Domain.Models.GantiPassword;
using PrintingApplication.Domain.Models.User;

namespace PrintingApplication.Services.Services.User
{
    public interface IUserRepository : IBaseRepository<IUserModel>
    {
        IUserModel LogIn(string loginID, string password);
        void GantiPassword(IGantiPasswordModel model);
    }
}
