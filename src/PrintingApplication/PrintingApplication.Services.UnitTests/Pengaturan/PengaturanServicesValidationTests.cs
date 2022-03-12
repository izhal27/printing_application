using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Pengaturan
{
    [Trait("Category", "Model Validations")]
    public class PengaturanServicesValidationTests : IClassFixture<PengaturanServicesFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private PengaturanServicesFixture _servicesFixture;

        public PengaturanServicesValidationTests(PengaturanServicesFixture servicesFixture, ITestOutputHelper testOutputHelper)
        {
            _servicesFixture = servicesFixture;
            _testOutputHelper = testOutputHelper;
            SetValidSampleValues();
        }

        private void SetValidSampleValues()
        {
            _servicesFixture.Model = new PengaturanModel()
            {
                nama = "Tests",
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

            Assert.NotNull(exception);

            WriteExceptionTestResult(exception);
        }

        private void WriteExceptionTestResult(Exception exception)
        {
            TestsHelper.WriteExceptionTestResult(exception, _testOutputHelper, _servicesFixture.Model);
        }
    }
}
