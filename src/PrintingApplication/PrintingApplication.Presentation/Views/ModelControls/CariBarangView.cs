using Equin.ApplicationFramework;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public partial class CariBarangView : BaseCariBarangView
    {
        public event EventHandler OnSendData;
        public event EventHandler OnFormClosing;

        private List<IJenisOrderanModel> _listsJenisOrderan;
        private TipePencarian _tipePencarian;
        private BindingListView<JenisOrderanModel> _bindingView;
        private string _kodeOrNamaValue;

        public CariBarangView()
        {
            InitializeComponent();
        }

        public CariBarangView(List<IJenisOrderanModel> listsBarang, TipePencarian tipePencarian, string kodeOrNamaValue = default(string)) : this()
        {
            _listsJenisOrderan = listsBarang;
            _tipePencarian = tipePencarian;
            _bindingView = new BindingListView<JenisOrderanModel>(_listsJenisOrderan);
            listDataGrid.DataSource = _bindingView;

            listDataGrid.Columns[2].Visible = false; // Stok
            listDataGrid.Columns[7].Visible = false; // Penyesuaian stok

            switch (tipePencarian)
            {
                case TipePencarian.Orderan:

                    listDataGrid.Columns[4].Visible = false; // Hpp
                    listDataGrid.Columns[6].Visible = false; // Minimal stok

                    break;
                case TipePencarian.Pembelian:

                    listDataGrid.Columns[5].Visible = false; // Harga jual
                    listDataGrid.Columns[6].Visible = false; // Minimal stok

                    break;
                case TipePencarian.PenyesuaianStok:

                    listDataGrid.Columns[5].Visible = false; // Harga jual

                    break;
            }

            _kodeOrNamaValue = kodeOrNamaValue;

            if (tipePencarian == TipePencarian.Orderan)
            {
                listDataGrid.QueryRowStyle += ListDataGrid_QueryRowStyle;
            }

            OnEnterKeyDown += CariBarangPembelianView_OnEnterKeyDown;
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

                //if (JenisOrderanModel != null)
                //{
                //    if (JenisOrderanModel.stok <= 0 || JenisOrderanModel.hpp <= 0)
                //    {
                //        e.Style.BackColor = Color.FromArgb(255, 165, 160);
                //        e.Style.TextColor = Color.FromArgb(1, 2, 3);
                //    }
                //}
            }
        }

        private void CariBarangPembelianView_OnEnterKeyDown(object sender, EventArgs e)
        {
            if (listDataGrid.SelectedItem != null)
            {
                var model = (JenisOrderanModel)listDataGrid.SelectedItem;

                //if (_tipePencarian == TipePencarian.Orderan && model.stok <= 0)
                //{
                //    return;
                //}

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
        Pembelian,
        Orderan,
        PenyesuaianStok,
    }
}
