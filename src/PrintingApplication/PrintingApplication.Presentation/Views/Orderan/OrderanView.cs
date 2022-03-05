using PrintingApplication.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Orderan
{
    public partial class OrderanView : BaseDataView, IOrderanView
    {
        public event EventHandler OnLoadData;
        public event EventHandler OnCariData;
        public event EventHandler OnHapusData;
        public event EventHandler OnSimpanData;
        public event EventHandler OnBersihkanData;
        public event EventHandler OnCetakNota;
        public event EventHandler<CurrentCellKeyEventArgs> OnListDataGridCurrentCellKeyDown;
        public event EventHandler<CurrentCellActivatedEventArgs> OnListDataGridCurrentCellActivated;
        public event EventHandler<CurrentCellEndEditEventArgs> OnListDataGridCurrentCellEndEdit;
        public event EventHandler<PreviewKeyDownEventArgs> OnListDataGridPreviewKeyDown;

        public ListDataGrid ListDataGrid
        {
            get { return listDataGrid; }
        }

        public TextBox TextBoxNoNota
        {
            get { return textBoxNoNota; }
        }

        public Label LabelGrandTotal
        {
            get { return panelInfoDigital.LabelInfo; }
        }

        public OrderanView()
        {
            InitializeComponent();

            panelUp.LabelInfo = $"TRANSAKSI {Text.ToUpper()}";

            listDataGrid.EditMode = EditMode.SingleClick;
            listDataGrid.AllowSorting = false;

            listDataGrid.CurrentCellActivated += ListDataGrid_CurrentCellActivated;
            listDataGrid.CurrentCellEndEdit += ListDataGrid_CurrentCellEndEdit;
            listDataGrid.PreviewKeyDown += ListDataGrid_PreviewKeyDown;
            listDataGrid.CurrentCellKeyDown += ListDataGrid_CurrentCellKeyDown;
        }

        private void PenjualanView_Load(object sender, EventArgs e)
        {
            OnLoadData?.Invoke(sender, e);
        }

        private void PenjualanView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2: // Cari

                    OnCariData?.Invoke(sender, e);

                    break;
                case Keys.F3: // Hapus

                    OnHapusData?.Invoke(sender, e);

                    break;
                case Keys.F4: // Bayar

                    OnSimpanData?.Invoke(sender, e);

                    break;
                case Keys.F5: // Bersihkan

                    OnBersihkanData?.Invoke(sender, e);

                    break;
                case Keys.F6: // Cetak Nota

                    OnCetakNota?.Invoke(sender, e);

                    break;
                case Keys.F12: // Tutup

                    if (!listDataGrid.CurrentCell.IsEditing)
                    {
                        Close();
                    }

                    break;
            }
        }

        private void ListDataGrid_CurrentCellKeyDown(object sender, CurrentCellKeyEventArgs e)
        {
            OnListDataGridCurrentCellKeyDown?.Invoke(sender, e);
        }

        private void ListDataGrid_CurrentCellActivated(object sender, CurrentCellActivatedEventArgs e)
        {
            OnListDataGridCurrentCellActivated?.Invoke(sender, e);
        }

        private void ListDataGrid_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            OnListDataGridCurrentCellEndEdit?.Invoke(sender, e);
        }

        private void ListDataGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            OnListDataGridPreviewKeyDown?.Invoke(sender, e);
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            OnCariData?.Invoke(sender, e);
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            OnHapusData?.Invoke(sender, e);
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            OnSimpanData?.Invoke(sender, e);
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            OnBersihkanData?.Invoke(sender, e);
        }

        private void buttonCetakNota_Click(object sender, EventArgs e)
        {
            OnCetakNota?.Invoke(sender, e);
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
