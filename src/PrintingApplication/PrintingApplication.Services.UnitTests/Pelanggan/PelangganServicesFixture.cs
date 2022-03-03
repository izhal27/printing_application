using PrintingApplication.Domain.Models.Pelanggan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pelanggan;

namespace PrintingApplication.Services.UnitTests.Pelanggan
{
    public class PelangganServicesFixture : BaseServicesFixture<PelangganModel, IPelangganServices>
    {
        public PelangganServicesFixture()
        {
            Model = new PelangganModel();
            Services = new PelangganServices(null, new ModelDataAnnotationCheck());
        }
    }
}
