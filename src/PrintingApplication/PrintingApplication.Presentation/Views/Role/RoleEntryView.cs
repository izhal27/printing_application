using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.Role
{
   public partial class RoleEntryView : BaseEntryView, IRoleEntryView
   {
      private bool _isNewData;
      private IRoleModel _model;
      public event EventHandler OnSaveData;
      private static string _typeName = "Role";

      public RoleEntryView(bool isNewData = true, IRoleModel model = null)
      {
         InitializeComponent();
         _isNewData = isNewData;
         panelUp.LabelInfo = isNewData ? $"TAMBAH {_typeName.ToUpper()}" : $"UBAH {_typeName.ToUpper()}";

         if (!_isNewData)
         {
            _model = model;
            textBoxKode.Text = _model.kode;
            textBoxNama.Text = _model.nama;
            textBoxKeterangan.Text = _model.keterangan;
         }

         operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
      }

      private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
      {
         var model = new RoleModel
         {
            kode = textBoxKode.Text,
            nama = textBoxNama.Text,
            keterangan = textBoxKeterangan.Text
         };

         var modelArgs = new ModelEventArgs<RoleModel>(model);

         if (_isNewData)
         {
            if (Messages.ConfirmSave(_typeName))
            {
               OnSaveData?.Invoke(this, modelArgs);
            }
         }
         else if (Messages.ConfirmUpdate(_typeName))
         {
            model.id = _model.id;
            OnSaveData?.Invoke(this, modelArgs);
         }
      }
   }
}
