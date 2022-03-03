using PrintingApplication.Services.Services;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public partial class ComboBoxTipe : UserControl
    {
        public ITipeModel SelectedItem
        {
            get
            {
                return comboBox.SelectedIndex != -1 ? (ITipeModel)comboBox.SelectedItem : null;
            }
            set
            {
                if (value != null)
                {
                    comboBox.SelectedItem = comboBox.Items.Cast<ITipeModel>().Where(t => t.id == value.id).FirstOrDefault();
                }
            }
        }

        public ComboBoxTipe()
        {
            InitializeComponent();

            if ((LicenseManager.UsageMode != LicenseUsageMode.Designtime))
            {
                LoadDataSource();
            }
        }

        private void LoadDataSource()
        {
            var services = new TipeServices(new TipeRepository(), new ModelDataAnnotationCheck());
            var listTipes = services.GetAll().ToList();

            if (listTipes != null && listTipes.Count > 0)
            {
                comboBox.Items.AddRange(listTipes.ToArray());
                comboBox.DisplayMember = "nama";
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
