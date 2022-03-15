using PrintingApplication.Domain.Models.Pengeluaran;

namespace PrintingApplication.Services.Services.JenisOrderan
{
    public interface IPengeluaranRepository : IBaseRepositoryGetByDate<IPengeluaranModel>, IBaseReportRepositoryByDate<IPengeluaranModel>
    {
    }
}
