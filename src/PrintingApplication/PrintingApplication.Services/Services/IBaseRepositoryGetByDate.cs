using System.Collections.Generic;

namespace PrintingApplication.Services.Services
{
    public interface IBaseRepositoryGetByDate<TDomainModel> : IBaseRepository<TDomainModel> where TDomainModel : class
    {
        IEnumerable<TDomainModel> GetByDate(object date);
        IEnumerable<TDomainModel> GetByDate(object startDate, object endDate);
    }
}
