using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Services.Services.Pengaturan;
using System.Drawing;

namespace PrintingApplication.Infrastructure.DataAccess.Repositories.Pengaturan
{
    public class PengaturanRepository : IPengaturanRepository
    {
        public IPengaturanModel GetModel
        {
            get
            {
                var model = new PengaturanModel();

                model.nama = ConfigHelper.GetConfig("Nama") ?? "";
                model.alamat_1 = ConfigHelper.GetConfig("Alamat_1") ?? "";
                model.alamat_2 = ConfigHelper.GetConfig("Alamat_2") ?? "";
                model.telpon = ConfigHelper.GetConfig("Telpon") ?? "";
                model.kota = ConfigHelper.GetConfig("Kota") ?? "";
                model.warna_backgroud_strip = ConfigHelper.GetColorFromConfig("Warna_Background_Strip", Color.FromArgb(67, 78, 84));
                model.warna_teks_strip = ConfigHelper.GetColorFromConfig("Warna_Teks_Strip", Color.FromArgb(255, 255, 255));
                model.warna_baris_genap = ConfigHelper.GetColorFromConfig("Warna_Baris_Genap", Color.FromArgb(240, 248, 255));
                model.warna_baris_ganjil = ConfigHelper.GetColorFromConfig("Warna_Baris_Ganjil", Color.FromArgb(255, 255, 255));
                model.path_background = !string.IsNullOrWhiteSpace(ConfigHelper.GetConfig("Path_Backround")) ? ConfigHelper.GetConfig("Path_Backround") : "";
                model.dockpanel_theme = !string.IsNullOrWhiteSpace(ConfigHelper.GetConfig("Dockpanel_Theme")) ?
                                     (DockPanelTheme)int.Parse(ConfigHelper.GetConfig("Dockpanel_Theme")) : DockPanelTheme.Default;
                model.tipe_printer = !string.IsNullOrWhiteSpace(ConfigHelper.GetConfig("Tipe_Printer")) ?
                                     (TipePrinter)int.Parse(ConfigHelper.GetConfig("Tipe_Printer")) : TipePrinter.InkjetDotMatrix;
                model.show_tool_strip = ConfigHelper.GetConfig<bool>("ShowToolStrip");
                model.show_status_strip = ConfigHelper.GetConfig<bool>("ShowStatusStrip");

                return model;
            }
        }

        public void Save(IPengaturanModel model)
        {
            ConfigHelper.SaveConfig("Nama", model.nama);
            ConfigHelper.SaveConfig("Alamat_1", model.alamat_1);
            ConfigHelper.SaveConfig("Alamat_2", model.alamat_2);
            ConfigHelper.SaveConfig("Telpon", model.telpon);
            ConfigHelper.SaveConfig("Kota", model.kota);
            ConfigHelper.SaveConfig("Warna_Background_Strip", model.warna_backgroud_strip.ToStringRgb());
            ConfigHelper.SaveConfig("Warna_Teks_Strip", model.warna_teks_strip.ToStringRgb());
            ConfigHelper.SaveConfig("Warna_Baris_Genap", model.warna_baris_genap.ToStringRgb());
            ConfigHelper.SaveConfig("Warna_Baris_Ganjil", model.warna_baris_ganjil.ToStringRgb());
            ConfigHelper.SaveConfig("Tipe_Printer", model.tipe_printer.ToString("d"));
            ConfigHelper.SaveConfig("Dockpanel_Theme", model.dockpanel_theme.ToString("d"));
            ConfigHelper.SaveConfig("Path_Backround", model.path_background);
            ConfigHelper.SaveConfig("ShowToolStrip", model.show_tool_strip.ToString().ToLower());
            ConfigHelper.SaveConfig("ShowStatusStrip", model.show_status_strip.ToString().ToLower());
        }
    }
}
