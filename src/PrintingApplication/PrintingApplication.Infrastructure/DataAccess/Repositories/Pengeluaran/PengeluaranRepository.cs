using Dapper.Contrib.Extensions;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengeluaran;
using PrintingApplication.Services.Services.JenisOrderan;
using System.Collections.Generic;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Pengeluaran
{
    public class PengeluaranRepository : BaseRepository<IPengeluaranModel>, IPengeluaranRepository
    {
        public PengeluaranRepository()
        {
            _modelName = "pengeluaran";
        }

        public void Insert(IPengeluaranModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                context.Conn.Insert((PengeluaranModel)model);
            }
        }

        public void Update(IPengeluaranModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                context.Conn.Update((PengeluaranModel)model);
            }
        }

        public void Delete(IPengeluaranModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                Delete(model, () => context.Conn.Delete((PengeluaranModel)model), dataAccessStatus,
                      () => CheckModelExist(context, model.id));
            }
        }

        public IEnumerable<IPengeluaranModel> GetAll()
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                return GetAll(() =>
                {
                    var listObj = context.Conn.GetAll<PengeluaranModel>();

                    return listObj;
                }, dataAccessStatus);
            }
        }

        public IPengeluaranModel GetById(object id)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                return GetBy(() =>
                {
                    var model = context.Conn.Get<PengeluaranModel>(id);

                    return model;
                }, dataAccessStatus,
                            () => CheckModelExist(context, id));
            }
        }

        private bool CheckModelExist(DbContext context, object id)
        {
            return CheckModelExist(context, "SELECT COUNT(1) FROM pengeluaran WHERE id=@id",
                                   new { id });
        }
    }
}
