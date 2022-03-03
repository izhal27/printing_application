using PrintingApplication.Domain.Models.Role;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dp = Dapper.Contrib.Extensions;

namespace PrintingApplication.Domain.Models.User
{
    [Table("user")]
    public class UserModel : IUserModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public uint id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Login ID harus diisi !!!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Login ID harus diantara 5 sampai 50 karakter !!!")]
        [RegularExpression(@"^[\w\d_]+$", ErrorMessage = "Maaf, Hanya karakter Abjad, Huruf dan Underscore yang diijinkan untuk Login ID !!!")]
        [Display(Name = "Login ID")]
        public string login_id { get; set; }

        [Browsable(false)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password harus diisi !!!")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Password minimal 5 karakter !!!")]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "Maaf, Spasi tidak diijinkan untuk Password !!!")]
        [Display(Name = "Password")]
        public string password { get; set; }

        private string _role_kode;

        [Browsable(false)]
        [Display(Name = "Kode Role")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Role harus diisi !!!")]
        public string role_kode
        {
            get { return Role.id != default(uint) ? Role.kode : _role_kode; }
            set { _role_kode = value; }
        }

        private string _role_nama;

        [Dp.Write(false)]
        [Display(Name = "Role")]
        public string role_nama
        {
            get { return Role.id != default(uint) ? Role.nama : _role_nama; }
            set { _role_nama = value; }
        }

        [Browsable(false)]
        [Dp.Write(false)]
        public IRoleModel Role { get; set; }

        public UserModel()
        {
            Role = new RoleModel();
        }
    }
}
