using PrintingApplication.Domain.Models.Pengaturan;
using System;

namespace PrintingApplication.Presentation.Views.Pengaturan
{
    public interface IPengaturanView : IView
    {
        event EventHandler OnLoadData;
        event EventHandler OnButtonSaveClick;

        IPengaturanModel Model { get; set; }

        void ShowView();
    }
}
