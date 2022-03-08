using PrintingApplication.Domain.Models.OrderanDetail;
using PrintingApplication.Domain.Models.Pelanggan;
using PrintingApplication.Presentation.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Orderan
{
    public partial class BayarOrderanEntryView : Form, IBayarOrderanEntryView
    {
        public event EventHandler<OrderanEventArgs> OnBayarOrderan;

        decimal _uangKembali;

        public BayarOrderanEntryView(List<OrderanDetailModel> listOrderanDetails)
        {
            InitializeComponent();

            panelUp.LabelInfo = Text.ToUpper();

            var orderanDetailsFixed = listOrderanDetails.Where(od => od.kode_jenis_orderan != default && od.nama_jenis_orderan != default).ToList();

            textBoxTotalItem.Text = orderanDetailsFixed.Count.ToString("N0");
            textBoxTotalQty.Text = orderanDetailsFixed.Sum(pd => pd.jumlah).ToString("N0");

            var subTotal = orderanDetailsFixed.Sum(od => od.sub_total);
            textBoxDiskon.MaxValue = long.Parse(subTotal.ToString(), NumberStyles.Number);
            textBoxDiskon.Text = "0";

            var strSubTotal = subTotal.ToString("N0");
            textBoxSubTotal.Text = strSubTotal;
            textBoxGrandTotal.Text = strSubTotal;
            textBoxBayar.Text = strSubTotal;
        }

        private void BayarPenjualanEntryView_Load(object sender, EventArgs e)
        {
            ActiveControl = textBoxBayar;
        }

        private void buttonnBayar_Click(object sender, EventArgs e)
        {
            if (_uangKembali >= 0 && Messages.Confirm("Lanjutkan pembayaran?"))
            {
                var tanggal = dtTanggalOrderan.Value;
                var pelangganModel = comboBoxPelanggan.SelectedItem ?? new PelangganModel();
                var keterangan = textBoxKeterangan.Text;
                var diskon = decimal.Parse(textBoxDiskon.Text, NumberStyles.Number);
                var total = decimal.Parse(textBoxGrandTotal.Text, NumberStyles.Number);
                var jumlahBayar = decimal.Parse(textBoxBayar.Text, NumberStyles.Number);
                var kembali = decimal.Parse(textBoxKembali.Text, NumberStyles.Number);

                var eventArgs = new OrderanEventArgs(tanggal, pelangganModel, keterangan, diskon, total, jumlahBayar, kembali);

                OnBayarOrderan?.Invoke(this, eventArgs);
            }
        }

        private void textBoxDiskon_TextChanged(object sender, EventArgs e)
        {
            var subTotal = decimal.Parse(textBoxSubTotal.Text, NumberStyles.Number);
            var diskon = decimal.Parse(((TextBox)sender).Text, NumberStyles.Number);

            var grandTotal = subTotal - diskon;
            textBoxGrandTotal.Text = grandTotal.ToString("N0");
            textBoxBayar.Text = grandTotal.ToString("N0");
        }

        private void textBoxBayar_TextChanged(object sender, EventArgs e)
        {
            var grandTotal = decimal.Parse(textBoxGrandTotal.Text, NumberStyles.Number);
            var bayar = decimal.Parse(((TextBox)sender).Text, NumberStyles.Number);

            _uangKembali = bayar - grandTotal;
            textBoxKembali.Text = _uangKembali > 0 ? _uangKembali.ToString("N0") : "0";
        }

        private void BayarPenjualanEntryView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:

                    comboBoxPelanggan.Focus();

                    break;
                case Keys.F3:

                    textBoxDiskon.Focus();

                    break;
                case Keys.F4:

                    textBoxBayar.Focus();

                    break;

                case Keys.F5:

                    buttonnBayar_Click(null, null);

                    break;
                case Keys.F12:

                    Close();

                    break;
                case Keys.Enter:

                    if (ActiveControl == comboBoxPelanggan)
                    {
                        textBoxDiskon.Focus();
                    }
                    else if (textBoxDiskon.Focused)
                    {
                        textBoxBayar.Focus();
                    }
                    else if (textBoxBayar.Focused)
                    {
                        buttonBayar.Focus();
                    }

                    break;
                default:

                    break;
            }
        }
    }

    public class OrderanEventArgs : EventArgs
    {
        public DateTime Tanggal { get; }
        public IPelangganModel Pelanggan { get; }
        public string Keterangan { get; }
        public decimal Diskon { get; }
        public decimal GrandTotal { get; }
        public decimal JumlahBayar { get; }
        public decimal Kembali { get; set; }

        public OrderanEventArgs(DateTime tanggal, IPelangganModel pelanggan, string keterangan,
            decimal diskon, decimal grandTotal, decimal jumlahBayar, decimal kembali)
        {
            Tanggal = tanggal;
            Pelanggan = pelanggan;
            Keterangan = keterangan;
            Diskon = diskon;
            GrandTotal = grandTotal;
            JumlahBayar = jumlahBayar;
            Kembali = kembali;
        }
    }
}
