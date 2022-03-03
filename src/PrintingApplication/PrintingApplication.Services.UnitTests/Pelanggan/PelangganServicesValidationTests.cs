using PrintingApplication.Domain.Models.Pelanggan;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Pelanggan
{
    [Trait("Category", "Model Validations")]
    public class PelangganServicesValidationTests : IClassFixture<PelangganServicesFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private PelangganServicesFixture _servicesFixture;

        public PelangganServicesValidationTests(PelangganServicesFixture servicesFixture, ITestOutputHelper testOutputHelper)
        {
            _servicesFixture = servicesFixture;
            _testOutputHelper = testOutputHelper;
            SetValidSampleValues();
        }

        private void SetValidSampleValues()
        {
            _servicesFixture.Model = new PelangganModel()
            {
                nama = "Tests",
                alamat = "Tests",
                contact = "08123456789",
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
