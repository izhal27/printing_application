using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.User;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.User
{
   [Trait("Category", "Model Validations")]
   public class UserServicesValidationTests : IClassFixture<UserServicesFixture>
   {
      private readonly ITestOutputHelper _testOutputHelper;
      private UserServicesFixture _servicesFixture;

      public UserServicesValidationTests(UserServicesFixture servicesFixture, ITestOutputHelper testOutputHelper)
      {
         _servicesFixture = servicesFixture;
         _testOutputHelper = testOutputHelper;
         SetValidSampleValues();
      }

      private void SetValidSampleValues()
      {
         _servicesFixture.Model = new UserModel
         {
            login_id = "tests123",
            password = "Tests",
            role_kode = "Tests"
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
      public void ShouldThrowExceptionForLoginIDEmpty()
      {
         _servicesFixture.Model.login_id = string.Empty;

         var exception = Record.Exception(() => _servicesFixture
                                                .Services.ValidateModel(_servicesFixture.Model));

         WriteExceptionTestResult(exception);
      }

      [Fact]
      public void ShouldThrowExceptionForLoginIDLength()
      {
         _servicesFixture.Model.login_id = StringHelper.GetStringByLength(2);

         var exception = Record.Exception(() => _servicesFixture
                                                .Services.ValidateModel(_servicesFixture.Model));

         WriteExceptionTestResult(exception);
      }

      [Fact]
      public void ShouldThrowExceptionForLoginIDFormat()
      {
         _servicesFixture.Model.login_id = "kode tes";

         var exception = Record.Exception(() => _servicesFixture
                                                .Services.ValidateModel(_servicesFixture.Model));

         WriteExceptionTestResult(exception);
      }

      [Fact]
      public void ShouldThrowExceptionForPasswordEmpty()
      {
         _servicesFixture.Model.password = string.Empty;

         var exception = Record.Exception(() => _servicesFixture
                                                .Services.ValidateModel(_servicesFixture.Model));

         WriteExceptionTestResult(exception);
      }

      [Fact]
      public void ShouldThrowExceptionForPasswordLength()
      {
         _servicesFixture.Model.password = StringHelper.GetStringByLength(2);

         var exception = Record.Exception(() => _servicesFixture
                                                .Services.ValidateModel(_servicesFixture.Model));

         WriteExceptionTestResult(exception);
      }

      [Fact]
      public void ShouldThrowExceptionForPasswordFormat()
      {
         _servicesFixture.Model.password = "kode tes";

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
