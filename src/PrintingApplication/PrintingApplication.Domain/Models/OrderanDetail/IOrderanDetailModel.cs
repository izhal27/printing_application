using PrintingApplication.Domain.Models.JenisOrderan;

namespace PrintingApplication.Domain.Models.OrderanDetail
{
    public interface IOrderanDetailModel : IModel
    {
        uint orderan_id { get; set; }
        string kode_jenis_orderan { get; set; }
        string nama_jenis_orderan { get; set; }
        decimal lebar { get; set; }
        decimal tinggi { get; set; }
        decimal total_dimensi { get; set; }
        decimal harga_satuan { get; set; }
        Unit unit_satuan { get; set; }
        decimal jumlah { get; set; }
        decimal design { get; set; }
        decimal sub_total { get; }
    }
}
