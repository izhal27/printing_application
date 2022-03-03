using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Domain.Models.User;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.User
{
    public partial class UserEntryView : BaseEntryView, IUserEntryView
    {
        private bool _isNewData;
        private IUserModel _model;
        public event EventHandler OnSaveData;
        private static string _typeName = "User";

        public UserEntryView(bool isNewData = true, IUserModel model = null)
        {
            InitializeComponent();
            _isNewData = isNewData;
            panelUp.LabelInfo = isNewData ? $"TAMBAH {_typeName.ToUpper()}" : $"UBAH {_typeName.ToUpper()}";

            if (!_isNewData)
            {
                _model = model;
            }

            operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
        }

        private void UserEntryView_Load(object sender, EventArgs e)
        {
            if (!_isNewData)
            {
                buttonShowPassword.Enabled = false;

                SetWatermarkTextBoxPassword();

                textBoxLoginID.Text = _model.login_id;
                comboBoxRole.SelectedItem = new RoleModel { id = _model.id, kode = _model.role_kode };
            }
            else
            {
                buttonShowPassword.Enabled = true;
            }
        }

        private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
        {
            var model = new UserModel
            {
                login_id = textBoxLoginID.Text,
                Role = comboBoxRole.SelectedItem != null ? comboBoxRole.SelectedItem : new RoleModel(),
                password = textBoxPassword.ForeColor != Color.Gray ? textBoxPassword.Text : _model.password
            };

            var modelArgs = new ModelEventArgs<UserModel>(model);

            if (_isNewData)
            {
                if (Messages.ConfirmSave(_typeName))
                {
                    OnSaveData?.Invoke(this, modelArgs);
                }
            }
            else if (Messages.ConfirmUpdate(_typeName))
            {
                model.id = _model.id;
                OnSaveData?.Invoke(this, modelArgs);
            }
        }

        private void buttonShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void buttonShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void textBoxPassword_ImeModeChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).PasswordChar = '\0';
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (!_isNewData)
            {
                if (textBoxPassword.ForeColor == Color.Gray)
                {
                    textBoxPassword.Clear();
                    textBoxPassword.UseSystemPasswordChar = true;
                    buttonShowPassword.Enabled = true;
                    textBoxPassword.ForeColor = textBoxLoginID.ForeColor;
                }
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (!_isNewData)
            {
                if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    SetWatermarkTextBoxPassword();
                }
            }
        }

        private void SetWatermarkTextBoxPassword()
        {
            textBoxPassword.UseSystemPasswordChar = false;
            buttonShowPassword.Enabled = false;
            textBoxPassword.Text = "Tidak Berubah";
            textBoxPassword.ForeColor = Color.Gray;
        }
    }
}
