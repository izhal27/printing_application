using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Dp = Dapper.Contrib.Extensions;

namespace PrintingApplication.Domain.Models.Pengaturan
{
    [Table("Pengaturan")]
    public class PengaturanModel : IPengaturanModel
    {
        public uint id { get; set; }

        public string nama { get; set; }

        public string alamat_1 { get; set; }

        public string alamat_2 { get; set; }

        public string contact { get; set; }

        public int printer_tipe { get; set; }

        public string path_logo { get; set; }

        public string path_background { get; set; }

        public string catatan_kaki { get; set; }

        [Dp.Write(false)]
        public TipePrinter tipe_printer
        {
            get
            {
                return (TipePrinter)printer_tipe;
            }
        }

    }

    public class FileNameImagesEditor : FileNameEditor
    {
        protected override void InitializeDialog(OpenFileDialog openFileDialog)
        {
            base.InitializeDialog(openFileDialog);
            openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|" +
                                    "PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
        }
    }
}
