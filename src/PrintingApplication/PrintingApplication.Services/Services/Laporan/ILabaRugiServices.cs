using PrintingApplication.Domain.Models.Laporan;

namespace PrintingApplication.Services.Services.Laporan
{
    public interface ILabaRugiServices
    {
        ILabaRugiModel GetByMonthYear(object month, object year);
    }
}
