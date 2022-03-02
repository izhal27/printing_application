using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.JenisOrderan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.JenisOrderan;
using PrintingApplication.Services.UnitTests.CommonTests;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Tipe
{
    [Trait("Category", "Data Access Validations")]
    public class JenisOrderanDataAccessTests
    {
        private IJenisOrderanServices _services;
        private readonly ITestOutputHelper _testOutputHelper;
        private DataAccessException _exceptionInfo;

        public JenisOrderanDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _services = new JenisOrderanServices(new JenisOrderanRepository(), new ModelDataAnnotationCheck());
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    var model = new JenisOrderanModel()
                    {
                        kode = $"jenis-orderan-{i}",
                        nama = $"Jenis Orderan #{i}",
                        harga_satuan = i * 1000,
                        keterangan = $"Keterangan Tipe #{i}"
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
        private void ShouldReturnErrorDuplicateKodeInsert()
        {
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

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
        private void ShouldReturnErrorDuplicateNamaInsert()
        {
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

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
                var model = new JenisOrderanModel()
                {
                    id = 1,
                    kode = "jenis-orderan-1",
                    nama = "Jenis Orderan #1 (Update)",
                    harga_satuan = 27000,
                    keterangan = "Keterangan Jenis Orderan #1"
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
        private void ShouldReturnErrorDuplicateUpdateKode()
        {
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

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
        private void ShouldReturnErrorDuplicateUpdateNama()
        {
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

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
                var model = new JenisOrderanModel()
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
            JenisOrderanModel model = null;
            var idToGet = 1;

            try
            {
                model = (JenisOrderanModel)_services.GetById(idToGet);
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
