using Microsoft.Reporting.WinForms;
using PrintingApplication.Domain.Models.Orderan;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Presentation.Views.CommonControls;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Helper
{
    public static class ReportHelper
    {
        private static IOrderanModel _orderanModel;
        //SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

        public static void ShowNotaOrderan(IOrderanModel orderanModel)
        {
            if (MainProgram.Pengaturan.tipe_printer == TipePrinter.InkjetDotMatrix)
            {

                var reportDataSources = new List<ReportDataSource>()
              {
                 new ReportDataSource {
                    Name = "DataSetOrderan",
                    Value = new BindingSource(orderanModel, null)
                 },
                 new ReportDataSource {
                    Name = "DataSetOrderanDetail",
                    Value = orderanModel.OrderanDetails
                 }
              };

                new ReportView("Nota Orderan", "ReportViewerOrderan",
                               reportDataSources, null).ShowDialog();
            }
            else
            {
                _orderanModel = orderanModel;
                NotaPenjualanPrinterThermal();
            }
        }

        /// <summary>
        /// Method yang digunakkan untuk mencetak nota penjualan ke printer thermal
        /// </summary>
        /// <param name="penjualanModel">Orderan object</param>
        private static void NotaPenjualanPrinterThermal()
        {
            // Inisialisai printDocument object
            PrintDocument printDocument = new PrintDocument();
            printDocument.DocumentName = "Nota Orderan";
            printDocument.PrintPage += printDocument_PrintPage;
            PrinterSettings printerSettings = new PrinterSettings();

            // Jika printer ditemukan cetak nota penjualan,
            // sebaliknya, tampilkan pesan peringatan ke user
            if (printerSettings.IsValid)
            {
                printDocument.PrinterSettings.PrinterName = printerSettings.PrinterName; // Default Printer
                                                                                         //PrintPreview(printDocument);
                printDocument.Print();
            }
            else
            {
                Messages.Warning("Maaf, Tidak ada default printer yang terdeteksi.");
            }
        }

        /// <summary>
        /// Method yang digunakan untuk menggambar garis
        /// </summary>
        /// <param name="graphics">Graphics object</param>
        /// <param name="startX">StartX</param>
        /// <param name="offset">Offset</param>
        /// <param name="endOfLine">Batas akhir dari print</param>
        /// <param name="blackPen">Pen object</param>
        private static void DrawLine(Graphics graphics, int startX, int offset
           , int endOfLine, Pen blackPen)
        {
            // Inisialisai point1 dan point2
            var point1 = new Point(startX, offset);
            var point2 = new Point(endOfLine, offset);

            // Garis
            graphics.DrawLine(blackPen, point1, point2);
        }

        /// <summary>
        /// Method yang digunakan untuk melihat data yang ingin di cetak
        /// </summary>
        /// <param name="printDocument">PrintDocument object</param>
        public static void PrintPreview(PrintDocument printDocument)
        {
            var printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ShowIcon = false;
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.PrintPreviewControl.Zoom = 4;
            ((Form)printPreviewDialog).WindowState = FormWindowState.Maximized;

            printPreviewDialog.ShowDialog();
        }

        private static void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var graphics = e.Graphics;

            var font6 = new Font("Courier New", 6);
            var font8 = new Font("Courier New", 8);
            var font10 = new Font("Courier New", 10);
            var font12 = new Font("Courier New", 12);
            var font14 = new Font("Courier New", 14);

            var formatLeft = new StringFormat();
            formatLeft.Alignment = StringAlignment.Near;
            var formatCenter = new StringFormat();
            formatCenter.Alignment = StringAlignment.Center;
            var formatRight = new StringFormat();
            formatRight.Alignment = StringAlignment.Far;

            var blackPen = new Pen(Brushes.Black, 1F);
            blackPen.DashStyle = DashStyle.Dash;

            int startX = 0;
            int startY = 15; // Jarak dari batas atas area print
            int startCenter = e.PageBounds.Width / 2; // Pertengahan area print
            int endOfLine = 0;
            int offset = 15; // Jarak baris antara huruf

            // -------------------------------- Header --------------------------------------- //

            // Title / nama cafe
            graphics.DrawString(MainProgram.Pengaturan.nama
               , font12.Bold(), Brushes.Black, startCenter, startY, formatCenter);

            // Cek jika alamat_1 tersedia
            if (!string.IsNullOrWhiteSpace(MainProgram.Pengaturan.alamat_1))
            {
                offset += font12.Height;

                // alamat 1
                graphics.DrawString(MainProgram.Pengaturan.alamat_1
                   , font8, Brushes.Black, startCenter, offset, formatCenter);
            }

            // Cek jika alamat_2 tersedia
            if (!string.IsNullOrWhiteSpace(MainProgram.Pengaturan.alamat_2))
            {
                offset += font8.Height;

                // alamat 2
                graphics.DrawString(MainProgram.Pengaturan.alamat_2
                   , font8, Brushes.Black, startCenter, offset, formatCenter);
            }

            // Cek jika telepon tersedia
            if (!string.IsNullOrWhiteSpace(MainProgram.Pengaturan.telpon))
            {
                offset += font8.Height;

                // telepon
                graphics.DrawString(MainProgram.Pengaturan.telpon
                   , font8, Brushes.Black, startCenter, offset, formatCenter);
            }

            // Cek jika kota tersedia
            if (!string.IsNullOrWhiteSpace(MainProgram.Pengaturan.kota))
            {
                offset += font8.Height;

                // kota
                graphics.DrawString(MainProgram.Pengaturan.kota
                   , font8, Brushes.Black, startCenter, offset, formatCenter);
            }

            // -------------------------------- End of Header -------------------------------- //

            offset += font8.Height;

            // Garis
            DrawLine(graphics, startX, offset, endOfLine, blackPen);
            // ------------------------------------------------------------------------------- //

            offset += 2;

            graphics.DrawString($"NOTA ORDERAN", font8.Bold(), Brushes.Black, startX, offset);

            offset += font8.Height;

            // Tanggal
            graphics.DrawString($"{"TANGGAL".PadRight(12)} : "
               + $"{_orderanModel.tanggal.ToString("dd/MM/yyyy HH:mm:ss")}"
               , font8, Brushes.Black, startX, offset);

            offset += font8.Height;

            // No Nota
            graphics.DrawString($"{"NO NOTA".PadRight(12)} : {_orderanModel.no_nota}"
               , font8, Brushes.Black, startX, offset);

            offset += font8.Height;

            // Pelanggan
            graphics.DrawString($"{"PELANGGAN".PadRight(12)} : {_orderanModel.pelanggan_nama}"
               , font8, Brushes.Black, startX, offset);

            offset += font8.Height;

            // Keterangan
            graphics.DrawString($"{"KETERANGAN".PadRight(12)} : {_orderanModel.keterangan}"
               , font8, Brushes.Black, startX, offset);

            offset += font8.Height;

            //// Operator
            //graphics.DrawString($"{"OPERATOR".PadRight(12)} : {MainProgram.OperatorActive.nama}"
            //   , font8, Brushes.Black, startX, offset);

            //offset += font8.Height;

            // Garis
            DrawLine(graphics, startX, offset, endOfLine, blackPen);
            // ------------------------------------------------------------------------------- //

            offset += 2;

            // -------------------------------- List Item ------------------------------------ //

            foreach (var item in _orderanModel.OrderanDetails)
            {
                // Kode Nama
                //------------------------------------------------------------------- //
                graphics.DrawString(item.kode_jenis_orderan + " " + item.nama_jenis_orderan,
                    font8, Brushes.Black, startX, offset);

                offset += font8.Height;

                // Jumlah x Harga - Diskon                   Sub Total
                //------------------------------------------------------------------- //
                var jumlah = item.jumlah.ToString("N0").PadLeft(5);
                var harga = item.harga_satuan.ToString("N0");
                var diskon = item.diskon.ToString("N0");
                graphics.DrawString(jumlah + " x " + harga + " - " + diskon, font8, Brushes.Black
                   , startX, offset);

                var subTotal = item.sub_total.ToString("N0").PadLeft(5);
                graphics.DrawString(subTotal, font8, Brushes.Black
                   , endOfLine, offset, formatRight);

                offset += font8.Height;
            }

            // -------------------------------- End of List Item ----------------------------- //

            // Garis
            DrawLine(graphics, startX, offset, endOfLine, blackPen);
            // ------------------------------------------------------------------------------- //

            offset += 2;

            // Total Item
            graphics.DrawString("TOTAL ITEM", font8, Brushes.Black
              , startX, offset);
            graphics.DrawString(_orderanModel.OrderanDetails.ToList().Count.ToString("N0")
               , font8, Brushes.Black, endOfLine, offset, formatRight);

            offset += font8.Height;

            // Total Jumlah
            graphics.DrawString("JUMLAH", font8, Brushes.Black, startX, offset);
            graphics.DrawString(_orderanModel.OrderanDetails.ToList().Sum(p => p.jumlah).ToString("N0")
               , font8, Brushes.Black, endOfLine, offset, formatRight);

            offset += font8.Height;
            // Sub Total
            graphics.DrawString("SUB TOTAL", font8, Brushes.Black, startX, offset);
            graphics.DrawString(_orderanModel.total.ToString("C")
               , font8, Brushes.Black, endOfLine, offset, formatRight);

            offset += font8.Height;
            // Diskon
            graphics.DrawString("DISKON", font8, Brushes.Black, startX, offset);
            graphics.DrawString(_orderanModel.total_diskon.ToString("C")
               , font8, Brushes.Black, endOfLine, offset, formatRight);

            offset += font8.Height;

            // Garis
            DrawLine(graphics, startX, offset, endOfLine, blackPen);
            // ------------------------------------------------------------------------------- //

            offset += 2;

            // Total
            graphics.DrawString("TOTAL", font12.Bold(), Brushes.Black, startX, offset);
            graphics.DrawString(_orderanModel.total.ToString("C")
               , font12.Bold(), Brushes.Black, endOfLine, offset, formatRight);

            offset += font12.Height;

            // Dibayar
            graphics.DrawString("DIBAYAR", font8, Brushes.Black, startX, offset);
            graphics.DrawString(_orderanModel.bayar.ToString("C")
               , font8, Brushes.Black, endOfLine, offset, formatRight);

            offset += font8.Height;

            // Kembali
            graphics.DrawString("KEMBALI", font8, Brushes.Black, startX, offset);
            graphics.DrawString(_orderanModel.kembali.ToString("C")
               , font8, Brushes.Black, endOfLine, offset, formatRight);

            offset += font8.Height;

            // Garis
            DrawLine(graphics, startX, offset, endOfLine, blackPen);
            // ------------------------------------------------------------------------------- //

            offset += 2;

            graphics.DrawString("TERIMA KASIH", font8
               , Brushes.Black, startCenter, offset, formatCenter);

            offset += font8.Height;

            graphics.DrawString("ATAS KUNJUNGAN ANDA", font8
               , Brushes.Black, startCenter, offset, formatCenter);

            offset += font8.Height;

            // Garis
            DrawLine(graphics, startX, offset, endOfLine, blackPen);
            // ------------------------------------------------------------------------------- //

            offset += 2;

            graphics.DrawString("PERHATIAN:", font6
               , Brushes.Black, startX, offset, formatLeft);

            offset += font6.Height;

            graphics.DrawString("Barang-barang yang sudah dipesan tidak dapat\ndikembalikan/ditukar.", font6
               , Brushes.Black, startX, offset, formatLeft);
        }
    }
}
