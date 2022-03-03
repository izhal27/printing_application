using PrintingApplication.Domain.Models.Pengaturan;

namespace PrintingApplication.Services.Services.Pengaturan
{
    public interface IPengaturanRepository
    {
        IPengaturanModel GetModel { get; }
        void Save(IPengaturanModel model);
    }
}
