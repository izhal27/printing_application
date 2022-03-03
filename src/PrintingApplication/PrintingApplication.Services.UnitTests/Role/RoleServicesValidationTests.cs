using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Role
{
   [Trait("Category", "Model Validations")]
   public class RoleServicesValidationTests : IClassFixture<RoleServicesFixture>
   {
      private readonly ITestOutputHelper _testOutputHelper;
      private RoleServicesFixture _servicesFixture;

      public RoleServicesValidationTests(RoleServicesFixture servicesFixture, ITestOutputHelper testOutputHelper)
      {
         _servicesFixture = servicesFixture;
         _testOutputHelper = testOutputHelper;
         SetValidSampleValues();
      }

      private void SetValidSampleValues()
      {
         _servicesFixture.Model = new RoleModel
         {
            kode = "tests123",
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
      public void ShouldThrowExceptionForKodeLength()
      {
         _servicesFixture.Model.kode = StringHelper.GetStringByLength(2);

         var exception = Record.Exception(() => _servicesFixture
                                                .Services.ValidateModel(_servicesFixture.Model));

         WriteExceptionTestResult(exception);
      }

      [Fact]
      public void ShouldThrowExceptionForKodeFormat()
      {
         _servicesFixture.Model.kode = "kode tes";

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
      public void ShouldThrowExceptionForNamaLength()
      {
         _servicesFixture.Model.nama = StringHelper.GetStringByLength(2);

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
