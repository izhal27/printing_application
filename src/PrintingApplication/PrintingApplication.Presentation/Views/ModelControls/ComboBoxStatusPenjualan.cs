using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public class ComboBoxStatusPenjualan : ComboBox
    {
        protected override void OnCreateControl()
        {
            if (Items.Count > 0)
            {
                Items.Clear();
            }

            Items.Add("Transfer");
            Items.Add("Cash");

            SelectedIndex = 1;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
