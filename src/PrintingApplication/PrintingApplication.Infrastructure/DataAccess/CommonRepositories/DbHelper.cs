using Dapper;
using PrintingApplication.Infrastructure.DataAccess.Repositories;
using System;
using System.Data;
using System.Linq;

namespace PrintingApplication.Infrastructure.DataAccess.CommonRepositories
{
    public static class DbHelper
    {
        /// <summary>
        /// Method untuk mengambil maksimal id dari database
        /// sesuai dengan tanggal sekarang
        /// </summary>
        /// <param name="context">DbContext object</param>
        /// <param name="transaction">Db transaction object</param>
        /// <param name="table">Nama table</param>
        /// <param name="column">Nama column</param>
        /// <returns>Mengembalikan maksimal id sesuai tanggal sekarang
        /// contoh: 19870327000002</returns>
        public static string GetMaxID(DbContext context, IDbTransaction transaction, string table, string column = "id")
        {
            var maxID = default(int);
            var today = default(string);

            today = DateTime.Now.ToString("yyyyMMdd"); // Tanggal sekarang
            var max = context.Conn.Query<string>($"SELECT max({column}) as maxID from {table} " +
                                                 $"WHERE {column} LIKE '{today}%'", transaction).FirstOrDefault();

            // Jika ditemukan maka, ambil 6 digit angka terakhir
            // lalu max id ditambahkan satu,
            // Sebaliknya jika tidak ditemukkan maka buat id baru
            if (max != null)
                maxID = int.Parse(max.Substring(8, 6));
            else
                maxID = 0;

            maxID++;

            return today + maxID.ToString().PadLeft(6, '0');
        }
    }
}
