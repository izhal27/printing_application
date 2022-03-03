using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.GantiPassword;
using PrintingApplication.Domain.Models.User;
using PrintingApplication.Infrastructure.DataAccess.Repositories.User;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.User;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.User
{
    [Trait("Category", "Data Access Validations")]
    public class UserServicesDataAccessTests
    {
        private IUserServices _services;
        private DataAccessException _exceptionInfo;
        private readonly ITestOutputHelper _testOutputHelper;

        public UserServicesDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _services = new UserServices(new UserRepository(), new ModelDataAnnotationCheck());
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                string[] users = new string[] { "izhal", "gooner", "arsenal" };

                foreach (var user in users)
                {
                    var model = new UserModel()
                    {
                        login_id = user,
                        password = "izhal",
                        role_kode = "adm"
                    };

                    _services.Insert(model);
                }

                operationSecceded = true;
            }
            catch (DataAccessException ex)
            {
                operationSecceded = ex.DataAccessStatusInfo.OperationSucceeded;
                dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
            }

            try
            {
                Assert.True(operationSecceded);
                _testOutputHelper.WriteLine("Data berhasil ditambahkan.");
            }
            finally
            {
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }

        [Fact]
        private void ShouldReturnErrorDuplicateInsert()
        {
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                var model = new UserModel()
                {
                    login_id = "gooner",
                    password = "izhal",
                    role_kode = "adm"
                };

                _services.Insert(model);
            }
            catch (DataAccessException ex)
            {
                dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
                _exceptionInfo = ex;
            }
            finally
            {

                TestsHelper.IsError(_exceptionInfo);
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }

        [Fact]
        private void ShouldReturnSuccessForUpdate()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                var model = new UserModel()
                {
                    id = 1,
                    login_id = "izhal_update",
                    password = "izhal",
                    role_kode = "adm"
                };

                _services.Update(model);
                operationSecceded = true;
            }
            catch (DataAccessException ex)
            {
                operationSecceded = ex.DataAccessStatusInfo.OperationSucceeded;
                dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
            }

            try
            {
                Assert.True(operationSecceded);
                _testOutputHelper.WriteLine("Data berhasil diubah.");
            }
            finally
            {
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }

        [Fact]
        private void ShouldReturnErrorDuplicateUpdate()
        {
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                var model = new UserModel()
                {
                    id = 1,
                    login_id = "gooner",
                    password = "izhal",
                    role_kode = "adm"
                };

                _services.Update(model);
            }
            catch (DataAccessException ex)
            {
                dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
                _exceptionInfo = ex;
            }
            finally
            {
                TestsHelper.IsError(_exceptionInfo);
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }

        [Fact]
        private void ShouldReturnSuccessForDelete()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                var model = new UserModel()
                {
                    id = 4,
                };

                _services.Delete(model);
                operationSecceded = true;
            }
            catch (DataAccessException ex)
            {
                operationSecceded = ex.DataAccessStatusInfo.OperationSucceeded;
                dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
            }

            try
            {
                Assert.True(operationSecceded);
                _testOutputHelper.WriteLine("Data berhasil dihapus.");
            }
            finally
            {
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }

        [Fact]
        public void ShouldReturnListOfModels()
        {
            var listModels = _services.GetAll().ToList();

            Assert.NotEmpty(listModels);

            TestsHelper.WriteListModels(_testOutputHelper, listModels);
        }

        [Fact]
        public void ShouldReturnModelMatchingId()
        {
            UserModel model = null;
            var idToGet = 1;

            try
            {
                model = (UserModel)_services.GetById(idToGet);
            }
            catch (DataAccessException ex)
            {
                _testOutputHelper.WriteLine(ex.DataAccessStatusInfo.GetFormatedValues());
            }

            Assert.True(model != null);
            Assert.True(model.id == idToGet);

            if (model != null)
            {
                TestsHelper.WriteModel(_testOutputHelper, model);
            }
        }

        [Fact]
        private void ShouldReturnSuccessForGantiPassword()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                var model = new GantiPasswordModel
                {
                    login_id = "gooner",
                    password_sekarang = "izhal",
                    password_baru = "izhal",
                    konf_password_baru = "izhal"
                };

                _services.GantiPassword(model);

                operationSecceded = true;
            }
            catch (DataAccessException ex)
            {
                operationSecceded = ex.DataAccessStatusInfo.OperationSucceeded;
                dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
            }

            try
            {
                Assert.True(operationSecceded);
                _testOutputHelper.WriteLine("Password berhasil diganti.");
            }
            finally
            {
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }
    }
}
