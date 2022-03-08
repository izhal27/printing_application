using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Pengaturan
{
    public partial class PengaturanView : Form, IPengaturanView
    {
        public event EventHandler OnLoadData;
        public event EventHandler OnButtonDefaultClick;
        public event EventHandler OnButtonSaveClick;

        public PengaturanView()
        {
            InitializeComponent();
        }

        private void PengaturanView_Load(object sender, EventArgs e)
        {
            OnLoadData?.Invoke(sender, e);
            ActiveControl = buttonCancel;
        }


        private void buttonDefault_Click(object sender, EventArgs e)
        {
            OnButtonDefaultClick?.Invoke(sender, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            OnButtonSaveClick?.Invoke(sender, e);
        }

        public void ShowView()
        {
            ShowDialog();
        }

        public void CloseView()
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
