using Dapper;
using PrintingApplication.Domain.Models.Laporan;
using PrintingApplication.Services.Services.Laporan;
using System.Linq;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Laporan
{
    public class LabaRugiRepository : ILabaRugiRepository
    {
        public ILabaRugiModel GetByMonthYear(object month, object year)
        {
            using (var context = new DbContext())
            {
                var queryStr = "SELECT IFNULL((SELECT SUM(((od.jumlah * od.harga_satuan) - od.diskon)) FROM orderan o " +
                               "INNER JOIN orderan_detail od ON o.id = od.orderan_id " +
                               "WHERE MONTH(o.tanggal)=@MONTH AND YEAR(o.tanggal) = @year), 0) AS total_orderan, " +
                               "IFNULL((SELECT SUM(p.total) FROM pengeluaran p WHERE MONTH(p.tanggal) = @MONTH AND " +
                               "YEAR(p.tanggal) = @year), 0) AS total_pengeluaran, " +
                               "IFNULL((SELECT SUM(o.total_diskon) FROM orderan o WHERE MONTH(o.tanggal) = @MONTH AND " +
                               "YEAR(o.tanggal) = @year), 0) AS total_diskon_orderan";

                var model = context.Conn.Query<LabaRugiModel>(queryStr, new { month, year }).FirstOrDefault();

                return model;
            }
        }
    }
}
