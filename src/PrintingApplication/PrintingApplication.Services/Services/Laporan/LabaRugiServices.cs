using PrintingApplication.Domain.Models.Laporan;

namespace PrintingApplication.Services.Services.Laporan
{
    public class LabaRugiServices : ILabaRugiServices
    {
        private ILabaRugiRepository _repo;

        public LabaRugiServices(ILabaRugiRepository repo)
        {
            _repo = repo;
        }

        public ILabaRugiModel GetByMonthYear(object month, object year)
        {
            return _repo.GetByMonthYear(month, year);
        }
    }
}
