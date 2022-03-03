using System.Collections.Generic;

namespace PrintingApplication.Domain.Models.Role
{
    public interface IRoleModel
    {
        uint id { get; set; }
        string kode { get; set; }
        string nama { get; set; }
        string keterangan { get; set; }
        IEnumerable<IRoleDetailModel> RoleDetails { get; set; }
    }
}
