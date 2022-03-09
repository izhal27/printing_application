using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Role;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Role;
using System.Linq;
using Xunit;

namespace PrintingApplication.Services.UnitTests.Role
{
    [Trait("Category", "Data Access Validations")]
    public class FormActionServicesDataAccessTests
    {
        private IFormActionServices _services;

        public FormActionServicesDataAccessTests()
        {
            _services = new FormActionServices(new FormActionRepository(), new ModelDataAnnotationCheck());
        }

        [Fact]
        private void ShouldReturnSuccessForInsert()
        {
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
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }
        }

        [Fact]
        private void ShouldReturnErrorDuplicateInsert()
        {
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
                Assert.NotNull(ex);
            }
        }

        [Fact]
        public void ShouldReturnListOfModels()
        {
            var listModels = _services.GetAll().ToList();

            Assert.NotEmpty(listModels);
        }

        [Fact]
        public void ShouldReturnModelMatchingFormName()
        {
            FormActionModel model = null;
            var formNameToGet = "JenisOrderanView";

            try
            {
                model = (FormActionModel)_services.GetByFormName(formNameToGet);
            }
            catch (DataAccessException ex)
            {
                Assert.Null(ex);
            }

            Assert.NotNull(model);
            Assert.Equal(model.form_name, formNameToGet);
        }

    }
}
