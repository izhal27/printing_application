using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintingApplication.Domain.Models.OrderanDetail
{
    [Table("orderan_detail")]
    public class OrderanDetailModel : IOrderanDetailModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public uint id { get; set; }

        [Browsable(false)]
        [Required(ErrorMessage = "Order ID harus diisi !!!")]
        public uint orderan_id { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Kode jenis orderan harus diantara 3 sampai 100 karakter !!!")]
        [Display(Name = "Kode Jenis Orderan")]
        public string kode_jenis_orderan { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nama jenis orderan harus diantara 3 sampai 100 karakter !!!")]
        [Display(Name = "Nama Jenis Orderan")]
        public string nama_jenis_orderan { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Harga Satuan")]
        public decimal harga_satuan { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Jumlah")]
        public decimal jumlah { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Diskon")]
        public decimal diskon { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Sub Total")]
        public decimal sub_total
        {
            get { return this.jumlah > 0 && this.harga_satuan > 0 ? (this.jumlah * harga_satuan) - diskon : 0; }
        }
    }
}
