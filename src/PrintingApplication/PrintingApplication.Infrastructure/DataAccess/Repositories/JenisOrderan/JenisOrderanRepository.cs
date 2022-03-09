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
        private readonly DataAccessStatus _dataAccessStatus;

        public JenisOrderanRepository()
        {
            _modelName = "jenis_orderan";
            _dataAccessStatus = new DataAccessStatus();
        }

        public void Insert(IJenisOrderanModel model)
        {
            using (var context = new DbContext())
            {
                ValidateModel(context, model, _dataAccessStatus);

                Insert(model, () => context.Conn.Insert((JenisOrderanModel)model), _dataAccessStatus,
                      () => CheckAfterInsert(context, "SELECT COUNT(1) FROM jenis_orderan WHERE kode=@kode "
                                             + "AND id=(SELECT LAST_INSERT_ID())", new { model.kode }));
            }
        }

        public void Update(IJenisOrderanModel model)
        {
            using (var context = new DbContext())
            {
                ValidateModel(context, model, _dataAccessStatus);

                Update(model, () => context.Conn.Update((JenisOrderanModel)model), _dataAccessStatus,
                      () => CheckModelExist(context, model.id));
            }
        }

        public void Delete(IJenisOrderanModel model)
        {
            using (var context = new DbContext())
            {
                Delete(model, () => context.Conn.Delete((JenisOrderanModel)model), _dataAccessStatus,
                      () => CheckModelExist(context, model.id));
            }
        }

        public IEnumerable<IJenisOrderanModel> GetAll()
        {
            using (var context = new DbContext())
            {
                return GetAll(() =>
                {
                    var listObj = context.Conn.GetAll<JenisOrderanModel>();

                    return listObj;
                }, _dataAccessStatus);
            }
        }

        public IJenisOrderanModel GetById(object id)
        {
            using (var context = new DbContext())
            {
                return GetBy(() =>
                {
                    var model = context.Conn.Get<JenisOrderanModel>(id);

                    return model;
                }, _dataAccessStatus,
                            () => CheckModelExist(context, id));
            }
        }

        private void ValidateModel(DbContext context, IJenisOrderanModel model, DataAccessStatus _dataAccessStatus)
        {
            var existsKode = context.Conn.ExecuteScalar<bool>("SELECT COUNT(1) FROM jenis_orderan WHERE kode=@kode AND id!=@id",
                                                               new { model.kode, model.id });

            if (existsKode)
            {
                _dataAccessStatus.Status = "Error";
                _dataAccessStatus.CustomMessage = StringHelper.DuplicateEntry("kode", _modelName);

                throw new DataAccessException(_dataAccessStatus); ;
            }

            var existsNama = context.Conn.ExecuteScalar<bool>("SELECT COUNT(1) FROM jenis_orderan WHERE nama=@nama AND id!=@id",
                                                               new { model.nama, model.id });

            if (existsNama)
            {
                _dataAccessStatus.Status = "Error";
                _dataAccessStatus.CustomMessage = StringHelper.DuplicateEntry("nama", _modelName);

                throw new DataAccessException(_dataAccessStatus); ;
            }
        }

        private bool CheckModelExist(DbContext context, object id)
        {
            return CheckModelExist(context, "SELECT COUNT(1) FROM jenis_orderan WHERE id=@id",
                                   new { id });
        }
    }
}
