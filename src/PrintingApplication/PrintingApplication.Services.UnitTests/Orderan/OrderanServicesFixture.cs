using PrintingApplication.Domain.Models.Orderan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Orderan;

namespace PrintingApplication.Services.UnitTests.Orderan
{
    public class OrderanServicesFixture : BaseServicesFixture<IOrderanModel, IOrderanServices>
    {
        public OrderanServicesFixture()
        {
            Model = new OrderanModel();
            Services = new OrderanServices(null, new ModelDataAnnotationCheck());
        }
    }
}
