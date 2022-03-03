namespace PrintingApplication.Domain.Models.Role
{
    public interface IRoleDetailModel
    {
        string role_kode { get; set; }
        string menu_name { get; set; }
        string menu_parent { get; set; }
        string form_action { get; set; }
        string tag { get; set; }
    }
}
