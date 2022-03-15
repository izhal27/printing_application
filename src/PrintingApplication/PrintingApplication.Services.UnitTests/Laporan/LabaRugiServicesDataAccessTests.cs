using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Laporan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Laporan;
using PrintingApplication.Services.Services.Laporan;
using PrintingApplication.Services.UnitTests.CommonTests;
using System;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Laporan
{
    [Trait("Category", "Data Access Validations")]
    public class LabaRugiServicesDataAccessTests
    {
        private ILabaRugiServices _services;
        private ITestOutputHelper _testOutputHelper;

        public LabaRugiServicesDataAccessTests(ITestOutputHelper testOutupuHelper)
        {
            _services = new LabaRugiServices(new LabaRugiRepository());
            _testOutputHelper = testOutupuHelper;
        }

        [Fact]
        private void ShouldReturnSuccessForGetByDate()
        {
            ILabaRugiModel model = null;

            try
            {
                model = _services.GetByMonthYear(DateTime.Now.Date.Month, DateTime.Now.Year);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }

            Assert.NotNull(model);
            TestsHelper.WriteModel(_testOutputHelper, model);
        }
    }
}
