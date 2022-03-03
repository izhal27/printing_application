using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Laporan
{
    public partial class LaporanStatusPerBarangView : BaseDataView, ILaporanStatusPerBarangView
    {
        public event EventHandler OnLoadView;
        public event EventHandler OnButtonTampilkanClick;
        public event EventHandler OnButtonCetakClick;

        public ListDataGrid ListDataGrid
        {
            get { return listDataGrid; }
        }

        public RadioButton RadioButtonBulan
        {
            get { return radioButtonBulan; }
        }

        public ComboBoxBulan ComboBoxBulan
        {
            get { return comboBoxBulan; }
        }

        public NumericUpDown NumericUpDownTahun
        {
            get { return numericUpDownTahun; }
        }

        public ComboBoxBulan ComboBoxBulanAwal
        {
            get { return comboBoxBulanAwal; }
        }

        public NumericUpDown NumericUpDownTahunAwal
        {
            get { return numericUpDownTahunAwal; }
        }

        public ComboBoxBulan ComboBoxBulanAkhir
        {
            get { return comboBoxBulanAkhir; }
        }

        public NumericUpDown NumericUpDownTahunAkhir
        {
            get { return numericUpDownTahunAkhir; }
        }

        public Label LabelTotalMasuk
        {
            get { return labelTotalMasuk; }
        }

        public Label LabelTotalKeluar
        {
            get { return labelTotalKeluar; }
        }

        public LaporanStatusPerBarangView()
        {
            InitializeComponent();

            panelUp.LabelInfo = $"{Text.ToUpper()}";
        }

        private void LaporanStatusPerBarang_Load(object sender, EventArgs e)
        {
            var bulanSekarang = CultureInfo.CurrentCulture.DateTimeFormat
                                .MonthNames[DateTime.Now.AddMonths(-1).Month];

            comboBoxBulan.SelectedItem = bulanSekarang;
            comboBoxBulanAkhir.SelectedItem = bulanSekarang;

            OnLoadView?.Invoke(sender, e);
            ActiveControl = buttonTutup;
        }

        private void buttonTampilkan_Click(object sender, EventArgs e)
        {
            OnButtonTampilkanClick?.Invoke(sender, e);
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            OnButtonCetakClick?.Invoke(sender, e);
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
