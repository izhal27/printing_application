using Dexih.Utils.CopyProperties;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengaturan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.Pengaturan;
using System;
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
            _view.OnButtonSaveClick += _view_OnButtonSaveClick;
        }

        private void _view_OnLoadData(object sender, EventArgs e)
        {
            _view.Model = _model;
        }

        private void _view_OnButtonSaveClick(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                try
                {
                    MainProgram.PengaturanServices.Update(_model);
                    _model.CopyProperties(MainProgram.PengaturanModel);

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
}
