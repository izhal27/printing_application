using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengeluaran;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Pengeluaran;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pengeluaran;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Pengeluaran
{
    [Trait("Category", "Data Access Validations")]
    public class PengeluaranDataAccessTests
    {
        private IPengeluaranServices _services;
        private readonly ITestOutputHelper _testOutputHelper;

        public PengeluaranDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _services = new PengeluaranServices(new PengeluaranRepository(), new ModelDataAnnotationCheck());
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    var model = new PengeluaranModel()
                    {
                        tanggal = DateTime.Now,
                        nama = $"Pengeluaran #{i}",
                        total = i * 1000,
                        keterangan = $"Keterangan Pengeluaran #{i}"
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
                var model = new PengeluaranModel()
                {
                    id = 1,
                    nama = "Pengeluaran #1 (Update)",
                    total = 30000,
                    keterangan = "Keterangan Pengeluaran #1"
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
                var model = new PengeluaranModel()
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
            PengeluaranModel model = null;
            var idToGet = 1;

            try
            {
                model = (PengeluaranModel)_services.GetById(idToGet);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }

            Assert.NotNull(model);
            Assert.Equal(model.id.ToString(), idToGet.ToString());
        }


        [Fact]
        public void ShouldReturnListOfModelsDateNow()
        {
            var listModels = _services.GetByDate(DateTime.Now.Date).ToList();

            Assert.NotEmpty(listModels);
        }

        [Fact]
        public void ShouldReturnListOfModelsBetweenDate()
        {
            var listModels = _services.GetByDate(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), DateTime.Now.AddDays(3)).ToList();

            Assert.NotEmpty(listModels);
        }

        [Fact]
        public void ShouldReturnListOfReportModelsDateNow()
        {
            var listModels = _services.GetReportByDate(DateTime.Now.Date).ToList();

            Assert.NotEmpty(listModels);
            TestsHelper.WriteListModels(_testOutputHelper, listModels);
        }

        [Fact]
        public void ShouldReturnListOfReportModelsBetweenDate()
        {
            var listModels = _services.GetReportByDate(DateTime.Now.AddDays(-(DateTime.Now.Day)).Date, DateTime.Now.Date).ToList();

            Assert.NotEmpty(listModels);
            TestsHelper.WriteListModels(_testOutputHelper, listModels);
        }
    }
}
