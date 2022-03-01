using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PrintingApplication.Domain.Models.Pengeluaran
{
    public class PengeluaranModel : IPengeluaranModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public uint id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nama pengeluaran harus diisi !!!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nama pengeluaran harus diantara 3 sampai 100 karakter !!!")]
        [Display(Name = "Nama")]
        public string nama { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Total")]
        public decimal total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DefaultValue("")]
        [StringLength(255, ErrorMessage = "Panjang maksimal keterangan 255 karakter !!!")]
        [Display(Name = "Keterangan")]
        public string keterangan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
