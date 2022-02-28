using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintingApplication.Domain.Models.JenisOrderan
{
    [Table("jenis_orderan")]
    public class JenisOrderanModel : IJenisOrderanModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public uint id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Kode jenis orderan harus diisi !!!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Kode jenis orderan harus diantara 3 sampai 100 karakter !!!")]
        [Display(Name = "Kode")]
        public string kode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nama jenis orderan harus diisi !!!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nama jenis orderan harus diantara 3 sampai 100 karakter !!!")]
        [Display(Name = "Nama")]
        public string nama { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Harga Jual")]
        public decimal harga_satuan { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        
        [DefaultValue("")]
        [StringLength(255, ErrorMessage = "Panjang maksimal keterangan 255 karakter !!!")]
        [Display(Name = "Keterangan")]
        public string keterangan { get; set; }

    }
}
