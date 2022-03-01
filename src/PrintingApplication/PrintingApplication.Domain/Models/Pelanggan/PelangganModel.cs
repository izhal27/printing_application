using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PrintingApplication.Domain.Models.Pelanggan
{
    public class PelangganModel : IPelangganModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public uint id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nama pelanggan harus diisi !!!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nama pelanggan harus diantara 3 sampai 100 karakter !!!")]
        [Display(Name = "Nama")]
        public string nama { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DefaultValue("")]
        [StringLength(255, ErrorMessage = "Panjang maksimal alamat 255 karakter !!!")]
        [Display(Name = "Alamat")]
        public string alamat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DefaultValue("")]
        [StringLength(100, ErrorMessage = "Panjang maksimal contact 100 karakter !!!")]
        [Display(Name = "Contact")]
        public string contact { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
