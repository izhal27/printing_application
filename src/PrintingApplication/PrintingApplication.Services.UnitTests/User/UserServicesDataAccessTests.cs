using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.GantiPassword;
using PrintingApplication.Domain.Models.User;
using PrintingApplication.Infrastructure.DataAccess.Repositories.User;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.User;
using System.Linq;
using Xunit;

namespace PrintingApplication.Services.UnitTests.User
{
    [Trait("Category", "Data Access Validations")]
    public class UserServicesDataAccessTests
    {
        private readonly IUserServices _services;

        public UserServicesDataAccessTests()
        {
            _services = new UserServices(new UserRepository(), new ModelDataAnnotationCheck());
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
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
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }
        }

        [Fact]
        private void ShouldReturnErrorDuplicateInsert()
        {
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
                Assert.NotNull(ex);
            }
        }

        [Fact]
        private void ShouldReturnSuccessForUpdate()
        {
            try
            {
                var model = new UserModel()
                {
                    id = 3,
                    login_id = "izhal_update",
                    password = "izhal",
                    role_kode = "adm"
                };

                _services.Update(model);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }
        }

        [Fact]
        private void ShouldReturnErrorDuplicateUpdate()
        {
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
                Assert.NotNull(ex);
            }
        }

        [Fact]
        private void ShouldReturnSuccessForDelete()
        {
            try
            {
                var model = new UserModel()
                {
                    id = 11,
                };

                _services.Delete(model);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }
        }

        [Fact]
        public void ShouldReturnListOfModels()
        {
            var listModels = _services.GetAll().ToList();

            Assert.NotEmpty(listModels);
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
                Assert.Null(ex);
            }

            Assert.NotNull(model);
            Assert.Equal(model.ToString(), idToGet.ToString());
        }

        [Fact]
        private void ShouldReturnSuccessForGantiPassword()
        {
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
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }
        }
    }
}
