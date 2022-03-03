using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Role;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Role;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public partial class ComboBoxRole : UserControl
    {
        public IRoleModel SelectedItem
        {
            get
            {
                return comboBox.SelectedIndex != -1 ? (IRoleModel)comboBox.SelectedItem : null;
            }
            set
            {
                if (value != null)
                {
                    comboBox.SelectedItem = comboBox.Items.Cast<IRoleModel>()
                                            .Where(t => t.kode.Equals(value.kode)).FirstOrDefault();
                }
            }
        }

        public ComboBoxRole()
        {
            InitializeComponent();

            if ((LicenseManager.UsageMode != LicenseUsageMode.Designtime))
            {
                LoadDataSource();
            }
        }

        private void LoadDataSource()
        {
            var services = new RoleServices(new RoleRepository(), new ModelDataAnnotationCheck());
            var listRoles = services.GetAll().ToList();

            if (listRoles != null && listRoles.Count > 0)
            {
                comboBox.Items.AddRange(listRoles.ToArray());
                comboBox.DisplayMember = "nama";
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
