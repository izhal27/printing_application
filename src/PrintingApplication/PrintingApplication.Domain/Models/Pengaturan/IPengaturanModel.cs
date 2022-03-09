namespace PrintingApplication.Domain.Models.Pengaturan
{
    public interface IPengaturanModel
    {
        uint id { get; set; }
        string nama { get; set; }
        string alamat_1 { get; set; }
        string alamat_2 { get; set; }
        string contact { get; set; }
        int printer_tipe { get; set; }
        string printer_name { get; set; }
        string path_background { get; set; }
    }

    public enum TipePrinter
    {
        InkjetDotMatrix,
        Thermal
    }

    public enum DockPanelTheme
    {
        Default,
        VS2012BlueTheme,
        VS2012DarkTheme,
        VS2012LightTheme,
        VS2013BlueTheme,
        VS2013DarkTheme,
        VS2013LightTheme,
        VS2015BlueTheme,
        VS2015DarkTheme,
        VS2015LightTheme
    }
}