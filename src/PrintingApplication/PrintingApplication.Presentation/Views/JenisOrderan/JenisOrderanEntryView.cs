using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using System;

namespace PrintingApplication.Presentation.Views.Tipe
{
    public partial class JenisOrderanEntryView : BaseEntryView, ITipeEntryView
    {
        private bool _isNewData;
        private IJenisOrderanModel _model;
        public event EventHandler OnSaveData;
        private static string _typeName = "Tipe";

        public JenisOrderanEntryView(bool isNewData = true, IJenisOrderanModel model = null)
        {
            InitializeComponent();
            _isNewData = isNewData;
            panelUp.LabelInfo = isNewData ? $"TAMBAH {_typeName.ToUpper()}" : $"UBAH {_typeName.ToUpper()}";

            if (!_isNewData)
            {
                _model = model;
                textBoxNama.Text = model.nama;
                textBoxKeterangan.Text = model.keterangan;
            }

            operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
        }

        private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
        {
            var model = new JenisOrderanModel
            {
                nama = textBoxNama.Text,
                keterangan = textBoxKeterangan.Text
            };

            var modelArgs = new ModelEventArgs<JenisOrderanModel>(model);

            if (_isNewData)
            {
                if (Messages.ConfirmSave(_typeName))
                {
                    OnSaveData?.Invoke(this, modelArgs);
                }
            }
            else if (Messages.ConfirmUpdate(_typeName))
            {
                model.id = _model.id;
                OnSaveData?.Invoke(this, modelArgs);
            }
        }
    }
}
