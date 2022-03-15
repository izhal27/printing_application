using Dapper;
using Dapper.Contrib.Extensions;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengeluaran;
using PrintingApplication.Services.Services.JenisOrderan;
using System.Collections.Generic;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Pengeluaran
{
    public class PengeluaranRepository : BaseRepository<IPengeluaranModel>, IPengeluaranRepository
    {
        private readonly DataAccessStatus _dataAccessStatus;

        public PengeluaranRepository()
        {
            _modelName = "pengeluaran";
            _dataAccessStatus = new DataAccessStatus();
        }

        public void Insert(IPengeluaranModel model)
        {
            using (var context = new DbContext())
            {
                context.Conn.Insert((PengeluaranModel)model);
            }
        }

        public void Update(IPengeluaranModel model)
        {
            using (var context = new DbContext())
            {
                context.Conn.Update((PengeluaranModel)model);
            }
        }

        public void Delete(IPengeluaranModel model)
        {
            using (var context = new DbContext())
            {
                Delete(model, () => context.Conn.Delete((PengeluaranModel)model), _dataAccessStatus,
                      () => CheckModelExist(context, model.id));
            }
        }

        public IEnumerable<IPengeluaranModel> GetAll()
        {
            using (var context = new DbContext())
            {
                return GetAll(() =>
                {
                    var listObj = context.Conn.GetAll<PengeluaranModel>();

                    return listObj;
                }, _dataAccessStatus);
            }
        }

        public IPengeluaranModel GetById(object id)
        {
            using (var context = new DbContext())
            {
                return GetBy(() =>
                {
                    var model = context.Conn.Get<PengeluaranModel>(id);

                    return model;
                }, _dataAccessStatus,
                            () => CheckModelExist(context, id));
            }
        }

        public IEnumerable<IPengeluaranModel> GetByDate(object date)
        {
            using (var context = new DbContext())
            {
                return context.Conn.Query<PengeluaranModel>(StringHelper.QueryStringByDate(_modelName), new { date });
            }
        }

        public IEnumerable<IPengeluaranModel> GetByDate(object startDate, object endDate)
        {
            using (var context = new DbContext())
            {
                return context.Conn.Query<PengeluaranModel>(StringHelper.QueryStringByBetweenDate(_modelName), new { startDate, endDate });
            }
        }

        public IEnumerable<IPengeluaranModel> GetReportByDate(object date)
        {
            using (var context = new DbContext())
            {
                var queryStr = QueryStrReport("DATE(p.tanggal) = @date");

                var listObjs = context.Conn.Query<PengeluaranModel>(queryStr, new { date });

                return listObjs;
            }
        }

        public IEnumerable<IPengeluaranModel> GetReportByDate(object startDate, object endDate)
        {
            using (var context = new DbContext())
            {
                var queryStr = QueryStrReport("DATE(p.tanggal) >= @startDate AND DATE(p.tanggal) <= @endDate");

                var listObjs = context.Conn.Query<PengeluaranModel>(queryStr, new { startDate, endDate });

                return listObjs;
            }
        }

        private string QueryStrReport(string where)
        {
            return $"SELECT * FROM pengeluaran p WHERE {where}";
        }

        private bool CheckModelExist(DbContext context, object id)
        {
            return CheckModelExist(context, "SELECT COUNT(1) FROM pengeluaran WHERE id=@id",
                                   new { id });
        }
    }
}
