using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pengaturan;

namespace PrintingApplication.Services.UnitTests.Pengaturan
{
    public class PengaturanServicesFixture : BaseServicesFixture<PengaturanModel, IPengaturanServices>
    {
        public PengaturanServicesFixture()
        {
            Model = new PengaturanModel();
            Services = new PengaturanServices(null, new ModelDataAnnotationCheck());
        }
    }
}
