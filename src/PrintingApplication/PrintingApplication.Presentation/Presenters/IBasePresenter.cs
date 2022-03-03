using PrintingApplication.Presentation.Views;

namespace PrintingApplication.Presentation.Presenters
{
    public interface IBasePresenter<TView> where TView : IView
    {
        TView GetView { get; }
    }
}
