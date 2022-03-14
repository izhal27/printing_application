using Newtonsoft.Json;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Pengaturan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pengaturan;
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
                    nama = "Nama Toko (Update)",
                    alamat_1 = "Alamat 1",
                    alamat_2 = "Alamat 2",
                    contact = "08123456789",
                    printer_tipe = 1,
                    path_logo = null,
                    path_background = null,
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
            var expectedModel = new PengaturanModel()
            {
                id = 1,
                nama = "Nama Toko",
                alamat_1 = "Alamat 1",
                alamat_2 = "Alamat 2",
                contact = "08123456789",
                printer_tipe = 1,
                path_logo = null,
                path_background = null,
            };

            try
            {
                model = (PengaturanModel)_services.GetModel;
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }

            var modelStr = JsonConvert.SerializeObject(model);
            var expectedModelStr = JsonConvert.SerializeObject(expectedModel);

            Assert.NotNull(model);
            Assert.Equal(modelStr, expectedModelStr);
        }
    }
}
