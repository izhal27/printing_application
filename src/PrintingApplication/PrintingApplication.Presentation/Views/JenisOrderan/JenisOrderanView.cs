using PrintingApplication.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Events;
using System;

namespace PrintingApplication.Presentation.Views.Tipe
{
    public partial class JenisOrderanView : BaseDataView, IJenisOrderanView
    {
        public event EventHandler OnLoadData;
        public event EventHandler OnButtonTambahClick;
        public event EventHandler OnButtonUbahClick;
        public event EventHandler OnButtonHapusClick;
        public event EventHandler OnButtonRefreshClick;
        public event EventHandler OnButtonCetakClick;
        public event EventHandler<CellClickEventArgs> OnDataGridCellDoubleClick;

        public ListDataGrid ListDataGrid
        {
            get { return listDataGrid; }
        }

        public JenisOrderanView()
        {
            InitializeComponent();

            panelUp.LabelInfo = $"DATA {Text.ToUpper()}";
            crudcButtons.ButtonCetak.Visible = false;
            crudcButtons.ButtonCetak.Tag = "ignore";

            listDataGrid.CellDoubleClick += ListDataGrid_CellDoubleClick;
            crudcButtons.OnTambahClick += ButtonsCRUD_OnTambahClick;
            crudcButtons.OnUbahClick += ButtonsCRUD_OnUbahClick;
            crudcButtons.OnHapusClick += ButtonsCRUD_OnHapusClick;
            crudcButtons.OnRefreshClick += ButtonsCRUD_OnRefreshClickEvent;
            crudcButtons.OnTutupClick += ButtonsCRUD_OnTutupClickEvent;
        }

        private void TipeView_Load(object sender, EventArgs e)
        {
            OnLoadData?.Invoke(sender, e);
            ActiveControl = crudcButtons.ButtonTutup;
        }

        private void ListDataGrid_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            if (crudcButtons.ButtonUbah.Enabled)
            {
                OnDataGridCellDoubleClick?.Invoke(sender, e);
            }
        }

        private void ButtonsCRUD_OnTambahClick(object sender, EventArgs e)
        {
            OnButtonTambahClick?.Invoke(sender, e);
        }

        private void ButtonsCRUD_OnUbahClick(object sender, EventArgs e)
        {
            OnButtonUbahClick?.Invoke(sender, e);
        }

        private void ButtonsCRUD_OnHapusClick(object sender, EventArgs e)
        {
            OnButtonHapusClick?.Invoke(sender, e);
        }

        private void ButtonsCRUD_OnRefreshClickEvent(object sender, EventArgs e)
        {
            OnButtonRefreshClick?.Invoke(sender, e);
        }

        private void ButtonsCRUD_OnTutupClickEvent(object sender, EventArgs e)
        {
            Close();
        }
    }
}
