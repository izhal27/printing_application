using PrintingApplication.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Events;
using System;

namespace PrintingApplication.Presentation.Views
{
    public interface IDataView : IView
    {
        event EventHandler OnLoadData;
        event EventHandler OnButtonTambahClick;
        event EventHandler OnButtonUbahClick;
        event EventHandler OnButtonHapusClick;
        event EventHandler OnButtonRefreshClick;
        event EventHandler OnButtonCetakClick;
        event EventHandler<CellClickEventArgs> OnDataGridCellDoubleClick;

        ListDataGrid ListDataGrid { get; }
    }
}
