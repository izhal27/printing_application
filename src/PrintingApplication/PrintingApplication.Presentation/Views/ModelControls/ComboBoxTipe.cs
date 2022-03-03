using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.JenisOrderan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.JenisOrderan;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public partial class ComboBoxTipe : UserControl
    {
        public IJenisOrderanModel SelectedItem
        {
            get
            {
                return comboBox.SelectedIndex != -1 ? (IJenisOrderanModel)comboBox.SelectedItem : null;
            }
            set
            {
                if (value != null)
                {
                    comboBox.SelectedItem = comboBox.Items.Cast<IJenisOrderanModel>().Where(t => t.id == value.id).FirstOrDefault();
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
            var services = new JenisOrderanServices(new JenisOrderanRepository(), new ModelDataAnnotationCheck());
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
