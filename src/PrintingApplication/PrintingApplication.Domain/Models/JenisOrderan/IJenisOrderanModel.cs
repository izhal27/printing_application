namespace PrintingApplication.Domain.Models.JenisOrderan
{
   public interface IJenisOrderanModel
   {
      uint id { get; set; }
      string kode { get; set; }
      decimal harga_satuan { get; set; }
      string keterangan { get; set; }
   }
}