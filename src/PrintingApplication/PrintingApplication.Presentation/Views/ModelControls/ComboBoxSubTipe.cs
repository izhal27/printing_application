using PrintingApplication.Services.Services;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public partial class ComboBoxSubTipe : UserControl
    {
        public ISubTipeModel SelectedItem
        {
            get
            {
                return comboBox.SelectedIndex != -1 ? (ISubTipeModel)comboBox.SelectedItem : null;
            }
            set
            {
                if (value != null)
                {
                    comboBox.SelectedItem = comboBox.Items.Cast<ISubTipeModel>().Where(st => st.id == value.id).FirstOrDefault();
                }
            }
        }

        public ComboBoxSubTipe()
        {
            InitializeComponent();

            if ((LicenseManager.UsageMode != LicenseUsageMode.Designtime))
            {
                LoadDataSource();
            }
        }

        private void LoadDataSource()
        {
            var services = new SubTipeServices(new SubTipeRepository(), new ModelDataAnnotationCheck());
            var listSubTipes = services.GetAll().ToList();

            if (listSubTipes != null && listSubTipes.Count > 0)
            {
                comboBox.Items.AddRange(listSubTipes.ToArray());
                comboBox.DisplayMember = "nama";
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
