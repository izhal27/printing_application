using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Events;

namespace PrintingApplication.Presentation.Views.Role
{
   public partial class RoleView : BaseDataView, IRoleView
   {
      public event EventHandler OnLoadData;
      public event EventHandler<SelectionChangedEventArgs> OnListDataGridSelectionChanged;
      public event EventHandler OnComboBoxMenuSelectedIndexChanged;
      public event EventHandler OnButtonTambahClick;
      public event EventHandler OnButtonUbahClick;
      public event EventHandler OnButtonHapusClick;
      public event EventHandler OnButtonRefreshClick;
      public event EventHandler OnButtonCetakClick;
      public event EventHandler OnButtonUpdateActionClick;
      public event EventHandler<CellClickEventArgs> OnDataGridCellDoubleClick;

      public ListDataGrid ListDataGrid
      {
         get { return listDataGrid; }
      }

      public ComboBox ComboBoxMenu
      {
         get { return comboBoxMenu; }
      }

      public TreeView TreeViewAction
      {
         get { return treeViewAction; }
      }

      public RoleView()
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

      private void RoleView_Load(object sender, EventArgs e)
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

      private void listDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {
         checkBoxPilihSemua.Checked = false;
         OnListDataGridSelectionChanged?.Invoke(sender, e);
      }

      private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
      {
      checkBoxPilihSemua.Checked = false;
      OnComboBoxMenuSelectedIndexChanged?.Invoke(sender, e);
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

      private void checkBoxPilihSemua_CheckedChanged(object sender, EventArgs e)
      {
         CheckedTreeViewNode(((CheckBox)sender).Checked, treeViewAction.Nodes);
      }

      private void CheckedTreeViewNode(bool status, TreeNodeCollection nodes)
      {
         foreach (TreeNode node in nodes)
         {
            node.Checked = status;
            CheckedTreeViewNode(status, node.Nodes);
         }
      }

      private void buttonUpdate_Click(object sender, EventArgs e)
      {
         OnButtonUpdateActionClick?.Invoke(sender, e);
      }
   }
}
