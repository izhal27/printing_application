using PrintingApplication.Domain.Models.Pelanggan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Pelanggan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pelanggan;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.ModelControls
{
    public partial class ComboBoxPelanggan : UserControl
    {
        public IPelangganModel SelectedItem
        {
            get
            {
                return comboBox.SelectedIndex != -1 ? (IPelangganModel)comboBox.SelectedItem : null;
            }
            set
            {
                if (value != null)
                {
                    comboBox.SelectedItem = comboBox.Items.Cast<IPelangganModel>().Where(t => t.id == value.id).FirstOrDefault();
                }
            }
        }

        public ComboBoxPelanggan()
        {
            InitializeComponent();

            if ((LicenseManager.UsageMode != LicenseUsageMode.Designtime))
            {
                LoadDataSource();
            }
        }

        private void LoadDataSource()
        {
            var services = new PelangganServices(new PelangganRepository(), new ModelDataAnnotationCheck());
            var listPelanggans = services.GetAll().ToList();

            if (listPelanggans != null && listPelanggans.Count > 0)
            {
                comboBox.Items.AddRange(listPelanggans.ToArray());
                comboBox.DisplayMember = "nama";
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
