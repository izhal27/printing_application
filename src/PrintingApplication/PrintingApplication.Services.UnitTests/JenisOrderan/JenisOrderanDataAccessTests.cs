using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.JenisOrderan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.JenisOrderan;
using System.Linq;
using Xunit;

namespace PrintingApplication.Services.UnitTests.JenisOrderan
{
    [Trait("Category", "Data Access Validations")]
    public class JenisOrderanDataAccessTests
    {
        private readonly IJenisOrderanServices _services;

        public JenisOrderanDataAccessTests()
        {
            _services = new JenisOrderanServices(new JenisOrderanRepository(), new ModelDataAnnotationCheck());
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    var model = new JenisOrderanModel()
                    {
                        kode = $"jenis-orderan-{i}",
                        nama = $"Jenis Orderan #{i}",
                        harga_satuan = i * 1000,
                        keterangan = $"Keterangan Jenis Orderan #{i}"
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
        private void ShouldReturnErrorDuplicateKodeInsert()
        {
            try
            {
                var model = new JenisOrderanModel()
                {
                    kode = "jenis-orderan-2",
                    nama = "Jenis Orderan #2000",
                };

                _services.Insert(model);
            }
            catch (DataAccessException ex)
            {
                Assert.NotNull(ex);
            }
        }


        [Fact]
        private void ShouldReturnErrorDuplicateNamaInsert()
        {
            try
            {
                var model = new JenisOrderanModel()
                {
                    kode = "jenis-orderan-2000",
                    nama = "Jenis Orderan #2",
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
                var model = new JenisOrderanModel()
                {
                    id = 1,
                    kode = "jenis-orderan-1",
                    nama = "Jenis Orderan #1 (Update)",
                    harga_satuan = 27000,
                    keterangan = "Keterangan Jenis Orderan #1"
                };

                _services.Update(model);
            }
            catch (DataAccessException ex)
            {
                Assert.NotNull(ex);
            }
        }

        [Fact]
        private void ShouldReturnErrorDuplicateUpdateKode()
        {
            try
            {
                var model = new JenisOrderanModel()
                {
                    id = 1,
                    kode = "jenis-orderan-2",
                    nama = "Jenis Orderan #1",
                };

                _services.Update(model);
            }
            catch (DataAccessException ex)
            {
                Assert.NotNull(ex);
            }
        }

        [Fact]
        private void ShouldReturnErrorDuplicateUpdateNama()
        {
            try
            {
                var model = new JenisOrderanModel()
                {
                    id = 1,
                    kode = "jenis-orderan-1",
                    nama = "Jenis Orderan #2",
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
                var model = new JenisOrderanModel()
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
            JenisOrderanModel model = null;
            var idToGet = 1;

            try
            {
                model = (JenisOrderanModel)_services.GetById(idToGet);
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
