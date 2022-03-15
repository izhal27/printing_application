using PrintingApplication.Domain.Models.Pengeluaran;
using PrintingApplication.Services.Services.JenisOrderan;
using System.Collections.Generic;

namespace PrintingApplication.Services.Services.Pengeluaran
{
    public class PengeluaranServices : IPengeluaranServices
    {
        private IPengeluaranRepository _repo;
        private IModelDataAnnotationCheck _modelDAC;

        public PengeluaranServices(IPengeluaranRepository repo, IModelDataAnnotationCheck modelDAC)
        {
            _repo = repo;
            _modelDAC = modelDAC;
        }

        public void Insert(IPengeluaranModel model)
        {
            ValidateModel(model);
            _repo.Insert(model);
        }

        public void Update(IPengeluaranModel model)
        {
            ValidateModel(model);
            _repo.Update(model);
        }

        public void Delete(IPengeluaranModel model)
        {
            _repo.Delete(model);
        }

        public IEnumerable<IPengeluaranModel> GetAll()
        {
            return _repo.GetAll();
        }

        public IPengeluaranModel GetById(object id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<IPengeluaranModel> GetByDate(object date)
        {
            return _repo.GetByDate(date);
        }

        public IEnumerable<IPengeluaranModel> GetByDate(object startDate, object endDate)
        {
            return _repo.GetByDate(startDate, endDate);
        }

        public IEnumerable<IPengeluaranModel> GetReportByDate(object date)
        {
            return _repo.GetReportByDate(date);
        }

        public IEnumerable<IPengeluaranModel> GetReportByDate(object startDate, object endDate)
        {
            return _repo.GetReportByDate(startDate, endDate);
        }

        public void ValidateModel(IPengeluaranModel model)
        {
            _modelDAC.ValidateModel(model);
        }
    }
}
