using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PrintingApplication.Domain.Models.OrderDetail
{
    public class OrderDetailModel : IOrderDetailModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public uint id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Browsable(false)]
        [Range(1, uint.MaxValue, ErrorMessage = "Order ID harus diisi !!!")]
        public uint order_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nama jenis orderan harus diantara 3 sampai 100 karakter !!!")]
        [Display(Name = "Jenis Orderan")]
        public string jenis_orderan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Harga Satuan")]
        public decimal harga_satuan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Jumlah")]
        public decimal jumlah { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Diskon")]
        public decimal diskon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Sub Total")]
        public decimal sub_total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
