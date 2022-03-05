using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Orderan
{
    public interface IOrderanView : ITransaksiView
    {
        TextBox TextBoxNoNota { get; }
        Label LabelGrandTotal { get; }
    }
}
