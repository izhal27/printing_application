﻿using Dapper;
using Dapper.Contrib.Extensions;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Oderan;
using PrintingApplication.Domain.Models.Pelanggan;
using PrintingApplication.Infrastructure.DataAccess.CommonRepositories;
using PrintingApplication.Services.Services.Orderan;
using RumahScarlett.Domain.Models.Orderan;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Orderan
{
    public class OrderanRepository : BaseRepository<IOrderanModel>, IOrderanRepository
    {
        public OrderanRepository()
        {
            _modelName = "orderan";
        }

        public void Insert(IOrderanModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                context.BeginTransaction();

                model.no_nota = DbHelper.GetMaxID(context, context.Transaction, "orderan", "no_nota");
                model.tanggal = DateTime.Now;

                Insert(model, () =>
                {
                    var queryStr = "INSERT INTO orderan (no_nota, keterangan, pelanggan_id, tanggal, total_diskon, total, bayar, kembali) " +
                               "VALUES (@no_nota, @keterangan, @pelanggan_id, @tanggal, @total_diskon, @total, @bayar, @bayar);" +
                               "SELECT LAST_INSERT_ID();";

                    object pelanggan_id = DBNull.Value;

                    if (model.pelanggan_id != default)
                    {
                        pelanggan_id = model.pelanggan_id;
                    }

                    var insertedId = context.Conn.Query<uint>(queryStr, new
                    {
                        model.no_nota,
                        model.keterangan,
                        pelanggan_id,
                        model.tanggal,
                        model.total_diskon,
                        model.total,
                        model.bayar,
                        model.kembali,
                    }, context.Transaction).Single();

                    if (insertedId > 0 && model.OrderanDetails.ToList().Count > 0)
                    {
                        model.id = insertedId;
                        model.OrderanDetails = model.OrderanDetails.Map(p => p.order_id = model.id).ToList();
                    }
                }, dataAccessStatus,
                () => CheckAfterInsert(context, "SELECT COUNT(1) FROM orderan WHERE no_nota=@no_nota "
                                       + "AND id=(SELECT id FROM orderan ORDER BY ID DESC LIMIT 1)",
                                       new { model.no_nota }));
            }
        }

        public void Update(IOrderanModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(IOrderanModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                context.BeginTransaction();

                Delete(model, () =>
                {
                    model.OrderanDetails = new OrderanDetailRepository(context).GetAll(model, context.Transaction);

                    var success = context.Conn.Delete(model, context.Transaction);

                    if (success)
                    {
                        context.Commit();
                    }
                }, dataAccessStatus, () => CheckModelExist(context, model.id));
            }
        }

        public IEnumerable<IOrderanModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IOrderanModel> GetByDate(object date)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                var listObjs = context.Conn.Query<OrderanModel>(StringHelper.QueryStringByDate(_modelName), new { date });

                listObjs = MappingObjects(context, listObjs);

                return listObjs;
            }
        }

        public IEnumerable<IOrderanModel> GetByDate(object startDate, object endDate)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                var listObjs = context.Conn.Query<OrderanModel>(StringHelper.QueryStringByBetweenDate(_modelName), new { startDate, endDate });

                listObjs = MappingObjects(context, listObjs);

                return listObjs;
            }
        }

        private IEnumerable<OrderanModel> MappingObjects(DbContext context, IEnumerable<OrderanModel> listObj)
        {
            if (listObj != null && listObj.ToList().Count > 0)
            {
                listObj = listObj.Map(p =>
                {
                    if (p.pelanggan_id != default(uint))
                    {
                        p.Pelanggan = context.Conn.Get<PelangganModel>(p.pelanggan_id);
                    }
                });

                var pdRepo = new OrderanDetailRepository(context);

                foreach (var p in listObj)
                {
                    p.OrderanDetails = pdRepo.GetAll(p);
                }
            }

            return listObj;
        }

        public IOrderanModel GetById(object id)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                return GetBy(() => context.Conn.Get<OrderanModel>(id), dataAccessStatus,
                            () => CheckModelExist(context, id));
            }
        }

        public IOrderanModel GetByNoNota(object noNota)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                var queryStr = "SELECT * FROM orderan WHERE no_nota = @noNota";

                var model = context.Conn.Query<OrderanModel>(queryStr, new { noNota }).FirstOrDefault();

                if (model != null)
                {
                    if (model.pelanggan_id != default(uint))
                    {
                        var pelangganModel = context.Conn.Get<PelangganModel>(model.pelanggan_id);

                        if (pelangganModel != null)
                        {
                            model.Pelanggan = pelangganModel;
                        }
                    }

                    var pdRepo = new OrderanDetailRepository(context);

                    model.OrderanDetails = pdRepo.GetAll(model);
                }
                return model;
            }
        }

        public IEnumerable<IOrderanReportModel> GetReportByDate(object date)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                var queryStr = QueryStrReport("DATE(o.tanggal) = @date");

                var listObjs = context.Conn.Query<OrderanReportModel>(queryStr, new { date });

                return listObjs;
            }
        }

        public IEnumerable<IOrderanReportModel> GetReportByDate(object startDate, object endDate)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                var queryStr = QueryStrReport("DATE(o.tanggal) >= @startDate AND DATE(o.tanggal) <= @endDate");

                var listObjs = context.Conn.Query<OrderanReportModel>(queryStr, new { startDate, endDate });

                return listObjs;
            }
        }

        private string QueryStrReport(string where)
        {
            return "SELECT o.tanggal, o.no_nota, IFNULL(pl.nama, '') AS pelanggan_nama, " +
                   "od.kode_jenis_orderan, od.nama_jenis_orderan, od.harga_satuan, od.jumlah, od.diskon, od.sub_total, " +
                   "o.total_diskon, o.total, o.bayar, o.kembali FROM orderan o " +
                   "LEFT JOIN pelanggan pl ON o.pelanggan_id = pl.id " +
                  $"INNER JOIN orderan_detail od ON o.id = od.order_id WHERE ${where}";
        }

        private bool CheckModelExist(DbContext context, object id)
        {
            return CheckModelExist(context, "SELECT COUNT(1) FROM orderan WHERE id=@id",
                                   new { id });
        }
    }
}