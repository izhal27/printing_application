using PrintingApplication.Presentation.Views.CommonControls;
using System;

namespace PrintingApplication.Presentation.Views.GantiPassword
{
    public interface IGantiPasswordView : IView
    {
        event EventHandler OnButtonSimpanClick;

        BaseTextBox TextBoxPasswordSekarang { get; }
        BaseTextBox TextBoxPasswordBaru { get; }
        BaseTextBox TextBoxKonfPasswordBaru { get; }

        void ShowView();
    }
}