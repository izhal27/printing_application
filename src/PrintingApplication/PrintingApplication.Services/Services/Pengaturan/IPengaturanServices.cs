using PrintingApplication.Domain.Models.Pengaturan;

namespace PrintingApplication.Services.Services.Pengaturan
{
    public interface IPengaturanServices
    {
        void Save(IPengaturanModel model);
        void Update(IPengaturanModel model);
        IPengaturanModel GetModel { get; }
    }
}
