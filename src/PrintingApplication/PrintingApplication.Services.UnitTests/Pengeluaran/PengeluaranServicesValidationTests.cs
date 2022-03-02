using PrintingApplication.Domain.Models.Pengeluaran;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Pengeluaran
{
    [Trait("Category", "Model Validations")]
    public class PengeluaranServicesValidationTests : IClassFixture<PengeluaranServicesFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private PengeluaranServicesFixture _servicesFixture;

        public PengeluaranServicesValidationTests(PengeluaranServicesFixture servicesFixture, ITestOutputHelper testOutputHelper)
        {
            _servicesFixture = servicesFixture;
            _testOutputHelper = testOutputHelper;
            SetValidSampleValues();
        }

        private void SetValidSampleValues()
        {
            _servicesFixture.Model = new PengeluaranModel()
            {
                nama = "Tests",
                keterangan = "Tests",
                total = 27000
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
        public void ShouldThrowExceptionForNamaEmpty()
        {
            _servicesFixture.Model.nama = string.Empty;

            var exception = Record.Exception(() => _servicesFixture
                                                   .Services.ValidateModel(_servicesFixture.Model));

            WriteExceptionTestResult(exception);
        }

        [Fact]
        public void ShouldThrowExceptionForNamaTooShort()
        {
            _servicesFixture.Model.nama = "A";

            var exception = Record.Exception(() => _servicesFixture
                                                   .Services.ValidateModel(_servicesFixture.Model));

            WriteExceptionTestResult(exception);
        }

        private void WriteExceptionTestResult(Exception exception)
        {
            TestsHelper.WriteExceptionTestResult(exception, _testOutputHelper, _servicesFixture.Model);
        }
    }
}
