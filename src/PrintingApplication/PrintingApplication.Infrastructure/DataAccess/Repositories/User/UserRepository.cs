using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.GantiPassword;
using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Domain.Models.User;
using PrintingApplication.Services.Services.User;
using System.Collections.Generic;
using System.Linq;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.User
{
    public class UserRepository : BaseRepository<IUserModel>, IUserRepository
    {
        public UserRepository()
        {
            _modelName = "user";
        }

        public void Insert(IUserModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                ValidateModel(context, model, dataAccessStatus);
                model.password = PasswordHash.CreateHash(model.password);

                Insert(model, () => context.Conn.Insert((UserModel)model), dataAccessStatus,
                      () => CheckAfterInsert(context, "SELECT COUNT(1) FROM user WHERE login_id = @login_id "
                                             + "AND id = (SELECT LAST_INSERT_ID())",
                                             new { model.login_id }));
            }
        }

        public void Update(IUserModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                ValidateModel(context, model, dataAccessStatus);

                Update(model, () =>
                {
                    var currentPassword = context.Conn.Get<UserModel>(model.id).password;

                    if (!model.password.Equals(currentPassword))
                    {
                        model.password = PasswordHash.CreateHash(model.password);
                    }

                    context.Conn.Update((UserModel)model);
                }, dataAccessStatus, () => CheckModelExist(context, model.id));
            }
        }

        public void Delete(IUserModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                Delete(model, () => context.Conn.Delete((UserModel)model), dataAccessStatus,
                      () => CheckModelExist(context, model.id));
            }
        }

        public IEnumerable<IUserModel> GetAll()
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                return GetAll(() =>
                {
                    var listObjs = context.Conn.GetAll<UserModel>();

                    if (listObjs != null && listObjs.ToList().Count > 0)
                    {
                        listObjs = listObjs.Map(u =>
                    {
                        var queryStr = "SELECT * FROM role WHERE kode = @kode";
                        var roleModel = context.Conn.Query<RoleModel>(queryStr, new { kode = u.role_kode }).FirstOrDefault();

                        if (roleModel != null)
                        {
                            u.Role = roleModel;
                        }
                    }
                    );
                    }

                    return listObjs;
                }, dataAccessStatus);
            }
        }

        public IUserModel GetById(object id)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                return GetBy(() => context.Conn.Get<UserModel>(id), dataAccessStatus,
                            () => CheckModelExist(context, id));
            }
        }

        public IUserModel LogIn(string loginID, string password)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {
                var errorMessage = "Tidak dapat login ke aplikasi.\nLogin ID atau Password salah !!!";
                var queryStr = "SELECT * FROM user WHERE login_id = @loginID";
                var model = context.Conn.Query<UserModel>(queryStr, new { loginID }).FirstOrDefault();

                if (model != null)
                {
                    if (PasswordHash.ValidatePassword(password, model.password))
                    {
                        errorMessage = string.Empty;
                        return model;
                    }
                }

                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    dataAccessStatus.Status = "Login Error";
                    dataAccessStatus.CustomMessage = errorMessage;

                    throw new DataAccessException(dataAccessStatus);
                }
            }

            return null;
        }

        public void GantiPassword(IGantiPasswordModel model)
        {
            var dataAccessStatus = new DataAccessStatus();

            using (var context = new DbContext())
            {

                try
                {
                    var queryStr = "SELECT * FROM user WHERE login_id = @login_id";
                    var userModel = context.Conn.Query<UserModel>(queryStr, new { model.login_id }).FirstOrDefault();

                    if (userModel != null)
                    {
                        if (!PasswordHash.ValidatePassword(model.password_sekarang, userModel.password))
                        {
                            dataAccessStatus.Status = "Password Wrong";
                            dataAccessStatus.CustomMessage = "Password Sekarang salah !!!";

                            throw new DataAccessException(dataAccessStatus);
                        }

                        userModel.password = PasswordHash.CreateHash(model.password_baru);
                        context.Conn.Update(userModel);
                    }
                    else
                    {
                        dataAccessStatus.Status = "User Not Found";
                        dataAccessStatus.CustomMessage = "User tidak ditemukan.";

                        throw new DataAccessException(dataAccessStatus);
                    }
                }
                catch (MySqlException ex)
                {
                    dataAccessStatus = SetDataAccessValues(ex, ErrorMessageType.Update);
                    throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                                  dataAccessStatus: dataAccessStatus);
                }
            }
        }

        private void ValidateModel(DbContext context, IUserModel model, DataAccessStatus dataAccessStatus)
        {
            var existsNama = context.Conn.ExecuteScalar<bool>("SELECT COUNT(1) FROM user WHERE login_id = @login_id AND id != @id",
                                                                new { model.login_id, model.id });

            if (existsNama)
            {
                dataAccessStatus.Status = "Error";
                dataAccessStatus.CustomMessage = StringHelper.DuplicateEntry("login id", _modelName);

                throw new DataAccessException(dataAccessStatus); ;
            }
        }

        private bool CheckModelExist(DbContext context, object id)
        {
            return CheckModelExist(context, "SELECT COUNT(1) FROM user WHERE id = @id", new { id });
        }
    }
}
