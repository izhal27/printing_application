using Dapper.Contrib.Extensions;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pelanggan;
using PrintingApplication.Services.Services.JenisOrderan;
using System.Collections.Generic;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Pelanggan
{
    public class PelangganRepository : BaseRepository<IPelangganModel>, IPelangganRepository
    {
        private readonly DataAccessStatus _dataAccessStatus;

        public PelangganRepository()
        {
            _modelName = "pelanggan";
            _dataAccessStatus = new DataAccessStatus();
        }

        public void Insert(IPelangganModel model)
        {
            using (var context = new DbContext())
            {
                context.Conn.Insert((PelangganModel)model);
            }
        }

        public void Update(IPelangganModel model)
        {
            using (var context = new DbContext())
            {
                context.Conn.Update((PelangganModel)model);
            }
        }

        public void Delete(IPelangganModel model)
        {
            using (var context = new DbContext())
            {
                Delete(model, () => context.Conn.Delete((PelangganModel)model), _dataAccessStatus,
                      () => CheckModelExist(context, model.id));
            }
        }

        public IEnumerable<IPelangganModel> GetAll()
        {
            using (var context = new DbContext())
            {
                return GetAll(() =>
                {
                    var listObj = context.Conn.GetAll<PelangganModel>();

                    return listObj;
                }, _dataAccessStatus);
            }
        }

        public IPelangganModel GetById(object id)
        {
            using (var context = new DbContext())
            {
                return GetBy(() =>
                {
                    var model = context.Conn.Get<PelangganModel>(id);

                    return model;
                }, _dataAccessStatus,
                            () => CheckModelExist(context, id));
            }
        }

        private bool CheckModelExist(DbContext context, object id)
        {
            return CheckModelExist(context, "SELECT COUNT(1) FROM pelanggan WHERE id=@id",
                                   new { id });
        }
    }
}
