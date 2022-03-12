using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Pengaturan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pengaturan;
using System.Linq;
using Xunit;

namespace PrintingApplication.Services.UnitTests.Pengaturan
{
    [Trait("Category", "Data Access Validations")]
    public class PengaturanDataAccessTests
    {
        private IPengaturanServices _services;

        public PengaturanDataAccessTests()
        {
            _services = new PengaturanServices(new PengaturanRepository(), new ModelDataAnnotationCheck());
        }

        [Fact]
        private void ShouldReturnSuccessForUpdate()
        {
            try
            {
                var model = new PengaturanModel()
                {
                    id = 1,
                    nama = "Pengaturan #1 (Update)",
                };

                _services.Update(model);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }
        }

        [Fact]
        public void ShouldReturnModel()
        {
            PengaturanModel model = null;

            try
            {
                model = (PengaturanModel)_services.GetModel;
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }

            Assert.NotNull(model);
        }
    }
}
