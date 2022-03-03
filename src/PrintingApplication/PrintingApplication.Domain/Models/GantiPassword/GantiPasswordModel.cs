using System.ComponentModel.DataAnnotations;

namespace PrintingApplication.Domain.Models.GantiPassword
{
    public class GantiPasswordModel : IGantiPasswordModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Login ID harus diisi !!!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Login ID harus diantara 5 sampai 50 karakter !!!")]
        [RegularExpression(@"^[\w\d_]+$", ErrorMessage = "Maaf, Hanya karakter Abjad, Huruf dan Underscore yang diijinkan untuk Login ID !!!")]
        public string login_id
        {
            get; set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Sekarang harus diisi !!!")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Password Sekarang minimal 5 karakter !!!")]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "Maaf, Spasi tidak diijinkan untuk Password Sekarang !!!")]
        [Display(Name = "Password")]
        public string password_sekarang
        {
            get; set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Baru harus diisi !!!")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Password Baru minimal 5 karakter !!!")]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "Maaf, Spasi tidak diijinkan untuk Password Baru !!!")]
        public string password_baru
        {
            get; set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Konfirmasi Password harus diisi !!!")]
        public string konf_password_baru
        {
            get; set;
        }
    }
}
