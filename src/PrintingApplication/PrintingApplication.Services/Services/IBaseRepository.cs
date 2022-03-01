using System.Collections.Generic;

namespace PrintingApplication.Services.Services
{
    /// <summary>
    /// Base of model repository
    /// </summary>
    /// <typeparam name="TDomainModel">Type of domain model</typeparam>
    public interface IBaseRepository<TDomainModel> where TDomainModel : class
    {
        void Insert(TDomainModel model);
        void Update(TDomainModel model);
        void Delete(TDomainModel model);
        IEnumerable<TDomainModel> GetAll();
        TDomainModel GetById(object id);
    }
}
