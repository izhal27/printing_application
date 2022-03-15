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
        private readonly IModelDataAnnotationCheck _modelDAC;
        private readonly IOrderanServices _services;
        private readonly ITestOutputHelper _testOutputHelper;

        public OrderanServicesDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _modelDAC = new ModelDataAnnotationCheck();
            _services = new OrderanServices(new OrderanRepository(), _modelDAC);
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
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
                  },
                  new OrderanDetailModel
                  {
                     kode_jenis_orderan = "CAP-001",
                     nama_jenis_orderan = "CAP BASAH 28",
                     jumlah = 2,
                     harga_satuan = 50_000,
                     diskon = 10_000,
                  },
                  new OrderanDetailModel
                  {
                     kode_jenis_orderan = "CL-001",
                     nama_jenis_orderan = "CETAK LABEL",
                     jumlah = 1,
                     harga_satuan = 65_000,
                     diskon = 0,
                  },
               };

                var orderanModel = new OrderanModel
                {
                    pelanggan_id = 1,
                    tanggal = DateTime.Now,
                    OrderanDetails = listOrderanDetails
                };

                _services.Insert(orderanModel);
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
                var model = new OrderanModel()
                {
                    id = 1,
                };

                _services.Delete(model);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }
        }

        [Fact]
        public void ShouldReturnModelMatchingNoNota()
        {
            OrderanModel model = null;
            var noNotaToGet = "20220314000002";

            try
            {
                model = (OrderanModel)_services.GetByNoNota(noNotaToGet);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }

            Assert.NotNull(model);
            Assert.Equal(model.no_nota, noNotaToGet);
            Assert.True(model.OrderanDetails.Count() > 0);

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
