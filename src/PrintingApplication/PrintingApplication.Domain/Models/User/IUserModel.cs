using PrintingApplication.Domain.Models.Role;

namespace PrintingApplication.Domain.Models.User
{
    public interface IUserModel
    {
        uint id { get; set; }
        string login_id { get; set; }
        string password { get; set; }
        string role_kode { get; set; }
        string role_nama { get; }
        IRoleModel Role { get; set; }
    }
}
