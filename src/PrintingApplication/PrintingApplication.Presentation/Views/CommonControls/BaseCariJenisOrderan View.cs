using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public partial class BaseCariJenisOrderanView : Form
    {
        protected event EventHandler OnEnterKeyDown;

        public BaseCariJenisOrderanView()
        {
            InitializeComponent();

            panelUp.LabelInfo = "CARI JENIS ORDERAN";

            listDataGrid.CurrentCellKeyDown += ListDataGrid_CurrentCellKeyDown;
        }

        private void BaseCariBarangView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:

                    listDataGrid.ClearSelection();
                    textBoxPencarian.SelectAll();
                    textBoxPencarian.Focus();

                    break;
                case Keys.Up:

                    if (listDataGrid.SelectedIndex > 0)
                    {
                        --listDataGrid.SelectedIndex;
                    }

                    break;
                case Keys.Down:

                    if (listDataGrid.SelectedIndex < listDataGrid.RowCount - 1)
                    {
                        ++listDataGrid.SelectedIndex;
                    }

                    break;
                case Keys.Enter:

                    OnEnterKeyDown?.Invoke(sender, e);

                    break;
                case Keys.Escape:

                    Close();

                    break;
            }
        }

        private void ListDataGrid_CurrentCellKeyDown(object sender, CurrentCellKeyEventArgs e)
        {
            if (e.KeyEventArgs.KeyCode == Keys.Enter)
            {
                e.KeyEventArgs.Handled = true;
            }
        }

        private void listDataGrid_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            OnEnterKeyDown?.Invoke(sender, e);
        }

        protected virtual void textBoxPencarian_TextChanged(object sender, EventArgs e)
        {

        }

        protected virtual void ShowView()
        {
            ShowDialog();
        }
    }
}
