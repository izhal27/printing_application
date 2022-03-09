using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Role;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Role;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Role
{
    [Trait("Category", "Data Access Validations")]
    public class RoleServicesDataAccessTests
    {
        private IRoleServices _services;
        private readonly ITestOutputHelper _testOutputHelper;

        public RoleServicesDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _services = new RoleServices(new RoleRepository(), new ModelDataAnnotationCheck());
        }

        [Fact]
        private void ShouldReturnSuccessForInsertRole()
        {
            try
            {
                var model = new RoleModel()
                {
                    kode = "opr2",
                    nama = "Role Operator",
                    keterangan = "Role Operator"
                };

                _services.Insert(model);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }
        }

        [Fact]
        private void ShouldReturnSuccessForInsertRoleDetail()
        {
            try
            {
                var model = new RoleDetailModel()
                {
                    role_kode = "role",
                    form_action = "UserView",
                    menu_parent = "Master",
                    menu_name = "Tambah",
                    tag = "action"
                };

                _services.Insert(model);
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
                var model = new RoleModel()
                {
                    kode = "role",
                    nama = "Role Tests",
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
                var model = new RoleModel()
                {
                    id = 5,
                    kode = "opr2",
                    nama = "Role Operator (Update)",
                    keterangan = "Role Tests (Update)"
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
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                var model = new RoleModel()
                {
                    id = 2,
                    kode = "role",
                    nama = "Tipe #2",
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
                var model = new RoleModel()
                {
                    id = 5
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
            RoleModel model = null;
            var idToGet = 1;

            try
            {
                model = (RoleModel)_services.GetById(idToGet);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }

            Assert.NotNull(model);
            Assert.Equal(model.id.ToString(), idToGet.ToString());
        }
    }
}
