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
        string path_logo { get; set; }
        string path_background { get; set; }
        string catatan_kaki { get; set; }
        bool tampilkan_pajak { get; set; }
        TipePrinter tipe_printer { get; }
    }

    public enum TipePrinter
    {
        Inkjet = 1,
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