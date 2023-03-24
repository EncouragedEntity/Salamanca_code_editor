using SourceCodeEditor.Enums;

namespace SourceCodeEditor.UserControls
{
    public partial class ThemeOptionsControl : UserControl
    {
        private MainForm? mainForm = null;

        public ThemeOptionsControl(MainForm? mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Set items of comboBox as Theme elements
        /// </summary>
        private void ThemeOptionsControl_Load(object sender, EventArgs e)
        {
            comboBoxThemes.DataSource = Enum.GetNames(typeof(Theme));
        }

        /// <summary>
        /// Actual theme changing
        /// </summary>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            var comboBoxValue = comboBoxThemes.SelectedValue.ToString();
            switch (comboBoxValue)
            {
                case "White":
                    {
                        mainForm.whiteToolStripMenuItem_Click(sender, e);
                    }
                    break;
                case "Black":
                    {
                        mainForm.blackToolStripMenuItem_Click(sender, e);
                    }
                    break;
            }
        }
    }
}
