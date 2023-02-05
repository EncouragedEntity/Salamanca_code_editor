namespace SourceCodeEditor.Forms
{
    public partial class TemplatesForm : Form
    {
        public TemplatesForm()
        {
            InitializeComponent();
            SetButtonsEvents();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetButtonsEvents()
        {
            foreach (var control in tableLayoutPanel1.Controls)
            {
                if(control is PictureBox)
                {
                    PictureBox picbox = (PictureBox)control;
                    picbox.Click += ButtonClick;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void TemplatesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
