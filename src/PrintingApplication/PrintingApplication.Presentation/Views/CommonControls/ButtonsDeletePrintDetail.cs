using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public partial class ButtonsDeletePrintDetail : UserControl
    {
        public event EventHandler OnHapusClick;
        public event EventHandler OnCetakClick;
        public event EventHandler OnDetailClick;
        public event EventHandler OnTutupClick;

        public Button ButtonHapus
        {
            get { return buttonHapus; }
        }

        public Button ButtonCetak
        {
            get { return buttonCetak; }
        }

        public Button ButtonDetail
        {
            get { return buttonDetail; }
        }

        public Button ButtonTutup
        {
            get { return buttonTutup; }
        }

        public ButtonsDeletePrintDetail()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            OnHapusClick?.Invoke(sender, e);
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            OnCetakClick?.Invoke(sender, e);
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            OnDetailClick?.Invoke(sender, e);
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            OnTutupClick?.Invoke(sender, e);
        }
    }
}
