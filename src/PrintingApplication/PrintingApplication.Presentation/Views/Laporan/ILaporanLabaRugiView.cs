using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Laporan
{
    public interface ILaporanLabaRugiView : IView
    {
        event EventHandler OnLoadData;
        event EventHandler OnComboBoxBulanSelectedIndexChanged;
        event EventHandler OnNumericUpDownTahunValueChanged;
        event EventHandler OnLabelSelisihTextChanged;
        event EventHandler OnButtonCetakClick;

        ComboBoxBulan ComboBoxBulan { get; }
        NumericUpDown NumericUpDownTahun { get; }
        Label LabelOrderan { get; }
        Label LabelPengeluaran { get; }
        Label LabelDiskonOrderan { get; }
        Label LabelTotalSelisih { get; }

        void ShowView();
    }
}
