using ESCPOS_NET;
using ESCPOS_NET.Emitters;
using ESCPOS_NET.Utilities;
using ImageMagick;
using Microsoft.Reporting.WinForms;
using PrintingApplication.Domain.Models.Orderan;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Helper
{
    public static class ReportHelper
    {
        private static IOrderanModel _orderanModel;
        private static SerialPrinter printer = new SerialPrinter(portName: MainProgram.PengaturanModel.nama_printer, baudRate: 115200);

        public static void ShowNotaOrderan(IOrderanModel orderanModel)
        {
            if (MainProgram.PengaturanModel.tipe_printer == TipePrinter.Inkjet)
            {

                var reportDataSources = new List<ReportDataSource>()
              {
                 new ReportDataSource {
                    Name = "DSOrderan",
                    Value = new BindingSource(orderanModel, null)
                 },
                 new ReportDataSource {
                    Name = "DSOrderanDetail",
                    Value = orderanModel.OrderanDetails
                 },
              };

                var parameters = new List<ReportParameter>();

                if (MainProgram.PengaturanModel.tampilkan_pajak)
                {
                    parameters.Add(new ReportParameter("TampilkanPajak", MainProgram.PengaturanModel.tampilkan_pajak.ToString()));
                }

                new ReportView("Nota Orderan", "ReportViewerNotaOrderan",
                               reportDataSources, parameters).ShowDialog();
            }
            else
            {
                if (MainProgram.PengaturanModel.nama_printer != string.Empty)
                {
                    _orderanModel = orderanModel;
                    NotaOrderanPrinterThermal();
                }
                else
                {
                    Messages.Error("Belum ada Printer yang dipilih, silahkan pilih Printer di pengaturan aplikasi.");
                }
            }
        }

        /// <summary>
        /// Method yang digunakkan untuk mencetak nota penjualan ke printer thermal
        /// </summary>
        /// <param name="penjualanModel">Orderan object</param>
        private static void NotaOrderanPrinterThermal()
        {
            try
            {

                var epson = new EPSON();
                MagickImage image = null;
                List<byte[]> data = new List<byte[]>();
                data.Add(epson.CenterAlign());

                if (MainProgram.PengaturanModel.path_logo != default)
                {
                    image = new MagickImage(MainProgram.PengaturanModel.path_logo);
                    image.Extent(370, 150, Gravity.Center);
                    data.Add(epson.PrintImage(image.ToByteArray(), true, true));
                }

                data.Add(epson.SetStyles(PrintStyle.None));
                data.Add(epson.PrintLine(MainProgram.PengaturanModel.nama));
                data.Add(epson.SetStyles(PrintStyle.FontB));

                if (MainProgram.PengaturanModel.alamat_1 != default)
                {
                    data.Add(epson.PrintLine(MainProgram.PengaturanModel.alamat_1));
                }

                if (MainProgram.PengaturanModel.alamat_2 != default)
                {
                    data.Add(epson.PrintLine(MainProgram.PengaturanModel.alamat_2));
                }

                if (MainProgram.PengaturanModel.contact != default)
                {
                    data.Add(epson.SetStyles(PrintStyle.None));
                    data.Add(epson.PrintLine(MainProgram.PengaturanModel.contact));
                }

                data.Add(epson.SetStyles(PrintStyle.FontB));
                data.Add(epson.CenterAlign());
                data.Add(epson.PrintLine("------------------------------------------"));
                data.Add(epson.SetStyles(PrintStyle.None));
                data.Add(epson.PrintLine("NOTA PESANAN"));
                data.Add(epson.LeftAlign());
                data.Add(epson.SetStyles(PrintStyle.FontB));
                data.Add(epson.PrintLine($"{"TANGGAL".PadRight(11)}: {_orderanModel.tanggal.ToString("dd/MM/yyyy")}"));
                data.Add(epson.PrintLine($"{"NO NOTA".PadRight(11)}: {_orderanModel.no_nota}"));
                data.Add(epson.PrintLine($"{"PELANGGAN".PadRight(11)}: {_orderanModel.pelanggan_nama}"));
                data.Add(epson.PrintLine($"{"KETERANGAN".PadRight(11)}: {_orderanModel.keterangan}"));
                data.Add(epson.CenterAlign());
                data.Add(epson.PrintLine("------------------------------------------"));
                data.Add(epson.PrintLine("BARANG YANG DIPESAN"));
                data.Add(epson.PrintLine("------------------------------------------"));

                foreach (var item in _orderanModel.OrderanDetails)
                {
                    data.Add(epson.LeftAlign());
                    var jumlah = item.jumlah.ToString("N0");
                    var harga = item.harga_satuan.ToString("C").PadLeft(15);
                    var subTotal = item.sub_total.ToString("C").PadLeft(15);
                    data.Add(epson.PrintLine((item.nama_jenis_orderan)));
                    data.Add(epson.RightAlign());
                    data.Add(epson.PrintLine($"{jumlah} x {harga} = {subTotal}"));
                }

                data.Add(epson.CenterAlign());
                data.Add(epson.PrintLine("------------------------------------------"));
                data.Add(epson.RightAlign());
                data.Add(epson.PrintLine($"ITEM : {_orderanModel.OrderanDetails.ToList().Count.ToString("N0").PadLeft(15)}"));
                data.Add(epson.PrintLine($"TOTAL ITEM : {_orderanModel.OrderanDetails.ToList().Sum(od => od.jumlah).ToString("N0").PadLeft(15)}"));
                data.Add(epson.SetStyles(PrintStyle.DoubleHeight | PrintStyle.DoubleWidth | PrintStyle.FontB));
                data.Add(epson.PrintLine($"TOTAL : {_orderanModel.OrderanDetails.ToList().Sum(od => od.sub_total).ToString("C").PadLeft(13)}"));
                data.Add(epson.SetStyles(PrintStyle.None | PrintStyle.FontB));
                data.Add(epson.PrintLine($"DISKON : {_orderanModel.total_diskon.ToString("C").PadLeft(15)}"));
                data.Add(epson.PrintLine($"HARUS DIBAYAR : {_orderanModel.total.ToString("C").PadLeft(15)}"));
                data.Add(epson.PrintLine($"DIBAYAR : {_orderanModel.bayar.ToString("C").PadLeft(15)}"));
                data.Add(epson.PrintLine($"KEMBALI : {_orderanModel.kembali.ToString("C").PadLeft(15)}"));
                data.Add(epson.CenterAlign());
                data.Add(epson.PrintLine("------------------------------------------"));

                if (MainProgram.PengaturanModel.tampilkan_pajak)
                {
                    data.Add(epson.LeftAlign());
                    data.Add(epson.PrintLine("* Harga sudah termasuk PPN 11%"));
                    data.Add(epson.FeedLines(1));
                }

                if (MainProgram.PengaturanModel.catatan_kaki != string.Empty)
                {
                    data.Add(epson.CenterAlign());
                    data.Add(epson.PrintLine("**********"));
                    data.Add(epson.PrintLine(MainProgram.PengaturanModel.catatan_kaki));
                    data.Add(epson.CenterAlign());
                    data.Add(epson.PrintLine("------------------------------------------"));
                }

                data.Add(epson.LeftAlign());
                data.Add(epson.PrintLine("PERHATIAN:"));
                data.Add(epson.PrintLine("Pesanan tidak diambil selama lebih dari 2 minggu, bukan tanggung jawab kami."));
                data.Add(ByteSplicer.Combine(epson.FeedLines(2)));
                printer.Write(data.Select(d => ByteSplicer.Combine(d)).ToArray());

                if (image != null)
                {
                    image.Dispose();
                }
            }
            catch (Exception ex)
            {
                Messages.Error(ex);
            }
        }
    }
}
