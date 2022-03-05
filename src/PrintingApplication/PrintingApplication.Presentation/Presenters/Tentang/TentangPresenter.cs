using PrintingApplication.Presentation.Views.Tentang;

namespace PrintingApplication.Presentation.Presenters.Tentang
{
    public class TentangPresenter : ITentangPresenter
    {
        private ITentangView _view;

        public ITentangView GetView
        {
            get { return _view; }
        }

        public TentangPresenter()
        {
            _view = new TentangView();
        }
    }
}
