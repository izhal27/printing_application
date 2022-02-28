namespace PrintingApplication.Domain.Models.JenisOrderan
{
    public interface IJenisOrderanModel: IModel
    {
        string kode { get; set; }
        decimal harga_satuan { get; set; }
        string keterangan { get; set; }
    }
}