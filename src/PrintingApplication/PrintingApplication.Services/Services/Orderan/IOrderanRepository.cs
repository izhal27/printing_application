using PrintingApplication.Domain.Models.Oderan;
using RumahScarlett.Domain.Models.Orderan;

namespace PrintingApplication.Services.Services.Orderan
{
    public interface IOrderanRepository : IBaseRepositoryGetByDate<IOrderanModel>, IBaseReportRepositoryByDate<IOrderanReportModel>
    {
        IOrderanModel GetByNoNota(object noNota);
    }
}
