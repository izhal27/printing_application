using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengeluaran;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Globalization;

namespace PrintingApplication.Presentation.Views.Pengeluaran
{
    public partial class PengeluaranEntryView : BaseEntryView, IPengeluaranEntryView
    {
        private bool _isNewData;
        private IPengeluaranModel _model;
        public event EventHandler OnSaveData;
        private static string _typeName = "Pengeluaran";


        public PengeluaranEntryView(bool isNewData = true, IPengeluaranModel model = null)
        {
            InitializeComponent();

            _isNewData = isNewData;
            panelUp.LabelInfo = isNewData ? $"TAMBAH {_typeName.ToUpper()}" : $"UBAH {_typeName.ToUpper()}";

            if (!_isNewData)
            {
                _model = model;
                textBoxNama.Text = model.nama;
                textBoxJumlah.Text = model.total.ToString("N0");
                textBoxKeterangan.Text = model.keterangan;
            }

            operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
        }

        private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
        {
            var model = new PengeluaranModel
            {
                nama = textBoxNama.Text,
                total = uint.Parse(textBoxJumlah.Text, NumberStyles.Number),
                keterangan = textBoxKeterangan.Text
            };

            var modelArgs = new ModelEventArgs<PengeluaranModel>(model);

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
                //model.tanggal = _model.tanggal;
                OnSaveData?.Invoke(this, modelArgs);
            }
        }
    }
}
