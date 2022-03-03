using System.Drawing;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public partial class PanelUp : UserControl
    {
        public string LabelInfo
        {
            get { return labelInfo.Text; }
            set { labelInfo.Text = value.Trim(); }
        }

        public PanelUp()
        {
            InitializeComponent();
            TabStop = false;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            panelInfo.BackColor = MainProgram.Pengaturan != null ?
                                  MainProgram.Pengaturan.warna_backgroud_strip : Color.FromArgb(67, 78, 84);
            labelInfo.ForeColor = MainProgram.Pengaturan != null ?
                                  MainProgram.Pengaturan.warna_teks_strip : Color.FromArgb(240, 240, 240);
        }
    }
}
