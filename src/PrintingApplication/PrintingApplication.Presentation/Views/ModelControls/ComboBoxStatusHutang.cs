using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public class ComboBoxStatusHutang : ComboBox
    {
        protected override void OnCreateControl()
        {
            if (Items.Count > 0)
            {
                Items.Clear();
            }

            Items.Add("Belum Lunas");
            Items.Add("Lunas");

            SelectedIndex = 0;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
