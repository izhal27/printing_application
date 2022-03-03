using System;

namespace PrintingApplication.Presentation.Views
{
    public interface IEntryView : IView
    {
        event EventHandler OnSaveData;
    }
}
