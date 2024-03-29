﻿using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Globalization;

namespace PrintingApplication.Presentation.Views.JenisOrderan
{
    public partial class JenisOrderanEntryView : BaseEntryView, IJenisOrderanEntryView
    {
        private bool _isNewData;
        private IJenisOrderanModel _model;
        public event EventHandler OnSaveData;
        private static string _typeName = "Jenis Orderan";

        public JenisOrderanEntryView(bool isNewData = true, IJenisOrderanModel model = null)
        {
            InitializeComponent();
            _isNewData = isNewData;
            panelUp.LabelInfo = isNewData ? $"TAMBAH {_typeName.ToUpper()}" : $"UBAH {_typeName.ToUpper()}";
            comboBoxUnit.DataSource = Enum.GetValues(typeof(Unit));

            if (!_isNewData)
            {
                _model = model;
                textBoxKode.Text = model.kode;
                textBoxNama.Text = model.nama;
                textBoxHargaSatuan.Text = model.harga_satuan.ToString("N0");
                comboBoxUnit.SelectedItem = model.unit_satuan;
                textBoxKeterangan.Text = model.keterangan;
            }

            operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
        }

        private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
        {
            var model = new JenisOrderanModel
            {
                kode = textBoxKode.Text,
                nama = textBoxNama.Text,
                harga_satuan = decimal.Parse(textBoxHargaSatuan.Text, NumberStyles.Number),
                unit_satuan = (Unit)comboBoxUnit.SelectedItem,
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
