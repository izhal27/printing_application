using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Role;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Role;
using PrintingApplication.Services.UnitTests.CommonTests;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace PrintingApplication.Services.UnitTests.Role
{
    [Trait("Category", "Data Access Validations")]
    public class FormActionServicesDataAccessTests
    {
        private IFormActionServices _services;
        private readonly ITestOutputHelper _testOutputHelper;

        public FormActionServicesDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _services = new FormActionServices(new FormActionRepository(), new ModelDataAnnotationCheck());
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
            var operationSecceded = false;
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                string[] formNames = new string[]
                {
               "JenisOrderanView", "PengeluaranlierView", "PelangganView"
                };

                foreach (var form in formNames)
                {
                    var model = new FormActionModel()
                    {
                        form_name = form,
                        form_text = "Jenis Orderan",
                        act_1 = "Tambah",
                        act_2 = "Ubah",
                        act_3 = "Hapus",
                    };

                    _services.Insert(model);
                }

                operationSecceded = true;
            }
            catch (DataAccessException ex)
            {
                operationSecceded = ex.DataAccessStatusInfo.OperationSucceeded;
                dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
            }

            try
            {
                Assert.True(operationSecceded);
                _testOutputHelper.WriteLine("Data berhasil ditambahkan.");
            }
            finally
            {
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }

        [Fact]
        private void ShouldReturnErrorDuplicateInsert()
        {
            var dataAccessJsonStr = string.Empty;
            var formattedJsonStr = string.Empty;

            try
            {
                var model = new FormActionModel()
                {
                    form_name = "JenisOrderanView",
                    form_text = "Jenis Orderan",
                    act_1 = "Tambah",
                    act_2 = "Ubah",
                    act_3 = "Hapus",
                };

                _services.Insert(model);
            }
            catch (DataAccessException ex)
            {
                dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
                formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
            }
            finally
            {
                _testOutputHelper.WriteLine(formattedJsonStr);
            }
        }

        [Fact]
        public void ShouldReturnListOfModels()
        {
            var listModels = _services.GetAll().ToList();

            Assert.NotEmpty(listModels);

            TestsHelper.WriteListModels(_testOutputHelper, listModels);
        }

        [Fact]
        public void ShouldReturnModelMatchingFormName()
        {
            FormActionModel model = null;
            var formNameToGet = "TipeView";

            try
            {
                model = (FormActionModel)_services.GetByFormName(formNameToGet);
            }
            catch (DataAccessException ex)
            {
                _testOutputHelper.WriteLine(ex.DataAccessStatusInfo.GetFormatedValues());
            }

            Assert.True(model != null);
            Assert.True(model.form_name == formNameToGet);

            if (model != null)
            {
                TestsHelper.WriteModel(_testOutputHelper, model);
            }
        }

    }
}
