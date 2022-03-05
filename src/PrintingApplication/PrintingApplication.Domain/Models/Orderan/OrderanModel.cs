using PrintingApplication.Domain.Models.OrderanDetail;
using PrintingApplication.Domain.Models.Pelanggan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dp = Dapper.Contrib.Extensions;

namespace PrintingApplication.Domain.Models.Orderan
{
    [Table("orderan")]
    public class OrderanModel : IOrderanModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public uint id { get; set; }

        [Display(Name = "No Nota")]
        public string no_nota { get; set; }

        [Browsable(false)]
        [Dp.Write(false)]
        public IPelangganModel Pelanggan { get; set; }

        private uint _pelanggan_id { get; set; }

        [Browsable(false)]
        [Range(1, uint.MaxValue, ErrorMessage = "Pelanggan harus diisi !!!")]
        [Display(Name = "Pelanggan ID")]
        public uint pelanggan_id
        {
            get { return Pelanggan.id != default ? Pelanggan.id : _pelanggan_id; }
            set { _pelanggan_id = value; }
        }

        [Dp.Write(false)]
        [Display(Name = "Pelanggan")]
        public string pelanggan_nama => Pelanggan.id != default ? Pelanggan.nama : string.Empty;

        [DefaultValue("")]
        [StringLength(255, ErrorMessage = "Panjang maksimal keterangan 255 karakter !!!")]
        [Display(Name = "Keterangan")]
        public string keterangan { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm")]
        [Display(Name = "Tanggal")]
        public DateTime tanggal { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Total Diskon")]
        public decimal total_diskon { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Total")]
        public decimal total { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Bayar")]
        public decimal bayar { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Kembali")]
        public decimal kembali { get; set; }

        [Browsable(false)]
        [Dp.Write(false)]
        public IEnumerable<IOrderanDetailModel> OrderanDetails { get; set; }

        public OrderanModel()
        {
            Pelanggan = new PelangganModel();
            OrderanDetails = new List<OrderanDetailModel>();
        }
    }
}
