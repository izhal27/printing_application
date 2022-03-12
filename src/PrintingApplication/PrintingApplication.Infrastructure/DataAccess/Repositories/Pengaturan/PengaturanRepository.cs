using Dapper;
using Dapper.Contrib.Extensions;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Services.Services.Pengaturan;
using System.Linq;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Pengaturan
{
    public class PengaturanRepository : IPengaturanRepository
    {
        IPengaturanModel IPengaturanRepository.GetModel => throw new System.NotImplementedException();

        public void Save(IPengaturanModel model)
        {
            using (var context = new DbContext())
            {
                context.Conn.Insert((PengaturanModel)model);
            }
        }

        public void Update(IPengaturanModel model)
        {
            using (var context = new DbContext())
            {
                context.Conn.Update((PengaturanModel)model);
            }
        }

        public IPengaturanModel GetModel
        {
            get
            {
                using (var context = new DbContext())
                {
                    return context.Conn.Query<PengaturanModel>("SELECT * FROM pengaturan").FirstOrDefault();
                }
            }
        }
    }
}
