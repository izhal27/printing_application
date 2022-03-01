using Dapper;
using Dapper.Contrib.Extensions;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Services.Services.JenisOrderan;
using System.Collections.Generic;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.JenisOrderan
{
    public class JenisOrderanRepository : BaseRepository<IJenisOrderanModel>, IJenisOrderanRepository
    {
        public JenisOrderanRepository()
        {
            _modelName = "jenis_orderan";
        }

        public void Insert(IJenisOrderanModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                ValidateModel(context, model, dataAccessStatus);

                Insert(model, () => context.Conn.Insert((JenisOrderanModel)model), dataAccessStatus,
                      () => CheckAfterInsert(context, "SELECT COUNT(1) FROM jenis_orderan WHERE kode=@kode "
                                             + "AND id=(SELECT LAST_INSERT_ID())", new { model.kode }));
            }
        }

        public void Update(IJenisOrderanModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                ValidateModel(context, model, dataAccessStatus);

                Update(model, () => context.Conn.Update((JenisOrderanModel)model), dataAccessStatus,
                      () => CheckModelExist(context, model.id));
            }
        }

        public void Delete(IJenisOrderanModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                Delete(model, () => context.Conn.Delete((JenisOrderanModel)model), dataAccessStatus,
                      () => CheckModelExist(context, model.id));
            }
        }

        public IEnumerable<IJenisOrderanModel> GetAll()
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                return GetAll(() =>
                {
                    var listObj = context.Conn.GetAll<JenisOrderanModel>();

                    return listObj;
                }, dataAccessStatus);
            }
        }

        public IJenisOrderanModel GetById(object id)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                return GetBy(() =>
                {
                    var model = context.Conn.Get<JenisOrderanModel>(id);

                    return model;
                }, dataAccessStatus,
                            () => CheckModelExist(context, id));
            }
        }

        private void ValidateModel(DbContext context, IJenisOrderanModel model, DataAccessStatus dataAccessStatus)
        {
            var existsKode = context.Conn.ExecuteScalar<bool>("SELECT COUNT(1) FROM jenis_orderan WHERE kode=@kode AND id!=@id",
                                                               new { model.kode, model.id });

            if (existsKode)
            {
                dataAccessStatus.Status = "Error";
                dataAccessStatus.CustomMessage = StringHelper.DuplicateEntry("kode", _modelName);

                throw new DataAccessException(dataAccessStatus); ;
            }

            var existsNama = context.Conn.ExecuteScalar<bool>("SELECT COUNT(1) FROM jenis_orderan WHERE nama=@nama AND id!=@id",
                                                               new { model.nama, model.id });

            if (existsNama)
            {
                dataAccessStatus.Status = "Error";
                dataAccessStatus.CustomMessage = StringHelper.DuplicateEntry("nama", _modelName);

                throw new DataAccessException(dataAccessStatus); ;
            }
        }

        private bool CheckModelExist(DbContext context, object id)
        {
            return CheckModelExist(context, "SELECT COUNT(1) FROM jenis_orderan WHERE id=@id",
                                   new { id });
        }
    }
}
