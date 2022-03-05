using Dapper;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Oderan;
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
            var queryStr = "INSERT INTO order_detail (order_id, kode_jenis_orderan, nama_jenis_orderan, harga_satuan, jumlah, diskon, sub_total) " +
                           "VALUES (@order_id, @kode_jenis_orderan, @nama_jenis_orderan, @harga_satuan, @jumlah, @diskon, @sub_total)";

            _context.Conn.Query<int>(queryStr, new
            {
                order_id = model.order_id,
                barang_id = model.kode_jenis_orderan,
                nama_jenis_orderan = model.nama_jenis_orderan,
                harga_satuan = model.harga_satuan,
                jumlah = model.jumlah,
                diskon = model.diskon,
                sub_total = model.sub_total
            }, transaction);
        }

        public IEnumerable<IOrderanDetailModel> GetAll(IOrderanModel orderan, IDbTransaction transaction = null)
        {
            var dataAccessStatus = new DataAccessStatus();

            var queryStr = "SELECT * FROM order_detail WHERE order_id=@id";

            var listorderDetails = _context.Conn.Query<OrderanDetailModel>(queryStr, new { id = orderan.id }, transaction);

            return listorderDetails;
        }
    }
}
