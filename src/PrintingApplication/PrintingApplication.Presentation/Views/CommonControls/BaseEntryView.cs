using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public partial class BaseEntryView : Form
    {
        public BaseEntryView()
        {
            InitializeComponent();

            operationButtons.OnCloseButtonClick += OperationButtons_OnCloseButtonClick;
            ActiveControl = operationButtons.ButtonCancel;
        }

        protected virtual void BaseEntryView_Load(object sender, EventArgs e)
        {

        }

        protected virtual void BaseEntryView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        protected virtual void OperationButtons_OnCloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
