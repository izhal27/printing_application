namespace PrintingApplication.Domain.Models.Laporan
{
    public class LabaRugiModel : ILabaRugiModel
    {
        public decimal total_orderan { get; set; }
        public decimal total_pengeluaran { get; set; }
        public decimal total_diskon_orderan { get; set; }
        public decimal selisih { get; set; }
    }
}
