using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pelanggan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using System;

namespace PrintingApplication.Presentation.Views.Pelanggan
{
    public partial class PelangganEntryView : BaseEntryView, IPelangganEntryView
    {
        private bool _isNewData;
        private IPelangganModel _model;
        public event EventHandler OnSaveData;
        private static string _typeName = "Pelanggan";

        public PelangganEntryView(bool isNewData = true, IPelangganModel model = null)
        {
            InitializeComponent();

            _isNewData = isNewData;
            panelUp.LabelInfo = isNewData ? $"TAMBAH {_typeName.ToUpper()}" : $"UBAH {_typeName.ToUpper()}";

            if (!_isNewData)
            {
                _model = model;
                textBoxNama.Text = model.nama;
                textBoxAlamat.Text = model.alamat;
                textBoxContact.Text = model.contact;
                textBoxKeterangan.Text = model.keterangan;
            }

            operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
        }

        private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
        {
            var model = new PelangganModel
            {
                nama = textBoxNama.Text,
                alamat = textBoxAlamat.Text,
                contact = textBoxContact.Text,
                keterangan = textBoxKeterangan.Text,
            };

            var modelArgs = new ModelEventArgs<PelangganModel>(model);

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
