using PrintingApplication.Domain.Models.Pelanggan;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Dp = Dapper.Contrib.Extensions;

namespace PrintingApplication.Domain.Models.Oder
{
    public class OrderModel : IOrderModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public uint id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Browsable(false)]
        [Dp.Write(false)]
        public IPelangganModel Pelanggan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private uint _pelanggan_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
        public string keterangan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm")]
        [Display(Name = "Tanggal")]
        public DateTime tanggal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Sub Total")]
        public decimal sub_total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Total Diskon")]
        public decimal total_diskon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Total")]
        public decimal total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Bayar")]
        public decimal bayar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Kembali")]
        public decimal kembali { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public OrderModel()
        {
            Pelanggan = new PelangganModel();
        }
    }
}
