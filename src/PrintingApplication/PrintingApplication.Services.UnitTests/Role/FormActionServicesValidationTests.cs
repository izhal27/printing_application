using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Role
{
    [Trait("Category", "Model Validations")]
    public class FormActionServicesValidationTests : IClassFixture<FormActionServicesFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private FormActionServicesFixture _servicesFixture;

        public FormActionServicesValidationTests(FormActionServicesFixture servicesFixture, ITestOutputHelper testOutputHelper)
        {
            _servicesFixture = servicesFixture;
            _testOutputHelper = testOutputHelper;
            SetValidSampleValues();
        }

        private void SetValidSampleValues()
        {
            _servicesFixture.Model = new FormActionModel
            {
                form_name = "tests",
                form_text = "tests"
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
        public void ShouldThrowExceptionForFormNameEmpty()
        {
            _servicesFixture.Model.form_name = string.Empty;

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
