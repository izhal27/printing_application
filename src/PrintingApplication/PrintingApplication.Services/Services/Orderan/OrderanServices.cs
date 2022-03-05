using PrintingApplication.Domain.Models.Oderan;
using RumahScarlett.Domain.Models.Orderan;
using System;
using System.Collections.Generic;

namespace PrintingApplication.Services.Services.Orderan
{
    public class OrderanServices : IOrderanServices
    {
        private IOrderanRepository _repo;
        private IModelDataAnnotationCheck _modelDAC;

        public OrderanServices(IOrderanRepository repo, IModelDataAnnotationCheck modelDAC)
        {
            _repo = repo;
            _modelDAC = modelDAC;
        }

        public void Insert(IOrderanModel model)
        {
            ValidateModel(model);
            _repo.Insert(model);
        }

        public void Update(IOrderanModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(IOrderanModel model)
        {
            _repo.Delete(model);
        }

        public IEnumerable<IOrderanModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IOrderanModel> GetByDate(object date)
        {
            return _repo.GetByDate(date);
        }

        public IEnumerable<IOrderanModel> GetByDate(object startDate, object endDate)
        {
            return _repo.GetByDate(startDate, endDate);
        }

        public IOrderanModel GetById(object id)
        {
            return _repo.GetById(id);
        }

        public IOrderanModel GetByNoNota(object noNota)
        {
            return _repo.GetByNoNota(noNota);
        }

        public IEnumerable<IOrderanReportModel> GetReportByDate(object date)
        {
            return _repo.GetReportByDate(date);
        }

        public IEnumerable<IOrderanReportModel> GetReportByDate(object startDate, object endDate)
        {
            return _repo.GetReportByDate(startDate, endDate);
        }

        public void ValidateModel(IOrderanModel model)
        {
            _modelDAC.ValidateModel(model);
            _modelDAC.ValidateModels(model.PenjualanDetails);
        }
    }
}
