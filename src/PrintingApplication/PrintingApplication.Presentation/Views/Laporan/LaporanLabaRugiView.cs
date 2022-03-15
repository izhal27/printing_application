using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Laporan
{
    public partial class LaporanLabaRugiView : Form, ILaporanLabaRugiView
    {
        public event EventHandler OnLoadData;
        public event EventHandler OnComboBoxBulanSelectedIndexChanged;
        public event EventHandler OnNumericUpDownTahunValueChanged;
        public event EventHandler OnLabelSelisihTextChanged;
        public event EventHandler OnButtonCetakClick;

        public ComboBoxBulan ComboBoxBulan
        {
            get { return comboBoxBulan; }
        }

        public NumericUpDown NumericUpDownTahun
        {
            get { return numericUpDownTahun; }
        }

        public Label LabelOrderan
        {
            get { return labelPenjualan; }
        }

        public Label LabelHpp
        {
            get { return labelHpp; }
        }

        public Label LabelPengeluaran
        {
            get { return labelPengeluaran; }
        }

        public Label LabelDiskonOrderan
        {
            get { return labelDiskonPenjualan; }
        }

        public Label LabelTotalSelisih
        {
            get { return labelTotalSelisih; }
        }

        public LaporanLabaRugiView()
        {
            InitializeComponent();

            panelUp.LabelInfo = Text.ToUpper();
        }

        private void LaporanLabaRugiView_Load(object sender, EventArgs e)
        {
            numericUpDownTahun.Value = DateTime.Now.Year;
            comboBoxBulan.SelectedItem = CultureInfo.CurrentCulture.DateTimeFormat
                                         .MonthNames[DateTime.Now.AddMonths(-1).Month];
            OnLoadData?.Invoke(sender, e);
            ActiveControl = buttonTutup;
        }

        public void ShowView()
        {
            ShowDialog();
        }

        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnComboBoxBulanSelectedIndexChanged?.Invoke(sender, e);
        }

        private void numericUpDownTahun_ValueChanged(object sender, EventArgs e)
        {
            OnNumericUpDownTahunValueChanged?.Invoke(sender, e);
        }

        private void labelTotalSelisih_TextChanged(object sender, EventArgs e)
        {
            OnLabelSelisihTextChanged?.Invoke(sender, e);
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            OnButtonCetakClick?.Invoke(sender, e);
        }
    }
}
