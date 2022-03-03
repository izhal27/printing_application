using System.Drawing;

namespace PrintingApplication.Domain.Models.Pengaturan
{
    public interface IPengaturanModel
    {
        string nama { get; set; }
        string alamat_1 { get; set; }
        string alamat_2 { get; set; }
        string telpon { get; set; }
        string kota { get; set; }
        Color warna_backgroud_strip { get; set; }
        Color warna_teks_strip { get; set; }
        Color warna_baris_genap { get; set; }
        Color warna_baris_ganjil { get; set; }
        DockPanelTheme dockpanel_theme { get; set; }
        string path_background { get; set; }
        TipePrinter tipe_printer { get; set; }
        bool show_tool_strip { get; set; }
        bool show_status_strip { get; set; }
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