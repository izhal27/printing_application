using PrintingApplication.Domain.Models.Pengaturan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Pengaturan
{
   public partial class PengaturanView : Form, IPengaturanView
   {
      public event EventHandler OnLoadData;
      public event EventHandler OnButtonDefaultClick;
      public event EventHandler OnButtonSaveClick;

      public PropertyGrid PropertyGridPengaturan
      {
         get { return propertyGrid; }
      }

      public PengaturanView()
      {
         InitializeComponent();
      }

      private void PengaturanView_Load(object sender, EventArgs e)
      {
         OnLoadData?.Invoke(sender, e);
         ActiveControl = buttonCancel;
      }


      private void buttonDefault_Click(object sender, EventArgs e)
      {
         OnButtonDefaultClick?.Invoke(sender, e);
      }

      private void buttonSave_Click(object sender, EventArgs e)
      {
         OnButtonSaveClick?.Invoke(sender, e);
      }

      public void ShowView()
      {
         ShowDialog();
      }

      public void CloseView()
      {
         DialogResult = DialogResult.OK;
      }
   }
}
