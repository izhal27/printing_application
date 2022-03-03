using System;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public class TextBoxTanggal : BaseTextBox
    {
        protected override void OnCreateControl()
        {
            Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }
    }
}
