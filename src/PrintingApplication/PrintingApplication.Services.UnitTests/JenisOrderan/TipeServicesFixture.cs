using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.JenisOrderan;

namespace PrintingApplication.Services.UnitTests.JenisOrderan
{
    public class JenisOrderanServicesFixture : BaseServicesFixture<JenisOrderanModel, IJenisOrderanServices>
    {
        public JenisOrderanServicesFixture()
        {
            Model = new JenisOrderanModel();
            Services = new JenisOrderanServices(null, new ModelDataAnnotationCheck());
        }
    }
}
