using Dapper;
using PrintingApplication.Domain.Models.Orderan;
using PrintingApplication.Domain.Models.OrderanDetail;
using System.Collections.Generic;
using System.Data;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Orderan
{
    internal interface IOrderanDetailRepository
    {
        void Insert(IOrderanDetailModel model, IDbTransaction transaction);
        IEnumerable<IOrderanDetailModel> GetAll(IOrderanModel orderan, IDbTransaction transaction = null);
    }

    internal class OrderanDetailRepository : BaseRepository<IOrderanDetailModel>, IOrderanDetailRepository
    {
        private DbContext _context;

        public OrderanDetailRepository(DbContext context)
        {
            _context = context;
        }

        public void Insert(IOrderanDetailModel model, IDbTransaction transaction)
        {
            var queryStr = "INSERT INTO orderan_detail (orderan_id, kode_jenis_orderan, nama_jenis_orderan, harga_satuan, jumlah) " +
                           "VALUES (@orderan_id, @kode_jenis_orderan, @nama_jenis_orderan, @harga_satuan, @jumlah)";

            _context.Conn.Query<int>(queryStr, new
            {
                model.orderan_id,
                model.kode_jenis_orderan,
                model.nama_jenis_orderan,
                model.harga_satuan,
                model.jumlah,
                model.sub_total
            }, transaction);
        }

        public IEnumerable<IOrderanDetailModel> GetAll(IOrderanModel orderan, IDbTransaction transaction = null)
        {
            var queryStr = "SELECT * FROM orderan_detail WHERE orderan_id=@id";

            var listorderDetails = _context.Conn.Query<OrderanDetailModel>(queryStr, new { id = orderan.id }, transaction);

            return listorderDetails;
        }
    }
}
