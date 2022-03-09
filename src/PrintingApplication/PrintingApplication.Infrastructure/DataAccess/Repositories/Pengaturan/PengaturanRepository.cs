using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Services.Services.Pengaturan;
using System.Collections.Generic;
using System.Drawing;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Pengaturan
{
    public class PengaturanRepository : BaseRepository<IPengaturanModel>, IPengaturanRepository
    {

        public PengaturanRepository()
        {
            _modelName = "pengaturan";
        }

        public void Insert(IPengaturanModel model)
        {
            throw new System.NotImplementedException();
        }

        public void Update(IPengaturanModel model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(IPengaturanModel model)
        {
            throw new System.NotImplementedException();
        }

        public IPengaturanModel GetById(object id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IPengaturanModel> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
