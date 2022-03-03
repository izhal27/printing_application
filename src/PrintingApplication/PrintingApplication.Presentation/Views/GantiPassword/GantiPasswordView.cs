using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.GantiPassword
{
    public partial class GantiPasswordView : BaseEntryView, IGantiPasswordView
    {
        public event EventHandler OnButtonSimpanClick;

        public BaseTextBox TextBoxPasswordSekarang
        {
            get { return textBoxPasswordSekarang; }
        }

        public BaseTextBox TextBoxPasswordBaru
        {
            get { return textBoxPasswordBaru; }
        }

        public BaseTextBox TextBoxKonfPasswordBaru
        {
            get { return textBoxKonfPasswordBaru; }
        }

        public GantiPasswordView()
        {
            InitializeComponent();

            panelUp.LabelInfo = $"{Text.ToUpper()}";

            operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
        }

        private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
        {
            OnButtonSimpanClick?.Invoke(sender, e);
        }

        private void checkBoxShowCharacters_CheckedChanged(object sender, EventArgs e)
        {
            // Tampilkan karakter di TextBox password jika CheckBox tampilkan dicentang,
            // sebaliknya sembunyikan karakter dengan password char
            var status = ((CheckBox)sender).Checked;

            textBoxPasswordSekarang.UseSystemPasswordChar = !status;
            textBoxPasswordBaru.UseSystemPasswordChar = !status;
            textBoxKonfPasswordBaru.UseSystemPasswordChar = !status;
        }

        private void textBox_ImeModeChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).PasswordChar = '\0'; // Disable/show password char
        }

        public void ShowView()
        {
            ShowDialog();
        }

        private void GantiPasswordView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OnButtonSimpanClick?.Invoke(sender, e);
            }
        }
    }
}
