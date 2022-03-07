using PrintingApplication.Domain.Models.Orderan;
using PrintingApplication.Domain.Models.OrderanDetail;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Orderan
{
    [Trait("Category", "Model Validations")]
    public class OrderanServicesValidationTests : IClassFixture<OrderanServicesFixture>
    {
        private OrderanServicesFixture _servicesFixture;
        private ITestOutputHelper _testOutputHelper;

        public OrderanServicesValidationTests(OrderanServicesFixture servicesFixture, ITestOutputHelper testOutputHelper)
        {
            _servicesFixture = servicesFixture;
            _testOutputHelper = testOutputHelper;
            SetValidSampleValues();
        }

        private void SetValidSampleValues()
        {
            _servicesFixture.Model = new OrderanModel
            {
                no_nota = "20190823000001",
                pelanggan_id = 1,
                tanggal = DateTime.Now,
            };

            _servicesFixture.Model.OrderanDetails = new List<OrderanDetailModel>
         {
            new OrderanDetailModel {
                order_id = 1,
                kode_jenis_orderan= "SP-001",
                nama_jenis_orderan="CETAK SPANDUK",
                harga_satuan = 25000,
                jumlah = 1
            },
            new OrderanDetailModel {
                order_id = 1,
                kode_jenis_orderan= "SP-001",
                nama_jenis_orderan="CETAK SPANDUK",
                harga_satuan = 25000,
                jumlah = 1
            },
            new OrderanDetailModel {
                order_id = 1,
                kode_jenis_orderan= "SP-001",
                nama_jenis_orderan="CETAK SPANDUK",
                harga_satuan = 25000,
                jumlah = 1
            },
         };
        }

        [Fact]
        public void ShouldNotThrowExceptionForDefaultTestValuesOnAnnotations()
        {
            var exception = Record.Exception(() => _servicesFixture
                                                   .Services.ValidateModel(_servicesFixture.Model));

            Assert.Null(exception);

            WriteExceptionTestResult(exception);
        }

        [Fact]
        public void ShouldThrowExceptionForPelangganEmpty()
        {
            _servicesFixture.Model.pelanggan_id = default;

            var exception = Record.Exception(() => _servicesFixture
                                                   .Services.ValidateModel(_servicesFixture.Model));

            Assert.NotNull(exception);

            WriteExceptionTestResult(exception);
        }

        private void WriteExceptionTestResult(Exception exception)
        {
            TestsHelper.WriteExceptionTestResult(exception, _testOutputHelper, _servicesFixture.Model);
        }
    }
}
