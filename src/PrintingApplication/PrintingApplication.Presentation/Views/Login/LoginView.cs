using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Login
{
    public partial class LoginView : Form, ILoginView
    {
        public event EventHandler OnLoadView;
        public event EventHandler OnButtonLoginClick;
        public event EventHandler OnButtonTesKoneksiClick;
        public event EventHandler OnButtonSimpanClick;

        public TabControl TabControlLogin
        {
            get { return tabControlLogin; }
        }

        public TabPage TabPageLogin
        {
            get { return tabPageLogin; }
        }

        public TabPage TabPageDatabase
        {
            get { return tabPageDatabase; }
        }

        public BaseTextBox TextBoxLoginID
        {
            get { return textBoxLoginID; }
        }

        public BaseTextBox TextBoxPassword
        {
            get { return textBoxPassword; }
        }

        public BaseTextBox TextBoxServer
        {
            get { return textBoxServer; }
        }

        public BaseTextBox TextBoxDatabase
        {
            get { return textBoxDatabase; }
        }

        public BaseTextBox TextBoxPort
        {
            get { return textBoxPort; }
        }

        public BaseTextBox TextBoxUser
        {
            get { return textBoxUser; }
        }

        public BaseTextBox TextBoxPasswordDatabase
        {
            get { return textBoxPasswordDatabase; }
        }

        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            OnLoadView?.Invoke(sender, e);
            ActiveControl = textBoxLoginID;
        }

        private void LoginView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tabControlLogin.SelectedTab == tabPageLogin)
                {
                    OnButtonLoginClick?.Invoke(buttonLogin, new EventArgs());
                }
            }
        }

        private void LoginView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chkBoxShowCharacters_CheckedChanged(object sender, EventArgs e)
        {
            // Tampilkan karakter di TextBox password jika CheckBox tampilkan dicentang,
            // sebaliknya sembunyikan karakter dengan password char
            var status = ((CheckBox)sender).Checked;

            textBoxPassword.UseSystemPasswordChar = !status;
        }

        private void textBoxPassword_ImeModeChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).PasswordChar = '\0'; // Disable password char
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OnButtonLoginClick?.Invoke(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            OnButtonSimpanClick?.Invoke(sender, e);
        }

        private void buttonTesKoneksi_Click(object sender, EventArgs e)
        {
            OnButtonTesKoneksiClick?.Invoke(sender, e);
        }
    }
}
