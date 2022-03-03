using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Laporan
{
    public interface ILaporanTransaksiByDateView : IView
    {
        event EventHandler OnLoadData;
        event EventHandler OnButtonCetakClick;
        event EventHandler OnLabelSelisihTextChanged;
        event EventHandler OnDateTimePickerTanggalValueChanged;

        DateTimePicker DateTimePickerTanggal { get; }
        Label LabelKasAwal { get; }
        Label LabelTotalPenjualan { get; }
        Label LabelTotalDiskon { get; }
        Label LabelTotalPengeluaran { get; }
        Label LabelTotalReturnPenjualan { get; }
        Label LabelSelisih { get; }

        void ShowView();
    }
}
