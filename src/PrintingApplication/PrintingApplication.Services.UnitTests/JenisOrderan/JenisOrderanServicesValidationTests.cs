using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.JenisOrderan
{
    [Trait("Category", "Model Validations")]
    public class JenisOrderanServicesValidationTests : IClassFixture<JenisOrderanServicesFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private JenisOrderanServicesFixture _servicesFixture;

        public JenisOrderanServicesValidationTests(JenisOrderanServicesFixture servicesFixture, ITestOutputHelper testOutputHelper)
        {
            _servicesFixture = servicesFixture;
            _testOutputHelper = testOutputHelper;
            SetValidSampleValues();
        }

        private void SetValidSampleValues()
        {
            _servicesFixture.Model = new JenisOrderanModel()
            {
                kode = "test",
                nama = "Tests",
                keterangan = "Tests"
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
        public void ShouldThrowExceptionForKodeEmpty()
        {
            _servicesFixture.Model.kode = string.Empty;

            var exception = Record.Exception(() => _servicesFixture
                                                   .Services.ValidateModel(_servicesFixture.Model));

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
        public void ShouldThrowExceptionForKodeTooShort()
        {
            _servicesFixture.Model.kode = "A";

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
