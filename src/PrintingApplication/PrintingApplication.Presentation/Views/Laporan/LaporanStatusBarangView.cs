using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Laporan
{
    public partial class LaporanStatusBarangView : Form, ILaporanStatusBarangView
    {
        public event EventHandler OnLoadData;
        public event EventHandler OnButtonCetakClick;
        public event EventHandler OnDateTimePickerTanggalValueChanged;

        public DateTimePicker DateTimePickerTanggal
        {
            get { return dateTimePickerTanggal; }
        }

        public Label LabelStokAwal
        {
            get { return labelStokAwal; }
        }

        public Label LabelStokMasuk
        {
            get { return labelStokMasuk; }
        }

        public Label LabelStokTerjual
        {
            get { return labelStokTerjual; }
        }

        public Label LabelPenyesuaianStok
        {
            get { return labelPenyesuaianStok; }
        }

        public Label LabelReturnPenjualan
        {
            get { return labelReturnPenjualan; }
        }

        public Label LabelReturnPembelian
        {
            get { return labelReturnPembelian; }
        }

        public Label LabelStokAkhir
        {
            get { return labelStokAkhir; }
        }

        public LaporanStatusBarangView()
        {
            InitializeComponent();

            panelUp.LabelInfo = Text.ToUpper();
        }

        private void LaporanStatusBarangView_Load(object sender, EventArgs e)
        {
            OnLoadData?.Invoke(sender, e);
            ActiveControl = buttonTutup;
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            OnButtonCetakClick?.Invoke(sender, e);
        }

        private void dateTimePickerTanggal_ValueChanged(object sender, EventArgs e)
        {
            OnDateTimePickerTanggalValueChanged?.Invoke(sender, e);
        }

        public void ShowView()
        {
            ShowDialog();
        }
    }
}
