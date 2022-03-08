using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.Pengaturan;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Presenters.Pengaturan
{
    public class PengaturanPresenter : IPengaturanPresenter
    {
        private IPengaturanView _view;
        private IPengaturanModel _model;

        public IPengaturanView GetView
        {
            get { return _view; }
        }

        public PengaturanPresenter()
        {
            _view = new PengaturanView();
            _model = MainProgram.PengaturanServices.GetModel;

            _view.OnLoadData += _view_OnLoadData;
            _view.OnButtonDefaultClick += _view_OnButtonDefaultClick;
            _view.OnButtonSaveClick += _view_OnButtonSaveClick;
        }

        private void _view_OnLoadData(object sender, EventArgs e)
        {
            _view.PropertyGridPengaturan.SelectedObject = _model;
        }

        private void _view_OnButtonDefaultClick(object sender, EventArgs e)
        {
            var model = (PengaturanModel)_view.PropertyGridPengaturan.SelectedObject;

            model.warna_backgroud_strip = Color.FromArgb(67, 78, 84);
            model.warna_teks_strip = Color.FromArgb(240, 240, 240);
            model.warna_baris_genap = Color.FromArgb(240, 248, 255);
            model.warna_baris_ganjil = Color.FromArgb(255, 255, 255);
            model.dockpanel_theme = DockPanelTheme.Default;
            _view.PropertyGridPengaturan.Refresh();
        }

        private void _view_OnButtonSaveClick(object sender, EventArgs e)
        {
            try
            {
                var selectedModel = (PengaturanModel)_view.PropertyGridPengaturan.SelectedObject;

                var newModel = new PengaturanModel
                {
                    nama = selectedModel.nama,
                    alamat_1 = selectedModel.alamat_1,
                    alamat_2 = selectedModel.alamat_2,
                    telpon = selectedModel.telpon,
                    contact = selectedModel.contact,
                    warna_backgroud_strip = selectedModel.warna_backgroud_strip,
                    warna_teks_strip = selectedModel.warna_teks_strip,
                    warna_baris_genap = selectedModel.warna_baris_genap,
                    warna_baris_ganjil = selectedModel.warna_baris_ganjil,
                    dockpanel_theme = selectedModel.dockpanel_theme,
                    path_background = selectedModel.path_background,
                    tipe_printer = selectedModel.tipe_printer,
                    show_tool_strip = selectedModel.show_tool_strip,
                    show_status_strip = selectedModel.show_status_strip
                };

                MainProgram.PengaturanServices.Save(newModel);
                MainProgram.Pengaturan = newModel;
                Messages.Info("Pengaturan berhasil disimpan.");

                ((Form)_view).DialogResult = DialogResult.OK;
            }
            catch (ArgumentException ex)
            {
                Messages.Error(ex);
            }
            catch (DataAccessException ex)
            {
                Messages.Error(ex);
            }
        }
    }
}
