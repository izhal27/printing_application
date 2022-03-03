using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public class BaseTextBox : TextBoxExt
    {
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (!ReadOnly)
            {
                BackColor = MainProgram.Pengaturan.warna_baris_genap;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (!ReadOnly)
            {
                BackColor = SystemColors.Window;
            }
        }

        public override string Text
        {
            get
            {
                return base.Text.Trim();
            }

            set
            {
                base.Text = value != null ? value.Trim() : string.Empty;
            }
        }
    }
}
