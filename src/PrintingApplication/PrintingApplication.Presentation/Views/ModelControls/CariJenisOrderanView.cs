using Equin.ApplicationFramework;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public partial class CariJenisOrderanView : BaseCariJenisOrderanView
    {
        public event EventHandler OnSendData;
        public event EventHandler OnFormClosing;

        private List<IJenisOrderanModel> _listsJenisOrderan;
        private TipePencarian _tipePencarian;
        private BindingListView<JenisOrderanModel> _bindingView;
        private string _kodeOrNamaValue;

        public CariJenisOrderanView()
        {
            InitializeComponent();
        }

        public CariJenisOrderanView(List<IJenisOrderanModel> listsBarang, TipePencarian tipePencarian, string kodeOrNamaValue = default(string)) : this()
        {
            _listsJenisOrderan = listsBarang;
            _tipePencarian = tipePencarian;
            _bindingView = new BindingListView<JenisOrderanModel>(_listsJenisOrderan);
            listDataGrid.DataSource = _bindingView;

            _kodeOrNamaValue = kodeOrNamaValue;

            if (tipePencarian == TipePencarian.Orderan)
            {
                listDataGrid.QueryRowStyle += ListDataGrid_QueryRowStyle;
            }

            OnEnterKeyDown += CariJenisOrderanView_OnEnterKeyDown;
        }

        private void CariBarangView_Load(object sender, EventArgs e)
        {
            listDataGrid.SetLastColumnFill("nama");

            if (!string.IsNullOrWhiteSpace(_kodeOrNamaValue))
            {
                textBoxPencarian.Text = _kodeOrNamaValue;
            }
        }

        private void ListDataGrid_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                var JenisOrderanModel = (JenisOrderanModel)e.RowData;

                if (JenisOrderanModel != null)
                {
                    if (JenisOrderanModel.harga_satuan <= 0)
                    {
                        e.Style.BackColor = Color.FromArgb(255, 165, 160);
                        e.Style.TextColor = Color.FromArgb(1, 2, 3);
                    }
                }
            }
        }

        private void CariJenisOrderanView_OnEnterKeyDown(object sender, EventArgs e)
        {
            if (listDataGrid.SelectedItem != null)
            {
                var model = (JenisOrderanModel)listDataGrid.SelectedItem;

                if (_tipePencarian == TipePencarian.Orderan && model.harga_satuan <= 0)
                {
                    return;
                }

                OnSendData?.Invoke(this, new ModelEventArgs<JenisOrderanModel>((JenisOrderanModel)listDataGrid.SelectedItem));
            }
        }

        protected override void textBoxPencarian_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                var value = textBox.Text;

                _bindingView.DataSource = _listsJenisOrderan.Where(b => b.kode.ToLower().Contains(value.ToLower()) ||
                                                             b.nama.ToLower().Contains(value.ToLower())).ToList();
            }
            else
            {
                _bindingView.DataSource = _listsJenisOrderan;
            }
        }

        private void CariBarangView_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormClosing?.Invoke(sender, e);
        }
    }

    public enum TipePencarian
    {
        Orderan
    }
}
