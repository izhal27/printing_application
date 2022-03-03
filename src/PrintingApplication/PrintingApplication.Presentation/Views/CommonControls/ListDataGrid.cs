using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public class ListDataGrid : SfDataGrid
    {
        public ListDataGrid()
        {
            AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            Anchor = AnchorStyles.Top | AnchorStyles.Right |
                     AnchorStyles.Bottom | AnchorStyles.Left;

            DrawCell += ListDataGrid_DrawCell;
            //QueryRowStyle += ListDataGrid_QueryRowStyle;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ShowRowHeader = true;
            AllowEditing = false;
            AllowResizingColumns = true;
        }

        public void SetLastColumnFill(object lastColumnFill)
        {
            if (lastColumnFill is string || lastColumnFill is int)
            {
                var lastColumn = lastColumnFill.ToString();
                AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;

                if (lastColumnFill is string)
                {
                    Columns[lastColumn].AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
                }
                else if (lastColumnFill is int)
                {
                    Columns[int.Parse(lastColumn)].AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
                }
            }
        }

        private void ListDataGrid_DrawCell(object sender, DrawCellEventArgs e)
        {
            if (ShowRowHeader && e != null && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.DisplayText = e.RowIndex.ToString();
                    e.Style.TextColor = Color.Black;
                    e.Style.VerticalAlignment = VerticalAlignment.Center;
                    e.Style.HorizontalAlignment = HorizontalAlignment.Center;
                }
            }
        }

        private void ListDataGrid_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            //if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
            //  e.Style.BackColor = MainProgram.Pengaturan.warna_baris_genap;
            //else
            //  e.Style.BackColor = MainProgram.Pengaturan.warna_baris_ganjil;
        }
    }
}
