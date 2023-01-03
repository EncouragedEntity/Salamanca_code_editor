namespace SourceCodeEditor.UserControls
{
    public partial class GeneralOptionsControl : UserControl
    {
        public MainForm MainForm { get; set; }

        public GeneralOptionsControl(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void GeneralOptionsControl_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = MainForm.DefaultZoom;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MainForm.DefaultZoom = Convert.ToInt32(numericUpDown1.Value);
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            GeneralOptionsControl_Load(sender, e);
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave_Click(sender,e);
            }
        }

        private void buttonToHundred_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 100;
            numericUpDown1.Focus();
        }
    }
}
