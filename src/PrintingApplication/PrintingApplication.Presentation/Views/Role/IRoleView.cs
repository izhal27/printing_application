using Syncfusion.WinForms.DataGrid.Events;
using System;
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