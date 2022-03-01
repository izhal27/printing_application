namespace PrintingApplication.Domain.Models.Pengeluaran
{
    public interface IPengeluaranModel : IModel
    {
        string nama { get; set; }
        decimal total { get; set; }
        string keterangan { get; set; }
    }
}
