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
            #region Zoom
            numericUpDownDefaultZoom.Value = MainForm.DefaultZoom;
            numericUpDownActualZoom.Value = MainForm.MainTextField.Zoom;
            #endregion
            #region Font
            numericUpDownFontSize.Value = Convert.ToDecimal(MainForm.MainTextField.Font.Size);
            #endregion
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            #region Zoom
            MainForm.DefaultZoom = Convert.ToInt32(numericUpDownDefaultZoom.Value);
            MainForm.MainTextField.Zoom = Convert.ToInt32(numericUpDownActualZoom.Value);
            #endregion
            #region Font
            MainForm.SetFontSizeForEverything(float.Parse(numericUpDownFontSize.Value.ToString()));
            #endregion

        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            GeneralOptionsControl_Load(sender, e);
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave_Click(sender, e);
            }
        }

        private void buttonToHundred_Click(object sender, EventArgs e)
        {
            numericUpDownDefaultZoom.Value = 100;
            numericUpDownDefaultZoom.Focus();
        }

        private void buttonToDefault_Click(object sender, EventArgs e)
        {
            numericUpDownActualZoom.Value = numericUpDownDefaultZoom.Value;
            numericUpDownActualZoom.Focus();
        }


    }
}
