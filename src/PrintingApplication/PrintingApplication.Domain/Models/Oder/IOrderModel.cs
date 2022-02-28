using System;

namespace PrintingApplication.Domain.Models.Oder
{
    public interface IOrderModel : IModel
    {
        uint pelanggan_id { get; set; }
        string keterangan { get; set; }
        DateTime tanggal { get; set; }
        decimal sub_total { get; set; }
        decimal total_diskon { get; set; }
        decimal total { get; set; }
        decimal bayar { get; set; }
        decimal kembali { get; set; }
    }
}
