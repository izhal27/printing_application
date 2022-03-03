using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public partial class DateTimePickerFilterData : UserControl
    {
        public TampilkanStatus TampilkanStatus { get; private set; }
        public event EventHandler<FilterDateEventArgs> OnTampilkanClick;

        public DateTimePickerFilterData()
        {
            InitializeComponent();

            dateTimePickerPeriodeAwal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            dateTimePickerTanggal.Enabled = false;
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

            if (radioButtonSemua.Checked)
            {
                filterEventArgs.TampilkanStatus = TampilkanStatus.Semua;

                OnTampilkanClick?.Invoke(this, filterEventArgs);
            }
            else if (radioButtonTanggal.Checked)
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

        public void RefreshFilter()
        {
            radioButtonSemua.Checked = true;
            buttonTampilkan_Click(this, null);
        }
    }

    public enum TampilkanStatus
    {
        Semua,
        Tanggal,
        Periode,
    }

    public class FilterDateEventArgs : EventArgs
    {
        public TampilkanStatus TampilkanStatus { get; set; }
        public DateTime Tanggal { get; set; }
        public DateTime TanggalAwal { get; set; }
        public DateTime TanggalAkhir { get; set; }
    }
}
