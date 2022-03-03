using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.GantiPassword;
using PrintingApplication.Infrastructure.DataAccess.Repositories.User;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.GantiPassword;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.User;
using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Presenters.GantiPassword
{
    public class GantiPasswordPresenter : IGantiPasswordPresenter
    {
        private IGantiPasswordView _view;
        private IUserServices _services;

        public IGantiPasswordView GetView
        {
            get { return _view; }
        }

        public GantiPasswordPresenter()
        {
            _view = new GantiPasswordView();
            _services = new UserServices(new UserRepository(), new ModelDataAnnotationCheck());

            _view.OnButtonSimpanClick += _view_OnButtonSimpanClick;
        }

        private void _view_OnButtonSimpanClick(object sender, EventArgs e)
        {
            try
            {
                var model = new GantiPasswordModel
                {
                    login_id = string.Copy(MainProgram.UserActive.login_id),
                    password_sekarang = _view.TextBoxPasswordSekarang.Text,
                    password_baru = _view.TextBoxPasswordBaru.Text,
                    konf_password_baru = _view.TextBoxKonfPasswordBaru.Text
                };

                if (Messages.Confirm("Anda yakin ingin mengganti password?"))
                {
                    _services.GantiPassword(model);
                    Messages.Info("Password berhasil diganti.");
                    ((Form)_view).Close();
                }
            }
            catch (ArgumentException ex)
            {
                Messages.Error(ex);
            }
            catch (DataAccessException ex)
            {
                Messages.Error(ex);
            }
        }
    }
}
