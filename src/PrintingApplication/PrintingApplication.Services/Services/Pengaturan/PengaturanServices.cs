using PrintingApplication.Domain.Models.Pengaturan;

namespace PrintingApplication.Services.Services.Pengaturan
{
    public class PengaturanServices 
    {
        private IModelDataAnnotationCheck _modelDAC;
        private IPengaturanRepository _repo;

        public PengaturanServices(IPengaturanRepository repo, IModelDataAnnotationCheck modelDAC)
        {
            _repo = repo;
            _modelDAC = modelDAC;
        }
    }
}
