using PrintingApplication.Domain.Models.JenisOrderan;
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
        [Display(Name = "Kode")]
        public string kode_jenis_orderan { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nama jenis orderan harus diantara 3 sampai 100 karakter !!!")]
        [Display(Name = "Nama")]
        public string nama_jenis_orderan { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        [DefaultValue(0)]
        [Display(Name = "Lebar")]
        public decimal lebar { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        [DefaultValue(0)]
        [Display(Name = "Tinggi")]
        public decimal tinggi { get; set; }

        [Browsable(false)]
        [Display(Name = "Total Dimensi")]        
        public decimal total_dimensi { get; set; }

        [Browsable(false)]
        [DefaultValue(0)]
        [Display(Name = "Harga Satuan")]
        public decimal harga_satuan { get; set; }


        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Harga")]
        public decimal harga
        {
            get
            {
                return unit_satuan == Unit.METER ? total_dimensi * harga_satuan : harga_satuan;
            }
        }
        
        [Browsable(false)]
        [Display(Name = "Unit")]
        [DefaultValue(Unit.PCS)]
        public Unit unit_satuan { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Qty")]
        public decimal jumlah { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Design")]
        public decimal design { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Sub Total")]
        public decimal sub_total
        {
            get
            {
                if (unit_satuan == Unit.METER)
                {
                    if (lebar > 0 && tinggi > 0)
                    {
                        total_dimensi = lebar * tinggi;
                    } else
                    {
                        total_dimensi = 1;
                    }
                } else if (total_dimensi <= 0)
                {
                    total_dimensi = 1;
                }

                decimal totalHargaSatuan = harga_satuan;
                if (id == default(int) && unit_satuan == Unit.METER && total_dimensi > 0)
                {
                    totalHargaSatuan = total_dimensi * harga_satuan;
                } else
                {
                    totalHargaSatuan = total_dimensi * harga_satuan;
                }

                return jumlah > 0 && harga_satuan > 0 ? ((jumlah * totalHargaSatuan) + design) : 0; 
            }
        }
    }
}
