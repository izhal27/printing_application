using PrintingApplication.Services.Services;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public partial class ComboBoxSupplier : UserControl
    {
        public ISupplierModel SelectedItem
        {
            get
            {
                return comboBox.SelectedIndex != -1 ? (ISupplierModel)comboBox.SelectedItem : null;
            }
            set
            {
                if (value != null)
                {
                    comboBox.SelectedItem = comboBox.Items.Cast<ISupplierModel>().Where(t => t.id == value.id).FirstOrDefault();
                }
            }
        }

        public ComboBoxSupplier()
        {
            InitializeComponent();

            if ((LicenseManager.UsageMode != LicenseUsageMode.Designtime))
            {
                LoadDataSource();
            }
        }

        private void LoadDataSource()
        {
            var services = new SupplierServices(new SupplierRepository(), new ModelDataAnnotationCheck());
            var listSuppliers = services.GetAll().ToList();

            if (listSuppliers != null && listSuppliers.Count > 0)
            {
                comboBox.Items.AddRange(listSuppliers.ToArray());
                comboBox.DisplayMember = "nama";
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
