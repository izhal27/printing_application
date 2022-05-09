namespace PrintingApplication.Domain.Models.OrderanDetail
{
    public interface IOrderanDetailModel : IModel
    {
        uint orderan_id { get; set; }
        string kode_jenis_orderan { get; set; }
        string nama_jenis_orderan { get; set; }
        decimal harga_satuan { get; set; }
        decimal jumlah { get; set; }
        decimal sub_total { get; }
    }
}
