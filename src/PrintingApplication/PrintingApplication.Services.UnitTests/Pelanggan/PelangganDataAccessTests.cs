using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pelanggan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Pelanggan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pelanggan;
using System.Linq;
using Xunit;

namespace PrintingApplication.Services.UnitTests.Pelanggan
{
    [Trait("Category", "Data Access Validations")]
    public class PelangganDataAccessTests
    {
        private IPelangganServices _services;

        public PelangganDataAccessTests()
        {
            _services = new PelangganServices(new PelangganRepository(), new ModelDataAnnotationCheck());
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
            try
            {
                for (int i = 2; i <= 10; i++)
                {
                    var model = new PelangganModel()
                    {
                        nama = $"Pelanggan #{i}",
                        alamat = $"Alamat Pelanggan #{i}",
                        contact = "08123456789",
                        keterangan = $"Keterangan Pelanggan #{i}",
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
        private void ShouldReturnSuccessForUpdate()
        {
            try
            {
                var model = new PelangganModel()
                {
                    id = 2,
                    nama = "Pelanggan #2 (Update)",
                    alamat = $"Alamat Pelanggan #2 (Update)",
                    contact = "08123456789 (Update)",
                    keterangan = $"Keterangan Pelanggan #2 (Update)",
                };

                _services.Update(model);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }
        }

        [Fact]
        private void ShouldReturnSuccessForDelete()
        {
            try
            {
                var model = new PelangganModel()
                {
                    id = 10,
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
            PelangganModel model = null;
            var idToGet = 1;

            try
            {
                model = (PelangganModel)_services.GetById(idToGet);
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
