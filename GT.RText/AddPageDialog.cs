using System.Windows.Forms;

namespace GT.RText
{
    public partial class AddPageDialog : Form
    {
        public string PageName { get; set; }
        public bool ApplyToAllLocales { get; set; }

        public AddPageDialog(bool isUiProject)
        {
            InitializeComponent();

            if (!isUiProject)
            {
                applyToAllLocalesCheckBox.Visible = false;
            }
        }

        private void pageNameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            PageName = pageNameTextBox.Text;
        }

        private void applyToAllLocalesCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            ApplyToAllLocales = applyToAllLocalesCheckBox.Checked;
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(PageName))
            {
                MessageBox.Show("Page name must be provided.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
