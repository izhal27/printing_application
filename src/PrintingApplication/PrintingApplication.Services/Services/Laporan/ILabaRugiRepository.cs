using PrintingApplication.Domain.Models.Laporan;

namespace PrintingApplication.Services.Services.Laporan
{
    public interface ILabaRugiRepository
    {
        ILabaRugiModel GetByMonthYear(object month, object year);
    }
}
