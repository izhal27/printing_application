using PrintingApplication.Domain.Models.Pengeluaran;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pengeluaran;

namespace PrintingApplication.Services.UnitTests.Pengeluaran
{
    public class PengeluaranServicesFixture : BaseServicesFixture<PengeluaranModel, IPengeluaranServices>
    {
        public PengeluaranServicesFixture()
        {
            Model = new PengeluaranModel();
            Services = new PengeluaranServices(null, new ModelDataAnnotationCheck());
        }
    }
}
