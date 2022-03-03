using System;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Views.CommonControls
{
    public partial class DetailView : BaseDataView
    {
        private object _lastColumnFill;

        public event EventHandler OnLoadView;
        public event EventHandler OnButtonCetakClick;

        public ListDataGrid ListDataGrid
        {
            get { return listDataGrid; }
        }

        public DetailView()
        {
            InitializeComponent();
        }

        public DetailView(string textTitle, bool buttonCetakVisible = true) : this()
        {
            Text = textTitle;
            panelUp.LabelInfo = $"{Text.ToUpper()}";
            buttonCetak.Visible = buttonCetakVisible;
        }

        public DetailView(string textTitle, object lastColumnFill, bool buttonCetakVisible = true) : this()
        {
            Text = textTitle;
            _lastColumnFill = lastColumnFill;
            panelUp.LabelInfo = $"{Text.ToUpper()}";
            buttonCetak.Visible = buttonCetakVisible;
        }

        private void DetailView_Load(object sender, EventArgs e)
        {
            OnLoadView?.Invoke(sender, e);

            if (_lastColumnFill != null)
            {
                listDataGrid.SetLastColumnFill(_lastColumnFill);
            }

            ActiveControl = buttonTutup;
        }

        private void DetailView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:

                    Close();

                    break;
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            OnButtonCetakClick?.Invoke(this, e);
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
