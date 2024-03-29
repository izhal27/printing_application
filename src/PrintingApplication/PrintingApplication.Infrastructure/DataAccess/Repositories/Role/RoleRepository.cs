﻿using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Services.Services.Role;
using System.Collections.Generic;
using System.Linq;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Role
{
    public class RoleRepository : BaseRepository<IRoleModel>, IRoleRepository
    {
        private DataAccessStatus _dataAccessStatus;

        public RoleRepository()
        {
            _modelName = "role";
            _dataAccessStatus = new DataAccessStatus();
        }

        public void Insert(IRoleModel model)
        {
            using (var context = new DbContext())
            {
                ValidateModel(context, model, _dataAccessStatus);

                Insert(model, () => context.Conn.Insert((RoleModel)model), _dataAccessStatus,
                      () => CheckAfterInsert(context, "SELECT COUNT(1) FROM role WHERE kode = @kode "
                                             + "AND id=(SELECT LAST_INSERT_ID())",
                                             new { model.kode }));
            }
        }

        public void Update(IRoleModel model)
        {
            using (var context = new DbContext())
            {
                ValidateModel(context, model, _dataAccessStatus);

                Update(model, () => context.Conn.Update((RoleModel)model), _dataAccessStatus,
                      () => CheckModelExist(context, model.id));
            }
        }

        public void Delete(IRoleModel model)
        {
            using (var context = new DbContext())
            {
                Delete(model, () =>
                {
                    var queryStr = "SELECT COUNT(1) FROM user WHERE role_kode = @kode";
                    var found = context.Conn.ExecuteScalar<bool>(queryStr, new { model.kode });

                    if (found)
                    {
                        _dataAccessStatus.Status = "Error";
                        _dataAccessStatus.CustomMessage = StringHelper.ErrorDeleteForeignKey(_modelName);

                        throw new DataAccessException(_dataAccessStatus);
                    }

                    context.Conn.Delete((RoleModel)model);
                }, _dataAccessStatus,
                      () => CheckModelExist(context, model.id));
            }
        }

        public IEnumerable<IRoleModel> GetAll()
        {
            using (var context = new DbContext())
            {
                return GetAll(() => context.Conn.GetAll<RoleModel>(), _dataAccessStatus);
            }
        }

        public IRoleModel GetById(object id)
        {
            using (var context = new DbContext())
            {
                var model = context.Conn.Get<RoleModel>(id);

                if (model != null)
                {
                    var queryStr = "SELECT * FROM role_detail WHERE role_kode = @kode";
                    var roleDetails = context.Conn.Query<RoleDetailModel>(queryStr, new { model.kode });

                    if (roleDetails != null && roleDetails.ToList().Count > 0)
                    {
                        model.RoleDetails = roleDetails;
                    }
                }

                return model;
            }
        }

        public void Insert(IRoleDetailModel model)
        {
            try
            {
                using (var context = new DbContext())
                {
                    context.Conn.Insert((RoleDetailModel)model);
                }
            }
            catch (MySqlException ex)
            {
                throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                              dataAccessStatus: SetDataAccessValues(ex, ErrorMessageType.Update));
            }
        }

        public void Insert(IEnumerable<IRoleDetailModel> models)
        {
            try
            {
                using (var context = new DbContext())
                {
                    context.Conn.Insert((IEnumerable<RoleDetailModel>)models);
                }
            }
            catch (MySqlException ex)
            {
                throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                              dataAccessStatus: SetDataAccessValues(ex, ErrorMessageType.Update));
            }
        }

        public void Delete(IRoleDetailModel model)
        {
            try
            {
                using (var context = new DbContext())
                {
                    string queryStr = "DELETE FROM role_detail WHERE (role_kode = @kode AND menu_name = @parent) " +
                                      "OR (role_kode = @kode AND menu_parent = @parent)";

                    context.Conn.Execute(queryStr, new
                    {
                        kode = model.role_kode,
                        menu = model.menu_parent,
                        parent = model.menu_parent
                    });
                }
            }
            catch (MySqlException ex)
            {
                throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                              dataAccessStatus: SetDataAccessValues(ex, ErrorMessageType.Update));
            }
        }

        public void DeleteAllRoleDetail()
        {
            using (var context = new DbContext())
            {
                try
                {
                    context.Conn.DeleteAll<RoleDetailModel>();
                }
                catch (MySqlException ex)
                {
                    throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                                  dataAccessStatus: SetDataAccessValues(ex, ErrorMessageType.Delete));
                }
            }
        }

        public IEnumerable<IRoleDetailModel> GetByMenuParent(string roleKode, string menuParent)
        {
            using (var context = new DbContext())
            {
                var queryStr = "SELECT * FROM role_detail WHERE role_kode = @roleKode AND " +
                               "(menu_name = @menuParent OR menu_parent = @menuParent)";
                return context.Conn.Query<RoleDetailModel>(queryStr, new { roleKode, menuParent });
            }
        }

        public IEnumerable<IRoleDetailModel> GetAllByRoleKode(string roleKode)
        {
            using (var context = new DbContext())
            {
                var queryStr = "SELECT * FROM role_detail WHERE role_kode = @roleKode";
                return context.Conn.Query<RoleDetailModel>(queryStr, new { roleKode });
            }
        }

        public IEnumerable<string> GetAllMenuNameByTagAction(string roleKode, string formName)
        {
            using (var context = new DbContext())
            {

                string queryStr = "SELECT menu_name FROM role_detail WHERE role_kode = @kode " +
                                  "AND form_action = @form AND tag = 'action'";
                return context.Conn.Query<string>(queryStr, new { kode = roleKode, form = formName }).ToList();
            }
        }

        private void ValidateModel(DbContext context, IRoleModel model, DataAccessStatus dataAccessStatus)
        {
            var existsKode = context.Conn.ExecuteScalar<bool>("SELECT COUNT(1) FROM role WHERE kode = @kode AND id != @id",
                                                                new { model.kode, model.id });

            if (existsKode)
            {
                dataAccessStatus.Status = "Error";
                dataAccessStatus.CustomMessage = StringHelper.DuplicateEntry("kode", _modelName);

                throw new DataAccessException(dataAccessStatus);
            }
        }

        private bool CheckModelExist(DbContext context, object id)
        {
            return CheckModelExist(context, "SELECT COUNT(1) FROM role WHERE id = @id",
                                                     new { id });
        }
    }
}
