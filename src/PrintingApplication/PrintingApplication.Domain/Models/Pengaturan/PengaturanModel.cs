using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PrintingApplication.Domain.Models.Pengaturan
{
    public class PengaturanModel : IPengaturanModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nama harus diisi !!!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Nama harus diantara 5 sampai 50 karakter !!!")]
        [Category("Data Toko")]
        [Description("Isi Nama toko disini.")]
        [DisplayName("Nama")]
        public string nama { get; set; }

        [StringLength(50, ErrorMessage = "Alamat 1 maksimal 50 karakter !!!")]
        [Category("Data Toko")]
        [Description("Isi Alamat 1 toko disini.")]
        [DisplayName("Alamat 1")]
        public string alamat_1 { get; set; }

        [StringLength(50, ErrorMessage = "Alamat 2 maksimal 50 karakter !!!")]
        [Category("Data Toko")]
        [Description("Isi Alamat 2 toko disini.")]
        [DisplayName("Alamat 2")]
        public string alamat_2 { get; set; }

        [StringLength(50, ErrorMessage = "Telpon maksimal 50 karakter !!!")]
        [Category("Data Toko")]
        [Description("Isi Telpon toko disini.")]
        [DisplayName("Telpon")]
        public string telpon { get; set; }

        [StringLength(50, ErrorMessage = "Kota/Kabupaten maksimal 50 karakter !!!")]
        [Category("Data Toko")]
        [Description("Isi Kota/Kabupaten toko disini.")]
        [DisplayName("Kota/Kabupaten")]
        public string kota { get; set; }

        [Category("Style")]
        [Description("Pilih Warna background strip pada form.")]
        [DisplayName("Warna Background Strip")]
        public Color warna_backgroud_strip { get; set; }

        [Category("Style")]
        [Description("Pilih Warna teks strip pada form.")]
        [DisplayName("Warna Teks Strip")]
        public Color warna_teks_strip { get; set; }

        [Category("Style")]
        [Description("Pilih Warna baris genap pada data grid view (digunakan juga pada background kotak inputan).")]
        [DisplayName("Warna Baris Genap")]
        public Color warna_baris_genap { get; set; }

        [Category("Style")]
        [Description("Pilih Warna baris ganjil pada data grid view.")]
        [DisplayName("Warna Baris Ganjil")]
        public Color warna_baris_ganjil { get; set; }

        [Category("Style")]
        [Description("Pilih Theme untuk Dockpanel.")]
        [DisplayName("Dockpanel Theme")]
        public DockPanelTheme dockpanel_theme { get; set; }

        [Editor(typeof(FileNameImagesEditor), typeof(UITypeEditor))]
        [Category("Background")]
        [Description("Pilih gambar untuk ditampilkan pada main form.")]
        [DisplayName("Gambar Main Form")]
        public string path_background { get; set; }

        [Category("Printer")]
        [Description("Pilih Tipe Printer yang digunakan.")]
        [DisplayName("Printer")]
        public TipePrinter tipe_printer { get; set; }

        [Category("View")]
        [Description("Tampilkan Tool Strip aplikasi.")]
        [DisplayName("Show Tool Strip")]
        public bool show_tool_strip { get; set; }

        [Category("View")]
        [Description("Tampilkan Status Strip aplikasi.")]
        [DisplayName("Show Status Strip")]
        public bool show_status_strip { get; set; }
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
