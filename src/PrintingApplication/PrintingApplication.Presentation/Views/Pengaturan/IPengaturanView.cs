using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Pengaturan
{
   public interface IPengaturanView : IView
   {
      event EventHandler OnLoadData;
      event EventHandler OnButtonDefaultClick;
      event EventHandler OnButtonSaveClick;

      PropertyGrid PropertyGridPengaturan { get; }

      void ShowView();
      void CloseView();
   }
}
