using PrintingApplication.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Role
{
   public interface IRoleView : IDataView
   {
      event EventHandler<SelectionChangedEventArgs> OnListDataGridSelectionChanged;
      event EventHandler OnComboBoxMenuSelectedIndexChanged;
      event EventHandler OnButtonUpdateActionClick;

      ComboBox ComboBoxMenu { get; }
      TreeView TreeViewAction { get; }
   }
}