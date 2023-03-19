using PrintingApplication.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Orderan
{
    public partial class LaporanOrderanView : BaseDataView, ILaporanOrderanView
    {
        public event EventHandler OnLoadData;
        public event EventHandler OnDeleteClick;
        public event EventHandler OnPrintClick;
        public event EventHandler OnDetailClick;
        public event EventHandler<FilterDateEventArgs> OnTampilkanClick;
        public event EventHandler<CellClickEventArgs> OnDataGridCellDoubleClick;

        public DateTimePickerFilterTransaksi DateTimePickerFilterTransaksi
        {
            get { return dateTimePickerFilterTransaksi; }
        }

        public ListDataGrid ListDataGrid
        {
            get { return listDataGrid; }
        }

        public LaporanOrderanView()
        {
            InitializeComponent();

            panelUp.LabelInfo = $"{Text.ToUpper()}";

            var buttonCetak = buttonsDeletePrintDetail.ButtonCetak;
            var buttonDetail = buttonsDeletePrintDetail.ButtonDetail;
            var buttonHapus = buttonsDeletePrintDetail.ButtonHapus;

            Dictionary<Button, string> buttons = new Dictionary<Button, string>()
            {
                { buttonCetak, "Cetak Laporan" },
                { buttonDetail, "Detail Orderan" },
                { buttonHapus, "Hapus Orderan" },
            };

            foreach (KeyValuePair<Button, string> button in buttons)
            {
                button.Key.Width = (int)Math.Ceiling(button.Key.Size.Width * 1.5);
                button.Key.Text = button.Value;
            }

            dateTimePickerFilterTransaksi.OnTampilkanClick += DateTimePickerFilterTransaksi_OnTampilkanClick;
            buttonsDeletePrintDetail.OnHapusClick += ButtonsDeletePrintDetail_OnHapusClick;
            buttonsDeletePrintDetail.OnCetakClick += ButtonsDeletePrintDetail_OnCetakClick;
            buttonsDeletePrintDetail.OnDetailClick += ButtonsDeletePrintDetail_OnDetailClick;
            buttonsDeletePrintDetail.OnTutupClick += ButtonsDeletePrintDetail_OnTutupClick;
        }

        private void LaporanPenjualanView_Load(object sender, EventArgs e)
        {
            OnLoadData?.Invoke(sender, e);
            ActiveControl = buttonsDeletePrintDetail.ButtonTutup;
        }

        private void listDataGrid_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            if (buttonsDeletePrintDetail.ButtonDetail.Enabled)
            {
                OnDataGridCellDoubleClick?.Invoke(sender, e);
            }
        }

        private void ButtonsDeletePrintDetail_OnHapusClick(object sender, EventArgs e)
        {
            OnDeleteClick?.Invoke(sender, e);
        }

        private void ButtonsDeletePrintDetail_OnCetakClick(object sender, EventArgs e)
        {
            OnPrintClick?.Invoke(sender, e);
        }

        private void ButtonsDeletePrintDetail_OnDetailClick(object sender, EventArgs e)
        {
            OnDetailClick?.Invoke(sender, e);
        }

        private void DateTimePickerFilterTransaksi_OnTampilkanClick(object sender, FilterDateEventArgs e)
        {
            OnTampilkanClick?.Invoke(sender, e);
        }

        private void ButtonsDeletePrintDetail_OnTutupClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
