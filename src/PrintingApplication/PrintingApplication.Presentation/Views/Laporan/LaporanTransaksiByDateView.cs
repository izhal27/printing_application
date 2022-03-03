using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Laporan
{
    public partial class LaporanTransaksiByDateView : Form, ILaporanTransaksiByDateView
    {
        public event EventHandler OnLoadData;
        public event EventHandler OnButtonCetakClick;
        public event EventHandler OnLabelSelisihTextChanged;
        public event EventHandler OnDateTimePickerTanggalValueChanged;

        public DateTimePicker DateTimePickerTanggal
        {
            get { return dateTimePickerTanggal; }
        }

        public Label LabelKasAwal
        {
            get { return labelKasAwal; }
        }

        public Label LabelTotalPenjualan
        {
            get { return labelTotalPenjualan; }
        }

        public Label LabelTotalDiskon
        {
            get { return labelTotalDiskon; }
        }

        public Label LabelTotalPengeluaran
        {
            get { return labelTotalPengeluaran; }
        }

        public Label LabelTotalReturnPenjualan
        {
            get { return labelTotalReturnPenjualan; }
        }

        public Label LabelSelisih
        {
            get { return labelSelisih; }
        }

        public LaporanTransaksiByDateView()
        {
            InitializeComponent();

            panelUp.LabelInfo = Text.ToUpper();
        }

        private void LaporanTransaksiHariIniView_Load(object sender, EventArgs e)
        {
            OnLoadData?.Invoke(sender, e);
            ActiveControl = buttonTutup;
        }

        private void labelSelisih_TextChanged(object sender, EventArgs e)
        {
            OnLabelSelisihTextChanged?.Invoke(sender, e);
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
