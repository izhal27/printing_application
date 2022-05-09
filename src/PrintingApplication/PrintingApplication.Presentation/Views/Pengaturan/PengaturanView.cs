using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Presentation.Helper;
using System;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Pengaturan
{
    public partial class PengaturanView : Form, IPengaturanView
    {
        public event EventHandler OnLoadData;
        public event EventHandler OnButtonSaveClick;

        public IPengaturanModel Model { get; set; }

        public PengaturanView()
        {
            InitializeComponent();
            openFileDialog.Filter = "Jpeg files(*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|All files(*.*) |*.*";
        }

        private void PengaturanView_Load(object sender, EventArgs e)
        {
            OnLoadData?.Invoke(sender, e);
            ActiveControl = buttonCancel;
            textBoxNama.Text = Model.nama;
            textBoxAlamat1.Text = Model.alamat_1;
            textBoxAlamat2.Text = Model.alamat_2;
            textBoxContact.Text = Model.contact;
            textBoxCatatanKaki.Text = Model.catatan_kaki;
            comboBoxTampilkanPajak.SelectedIndex = MainProgram.PengaturanModel.tampilkan_pajak ? 1 : 0;
            pctBoxLogo.ImageLocation = fileExists(Model.path_logo) ? Model.path_logo : null;
            pctBoxBackground.ImageLocation = fileExists(Model.path_background) ? Model.path_background : null;
            rdbInkjet.Checked = Model.tipe_printer == TipePrinter.Inkjet;
            rdbThermal.Checked = Model.tipe_printer == TipePrinter.Thermal;
            var availableCOMPorts = SerialPort.GetPortNames();
            cmbThermal.Items.AddRange(availableCOMPorts);
            if (Model.nama_printer != string.Empty && Model.tipe_printer == TipePrinter.Thermal)
            {
                cmbThermal.SelectedIndex = cmbThermal.FindStringExact(Model.nama_printer);
                SetStatusComboBox();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Model.nama = textBoxNama.Text;
            Model.alamat_1 = textBoxAlamat1.Text;
            Model.alamat_2 = textBoxAlamat2.Text;
            Model.contact = textBoxContact.Text;
            Model.catatan_kaki = textBoxCatatanKaki.Text;
            Model.printer_tipe = rdbInkjet.Checked ? 1 : 2;
            Model.nama_printer = rdbThermal.Checked ? cmbThermal.Text : "";
            Model.tampilkan_pajak = comboBoxTampilkanPajak.SelectedIndex == 1;
            Model.path_logo = pctBoxLogo.Image != null ? pctBoxLogo.ImageLocation : null;
            Model.path_background = pctBoxBackground.Image != null ? pctBoxBackground.ImageLocation : null;

            if (Messages.ConfirmUpdate("Pengaturan"))
            {
                OnButtonSaveClick?.Invoke(this, e);
            }
        }

        public void ShowView()
        {
            ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonPilihLogo_Click(object sender, EventArgs e)
        {
            var image = getImage();

            if (image != default)
            {
                pctBoxLogo.ImageLocation = image;
            }
        }

        private void buttonHapusLogo_Click(object sender, EventArgs e)
        {
            if (pctBoxLogo.Image != null)
            {
                pctBoxLogo.Image = null;
            }
        }

        private void buttnoPilihImageBackground_Click(object sender, EventArgs e)
        {
            var image = getImage();

            if (image != default)
            {
                pctBoxBackground.ImageLocation = image;
            }
        }

        private void buttonHapusBackground_Click(object sender, EventArgs e)
        {
            if (pctBoxBackground.Image != null)
            {
                pctBoxBackground.Image = null;
            }
        }

        private string getImage()
        {
            //Image imageFromFile = null;
            string imageLocation = "";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|" +
                                    "PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //imageFromFile = Image.FromFile(openFileDialog.FileName);
                imageLocation = openFileDialog.FileName;
            }

            //return imageFromFile;
            return imageLocation;
        }

        private bool fileExists(string path)
        {
            return path != default && File.Exists(path);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetStatusComboBox();
        }

        private void SetStatusComboBox()
        {
            cmbThermal.Enabled = rdbThermal.Checked;
        }
    }
}
