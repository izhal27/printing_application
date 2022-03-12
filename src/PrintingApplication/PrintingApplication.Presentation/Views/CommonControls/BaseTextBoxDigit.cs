using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public class BaseTextBoxDigit : IntegerTextBox
    {
        protected override void OnEnter(EventArgs e)
        {
            if (!ReadOnly)
            {
                //BackColor = MainProgram.Pengaturan.warna_baris_genap;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            if (!ReadOnly)
            {
                BackColor = SystemColors.Window;
            }
        }
    }
}
