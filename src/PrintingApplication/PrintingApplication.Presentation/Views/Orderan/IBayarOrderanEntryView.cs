using System;

namespace PrintingApplication.Presentation.Views.Orderan
{
    public interface IBayarOrderanEntryView
    {
        event EventHandler<OrderanEventArgs> OnBayarOrderan;
    }
}