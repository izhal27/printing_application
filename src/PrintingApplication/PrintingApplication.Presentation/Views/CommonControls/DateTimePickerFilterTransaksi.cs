using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public partial class DateTimePickerFilterTransaksi : UserControl
    {
        public TampilkanStatus TampilkanStatus { get; private set; }
        public event EventHandler<FilterDateEventArgs> OnTampilkanClick;

        public DateTimePickerFilterTransaksi()
        {
            InitializeComponent();

            dateTimePickerPeriodeAwal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            dateTimePickerPeriodeAwal.Enabled = false;
            dateTimePickerPeriodeAkhir.Enabled = false;
        }

        private void radioButtonTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerTanggal.Enabled = ((RadioButton)sender).Checked;
        }

        private void radioButtonPeriode_CheckedChanged(object sender, EventArgs e)
        {
            var status = ((RadioButton)sender).Checked;

            dateTimePickerPeriodeAwal.Enabled = status;
            dateTimePickerPeriodeAkhir.Enabled = status;
        }

        private void buttonTampilkan_Click(object sender, EventArgs e)
        {
            var filterEventArgs = new FilterDateEventArgs();

            if (radioButtonTanggal.Checked)
            {
                filterEventArgs.TampilkanStatus = TampilkanStatus.Tanggal;
                filterEventArgs.Tanggal = dateTimePickerTanggal.Value;

                OnTampilkanClick?.Invoke(this, filterEventArgs);
            }
            else if (radioButtonPeriode.Checked)
            {
                filterEventArgs.TampilkanStatus = TampilkanStatus.Periode;
                filterEventArgs.TanggalAwal = dateTimePickerPeriodeAwal.Value;
                filterEventArgs.TanggalAkhir = dateTimePickerPeriodeAkhir.Value;

                OnTampilkanClick?.Invoke(this, filterEventArgs);
            }
        }
    }
}
