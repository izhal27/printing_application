using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public partial class ButtonExport : UserControl
    {
        public event EventHandler<ToolStripItemClickedEventArgs> OnButtonExcelClick;
        public event EventHandler<ToolStripItemClickedEventArgs> OnButtonPDFClick;

        public ButtonExport()
        {
            InitializeComponent();
        }

        private void splitButtonExport_DropDowItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.ToLower().Equals("excel"))
            {
                OnButtonExcelClick?.Invoke(sender, e);
            }
            else if (e.ClickedItem.Text.ToLower().Equals("pdf"))
            {
                OnButtonPDFClick?.Invoke(sender, e);
            }
        }
    }
}
