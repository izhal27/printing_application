using PrintingApplication.Domain.Models.Orderan;

namespace PrintingApplication.Services.Services.Orderan
{
    public interface IOrderanRepository : IBaseRepositoryGetByDate<IOrderanModel>, IBaseReportRepositoryByDate<IOrderanReportModel>
    {
        IOrderanModel GetByNoNota(object noNota);
    }
}
