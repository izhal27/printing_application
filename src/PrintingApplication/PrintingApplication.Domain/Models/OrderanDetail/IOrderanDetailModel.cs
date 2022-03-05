namespace PrintingApplication.Domain.Models.OrderanDetail
{
    public interface IOrderanDetailModel : IModel
    {
        uint order_id { get; set; }
        string jenis_orderan { get; set; }
        decimal harga_satuan { get; set; }
        decimal jumlah { get; set; }
        decimal diskon { get; set; }
        decimal sub_total { get; }
    }
}
