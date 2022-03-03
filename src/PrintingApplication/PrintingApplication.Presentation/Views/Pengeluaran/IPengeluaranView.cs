using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Pengeluaran
{
    public interface IPengeluaranView : IDataView
    {
        Label LabelTotal { get; }
    }
}
