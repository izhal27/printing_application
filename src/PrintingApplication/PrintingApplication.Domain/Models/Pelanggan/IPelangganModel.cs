namespace PrintingApplication.Domain.Models.Pelanggan
{
    public interface IPelangganModel : IModel
    {
        string nama { get; set; }
        string alamat { get; set; }
        string contact { get; set; }
    }
}
