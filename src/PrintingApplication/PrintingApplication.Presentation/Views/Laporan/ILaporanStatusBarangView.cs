using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Laporan
{
    public interface ILaporanStatusBarangView : IView
    {
        event EventHandler OnLoadData;
        event EventHandler OnButtonCetakClick;
        event EventHandler OnDateTimePickerTanggalValueChanged;

        DateTimePicker DateTimePickerTanggal { get; }
        Label LabelStokAwal { get; }
        Label LabelStokMasuk { get; }
        Label LabelStokTerjual { get; }
        Label LabelPenyesuaianStok { get; }
        Label LabelReturnPenjualan { get; }
        Label LabelReturnPembelian { get; }
        Label LabelStokAkhir { get; }

        void ShowView();
    }
}
