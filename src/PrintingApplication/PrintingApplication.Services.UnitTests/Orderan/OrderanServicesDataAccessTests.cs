using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Orderan;
using PrintingApplication.Domain.Models.OrderanDetail;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Orderan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Orderan;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Orderan
{
    [Trait("Category", "Data Access Validations")]
    public class OrderanServicesDataAccessTests
    {
        private IModelDataAnnotationCheck _modelDAC;
        private IOrderanServices _services;
        private ITestOutputHelper _testOutputHelper;

        public OrderanServicesDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _modelDAC = new ModelDataAnnotationCheck();
            _services = new OrderanServices(new OrderanRepository(), _modelDAC);
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                var listOrderanDetails = new List<OrderanDetailModel>
               {
                  new OrderanDetailModel
                  {
                     kode_jenis_orderan = "CS-001",
                     nama_jenis_orderan = "CETAK SPANDUK",
                     jumlah = 1,
                     harga_satuan = 24_000,
                     diskon = 0,
                     sub_total = 24_000,
                  },
                  new OrderanDetailModel
                  {
                     kode_jenis_orderan = "CAP-001",
                     nama_jenis_orderan = "CAP BASAH 28",
                     jumlah = 2,
                     harga_satuan = 50_000,
                     diskon = 10_000,
                     sub_total = 90_000,
                  },
                  new OrderanDetailModel
                  {
                     kode_jenis_orderan = "CL-001",
                     nama_jenis_orderan = "CETAK LABEL",
                     jumlah = 1,
                     harga_satuan = 65_000,
                     diskon = 0,
                     sub_total = 65_000,
                  },
               };

                var orderanModel = new OrderanModel
                {
                    pelanggan_id = 1,
                    tanggal = DateTime.Now,
                    OrderanDetails = listOrderanDetails
                };

                _services.Insert(orderanModel);

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
        private void ShouldReturnSuccessForDelete()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                //for (uint i = 1; i <= 5; i++)
                //{
                //   var model = new OrderanModel()
                //   {
                //      id = i,
                //   };

                //   _services.Delete(model);
                //}

                var model = new OrderanModel()
                {
                    id = 1,
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
        public void ShouldReturnModelMatchingNoNota()
        {
            OrderanModel model = null;
            var noNotaToGet = "20190925000001";

            try
            {
                model = (OrderanModel)_services.GetByNoNota(noNotaToGet);
            }
            catch (DataAccessException ex)
            {
                _testOutputHelper.WriteLine(ex.DataAccessStatusInfo.GetFormatedValues());
            }

            Assert.True(model != null);
            Assert.True(model.no_nota == noNotaToGet);

            if (model != null)
            {
                TestsHelper.WriteModel(_testOutputHelper, model);
            }
        }

        [Fact]
        public void ShouldReturnListOfModelsDateNow()
        {
            var listModels = _services.GetByDate(DateTime.Now).ToList();

            Assert.NotEmpty(listModels);

            TestsHelper.WriteListModels(_testOutputHelper, listModels);
        }

        [Fact]
        public void ShouldReturnListOfModelsBetweenDate()
        {
            var listModels = _services.GetByDate(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), DateTime.Now.AddDays(3)).ToList();

            Assert.NotEmpty(listModels);

            TestsHelper.WriteListModels(_testOutputHelper, listModels);
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
