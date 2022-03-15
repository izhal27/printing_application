using System;

namespace PrintingApplication.Domain.Models.Pengeluaran
{
    public interface IPengeluaranModel : IModel
    {
        DateTime tanggal { get; set; }
        string nama { get; set; }
        decimal total { get; set; }
        string keterangan { get; set; }
    }
}
