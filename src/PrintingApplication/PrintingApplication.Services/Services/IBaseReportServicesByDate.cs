using System.Collections.Generic;

namespace PrintingApplication.Services.Services
{
    public interface IBaseReportServicesByDate<TDomainModel> where TDomainModel : class
    {
        IEnumerable<TDomainModel> GetReportByDate(object date);
        IEnumerable<TDomainModel> GetReportByDate(object startDate, object endDate);
    }
}
