using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pelanggan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Pelanggan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pelanggan;
using PrintingApplication.Services.UnitTests.CommonTests;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Pelanggan
{
    [Trait("Category", "Data Access Validations")]
    public class PelangganDataAccessTests
    {
        private IPelangganServices _services;
        private readonly ITestOutputHelper _testOutputHelper;

        public PelangganDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _services = new PelangganServices(new PelangganRepository(), new ModelDataAnnotationCheck());
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

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
        private void ShouldReturnSuccessForUpdate()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

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
        private void ShouldReturnSuccessForDelete()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                var model = new PelangganModel()
                {
                    id = 10,
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
            PelangganModel model = null;
            var idToGet = 1;

            try
            {
                model = (PelangganModel)_services.GetById(idToGet);
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
    }
}
