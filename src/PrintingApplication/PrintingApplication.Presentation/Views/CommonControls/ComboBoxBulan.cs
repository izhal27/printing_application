using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public class ComboBoxBulan : ComboBox
    {
        public ComboBoxBulan()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;

            if ((LicenseManager.UsageMode != LicenseUsageMode.Designtime))
            {
                LoadDataSource();
            }
        }

        private void LoadDataSource()
        {
            DataSource = CultureInfo.CurrentCulture.DateTimeFormat
                               .MonthNames.Take(12).ToList();
        }
    }
}
