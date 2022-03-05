using PrintingApplication.Domain.Models.OrderanDetail;
using PrintingApplication.Domain.Models.Pelanggan;
using System;
using System.Collections.Generic;

namespace PrintingApplication.Domain.Models.Orderan
{
    public interface IOrderanModel : IModel
    {
        string no_nota { get; set; }
        uint pelanggan_id { get; set; }
        IPelangganModel Pelanggan { get; }
        string pelanggan_nama { get; }
        string keterangan { get; set; }
        DateTime tanggal { get; set; }
        decimal total_diskon { get; set; }
        decimal total { get; set; }
        decimal bayar { get; set; }
        decimal kembali { get; set; }
        IEnumerable<IOrderanDetailModel> OrderanDetails { get; set; }
    }
}
