using PrintingApplication.Domain.Models.Role;
using System.Collections.Generic;

namespace PrintingApplication.Services.Services.Role
{
    public class RoleServices : IRoleServices
    {
        private IRoleRepository _repo;
        private IModelDataAnnotationCheck _modelDAC;

        public RoleServices(IRoleRepository repo, IModelDataAnnotationCheck modelDAC)
        {
            _repo = repo;
            _modelDAC = modelDAC;
        }

        public void Insert(IRoleModel model)
        {
            ValidateModel(model);
            _repo.Insert(model);
        }

        public void Update(IRoleModel model)
        {
            ValidateModel(model);
            _repo.Update(model);
        }

        public void Delete(IRoleModel model)
        {
            _repo.Delete(model);
        }

        public IEnumerable<IRoleModel> GetAll()
        {
            return _repo.GetAll();
        }

        public IRoleModel GetById(object id)
        {
            return _repo.GetById(id);
        }

        public void Insert(IRoleDetailModel model)
        {
            _repo.Insert(model);
        }

        public void Insert(IEnumerable<IRoleDetailModel> models)
        {
            _repo.Insert(models);
        }

        public void Delete(IRoleDetailModel model)
        {
            _repo.Delete(model);
        }

        public void DeleteAllRoleDetail()
        {
            _repo.DeleteAllRoleDetail();
        }

        public IEnumerable<IRoleDetailModel> GetByMenuParent(string roleKode, string menuParent)
        {
            return _repo.GetByMenuParent(roleKode, menuParent);
        }

        public IEnumerable<IRoleDetailModel> GetAllByRoleKode(string roleKode)
        {
            return _repo.GetAllByRoleKode(roleKode);
        }

        public IEnumerable<string> GetAllMenuNameByTagAction(string roleKode, string formName)
        {
            return _repo.GetAllMenuNameByTagAction(roleKode, formName);
        }

        public void ValidateModel(IRoleModel model)
        {
            _modelDAC.ValidateModel(model);
            _modelDAC.ValidateModels(model.RoleDetails);
        }
    }
}
