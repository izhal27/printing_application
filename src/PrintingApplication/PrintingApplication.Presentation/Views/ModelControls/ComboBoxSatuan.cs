using PrintingApplication.Services.Services;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public partial class ComboBoxSatuan : UserControl
    {
        public ISatuanModel SelectedItem
        {
            get
            {
                return comboBox.SelectedIndex != -1 ? (ISatuanModel)comboBox.SelectedItem : null;
            }
            set
            {
                if (value != null)
                {
                    comboBox.SelectedItem = comboBox.Items.Cast<ISatuanModel>().Where(t => t.id == value.id).FirstOrDefault();
                }
            }
        }

        public ComboBoxSatuan()
        {
            InitializeComponent();

            if ((LicenseManager.UsageMode != LicenseUsageMode.Designtime))
            {
                LoadDataSource();
            }
        }

        private void LoadDataSource()
        {
            var services = new SatuanServices(new SatuanRepository(), new ModelDataAnnotationCheck());
            var listSatuans = services.GetAll().ToList();

            if (listSatuans != null && listSatuans.Count > 0)
            {
                comboBox.Items.AddRange(listSatuans.ToArray());
                comboBox.DisplayMember = "nama";
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
