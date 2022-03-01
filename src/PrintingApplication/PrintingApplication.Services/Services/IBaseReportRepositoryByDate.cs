using System.Collections.Generic;

namespace PrintingApplication.Services.Services
{
    public interface IBaseReportRepositoryByDate<TDomainModel> where TDomainModel : class
    {
        IEnumerable<TDomainModel> GetReportByDate(object date);
        IEnumerable<TDomainModel> GetReportByDate(object startDate, object endDate);
    }
}
