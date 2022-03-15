namespace PrintingApplication.Domain.Models.Laporan
{
    public interface ILabaRugiModel
    {
        decimal total_orderan { get; set; }
        decimal total_pengeluaran { get; set; }
        decimal total_diskon_orderan { get; set; }
        decimal selisih { get; }
    }
}