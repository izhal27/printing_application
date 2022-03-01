using PrintingApplication.Domain.Models.JenisOrderan;
using System.Collections.Generic;

namespace PrintingApplication.Services.Services.JenisOrderan
{
    public class JenisOrderanServices : IJenisOrderanServices
    {
        private IJenisOrderanRepository _repo;
        private IModelDataAnnotationCheck _modelDAC;

        public JenisOrderanServices(IJenisOrderanRepository repo, IModelDataAnnotationCheck modelDAC)
        {
            _repo = repo;
            _modelDAC = modelDAC;
        }

        public void Insert(IJenisOrderanModel model)
        {
            ValidateModel(model);
            _repo.Insert(model);
        }

        public void Update(IJenisOrderanModel model)
        {
            ValidateModel(model);
            _repo.Update(model);
        }

        public void Delete(IJenisOrderanModel model)
        {
            _repo.Delete(model);
        }

        public IEnumerable<IJenisOrderanModel> GetAll()
        {
            return _repo.GetAll();
        }

        public IJenisOrderanModel GetById(object id)
        {
            return _repo.GetById(id);
        }

        public void ValidateModel(IJenisOrderanModel model)
        {
            _modelDAC.ValidateModel(model);
        }
    }
}
