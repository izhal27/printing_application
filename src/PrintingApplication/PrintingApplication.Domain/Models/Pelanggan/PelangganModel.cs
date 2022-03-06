using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintingApplication.Domain.Models.Pelanggan
{
    [Table("pelanggan")]
    public class PelangganModel : IPelangganModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public uint id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nama pelanggan harus diisi !!!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nama pelanggan harus diantara 3 sampai 100 karakter !!!")]
        [Display(Name = "Nama")]
        public string nama { get; set; }

        [DefaultValue("")]
        [StringLength(255, ErrorMessage = "Panjang maksimal alamat 255 karakter !!!")]
        [Display(Name = "Alamat")]
        public string alamat { get; set; }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Panjang maksimal contact 100 karakter !!!")]
        [Display(Name = "Contact")]
        public string contact { get; set; }

        [DefaultValue("")]
        [StringLength(255, ErrorMessage = "Panjang maksimal keterangan 255 karakter !!!")]
        [Display(Name = "Keterangan")]
        public string keterangan { get; set; }
    }
}
