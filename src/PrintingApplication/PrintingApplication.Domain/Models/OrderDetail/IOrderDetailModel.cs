namespace PrintingApplication.Domain.Models.OrderDetail
{
    public interface IOrderDetailModel : IModel
    {
        uint order_id { get; set; }
        string jenis_orderan { get; set; }
        decimal harga_satuan { get; set; }
        decimal jumlah { get; set; }
        decimal diskon { get; set; }
        decimal sub_total { get; set; }
    }
}
