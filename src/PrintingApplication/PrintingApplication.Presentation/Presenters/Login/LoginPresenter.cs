using PrintingApplication.CommonComponents;
using PrintingApplication.Infrastructure.DataAccess.Repositories;
using PrintingApplication.Infrastructure.DataAccess.Repositories.User;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.Login;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.User;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Presenters.Login
{
    public class LoginPresenter : ILoginPresenter
    {
        private ILoginView _view;
        private IUserServices _services;
        private string _server;
        private string _port;
        private string _database;
        private string _user;
        private string _passwordDatabase;

        public ILoginView GetView
        {
            get { return _view; }
        }

        private string Server
        {
            get { return _view.TextBoxServer.Text; }
            set { _view.TextBoxServer.Text = value; }
        }

        private string Port
        {
            get { return _view.TextBoxPort.Text; }
            set { _view.TextBoxPort.Text = value; }
        }

        private string Database
        {
            get { return _view.TextBoxDatabase.Text; }
            set { _view.TextBoxDatabase.Text = value; }
        }

        private string User
        {
            get { return _view.TextBoxUser.Text; }
            set { _view.TextBoxUser.Text = value; }
        }

        private string PasswordDatabase
        {
            get { return _view.TextBoxPasswordDatabase.Text; }
            set { _view.TextBoxPasswordDatabase.Text = value; }
        }

        public LoginPresenter()
        {
            _view = new LoginView();
            _services = new UserServices(new UserRepository(), new ModelDataAnnotationCheck());

            _view.OnLoadView += _view_OnLoadView;
            _view.OnButtonLoginClick += _view_OnButtonLoginClick;
            _view.OnButtonSimpanClick += _view_OnButtonSimpanClick;
            _view.OnButtonTesKoneksiClick += _view_OnButtonTesKoneksiClick;
        }

        private void _view_OnLoadView(object sender, EventArgs e)
        {
            LoadConfigDatabase();

            Server = !string.IsNullOrEmpty(_server) ? _server : "localhost";
            Port = !string.IsNullOrEmpty(_port) ? _port : "3306";
            Database = !string.IsNullOrEmpty(_database) ? _database : string.Empty;
            User = !string.IsNullOrEmpty(_user) ? _user : "root";
            PasswordDatabase = !string.IsNullOrEmpty(_passwordDatabase) ? _passwordDatabase : string.Empty;
        }

        private void _view_OnButtonLoginClick(object sender, EventArgs e)
        {
            try
            {
                if (!CekKoneksiDatabase())
                {
                    if (_view.TabControlLogin.SelectedTab != _view.TabPageDatabase)
                    {
                        _view.TabControlLogin.SelectedTab = _view.TabPageDatabase;
                    }

                    return;
                }

                var model = _services.LogIn(_view.TextBoxLoginID.Text, _view.TextBoxPassword.Text);

                if (model != null)
                {
                    MainProgram.UserActive = model;

                    ((Form)_view).Hide(); // Sembunyikan Form login
                    ((Form)new MainPresenter().GetView).ShowDialog(); // Tampilkan From main
                }
            }
            catch (ArgumentException ex)
            {
                Messages.Error(ex);
            }
            catch (DataAccessException ex)
            {
                Messages.Error(ex);
                _view.TextBoxLoginID.Clear();
                _view.TextBoxPassword.Clear();
                _view.TextBoxLoginID.Focus();
            }
        }

        private void _view_OnButtonTesKoneksiClick(object sender, EventArgs e)
        {
            if (!ValidasiData())
            {
                return;
            }

            if (CekKoneksiDatabase())
            {
                Messages.Info("Tes Koneksi ke Database berhasil.");
                SimpanDataKoneksi();
            }
            else
            {
                Messages.Warning("Terjadi kesalahan saat menghubungkan ke Database.\n" +
                                 "Periksa kembali data koneksi Database anda.");
            }
        }

        private void _view_OnButtonSimpanClick(object sender, EventArgs e)
        {
            if (ValidasiData())
            {
                SimpanDataKoneksi();
            }
        }

        private bool CekKoneksiDatabase()
        {
            if (ValidasiData())
            {
                var context = new DbContext(Server, Port, Database, User, PasswordDatabase);
                if (context.TesKoneksi())
                {
                    return true;
                }
            }

            return false;
        }


        private void SimpanDataKoneksi()
        {
            if (Messages.Confirm("Simpan data koneksi Database anda?"))
            {
                ConfigHelper.SaveConfig("Server", Server);
                ConfigHelper.SaveConfig("Port", Port);
                ConfigHelper.SaveConfig("Database", Database);
                ConfigHelper.SaveConfig("User", User);
                ConfigHelper.SaveConfig("Password", PasswordDatabase);

                Messages.Info("Data koneksi berhasil disimpan.");
            }
        }

        private bool ValidasiData()
        {
            var serverStatus = !string.IsNullOrWhiteSpace(Server); // true jika tidak kosong
            var portStatus = !string.IsNullOrWhiteSpace(Port); // true jika tidak kosong
            var databaseStatus = !string.IsNullOrWhiteSpace(Database); // true jika tidak kosong
            var userStatus = !string.IsNullOrWhiteSpace(User); // true jika tidak kosong

            if (!serverStatus || !portStatus || !databaseStatus || !userStatus)
            {
                Messages.Warning("Server, Port, Database dan User harus diisi !!!");
                return false;
            }

            return true;
        }

        private void LoadConfigDatabase()
        {
            _server = ConfigurationManager.AppSettings["Server"] ?? "";
            _port = ConfigurationManager.AppSettings["Port"] ?? "";
            _database = ConfigurationManager.AppSettings["Database"] ?? "";
            _user = ConfigurationManager.AppSettings["User"] ?? "";
            _passwordDatabase = ConfigurationManager.AppSettings["Password"] ?? "";
        }
    }
}
