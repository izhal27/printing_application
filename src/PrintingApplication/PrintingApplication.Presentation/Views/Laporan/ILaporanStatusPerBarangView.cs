using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Laporan
{
    public interface ILaporanStatusPerBarangView : IView
    {
        event EventHandler OnLoadView;
        event EventHandler OnButtonTampilkanClick;
        event EventHandler OnButtonCetakClick;

        ListDataGrid ListDataGrid { get; }
        RadioButton RadioButtonBulan { get; }
        ComboBoxBulan ComboBoxBulan { get; }
        NumericUpDown NumericUpDownTahun { get; }
        ComboBoxBulan ComboBoxBulanAwal { get; }
        NumericUpDown NumericUpDownTahunAwal { get; }
        ComboBoxBulan ComboBoxBulanAkhir { get; }
        NumericUpDown NumericUpDownTahunAkhir { get; }
        Label LabelTotalMasuk { get; }
        Label LabelTotalKeluar { get; }
    }
}