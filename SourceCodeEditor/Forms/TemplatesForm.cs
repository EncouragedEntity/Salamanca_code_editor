using FastColoredTextBoxNS;

namespace SourceCodeEditor.Forms
{
    public partial class TemplatesForm : Form
    {
        public TemplatesForm(FastColoredTextBox textField)
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
            var button = (PictureBox)sender;
            int templateNum = int.Parse(button.Name.Last().ToString());

            if (button.Name.Contains("Play"))
            {
                TemplatePlay(templateNum);
                return;
            }
            if (button.Name.Contains("Edit"))
            {
                TemplateEdit(templateNum);
                return;
            }
            if (button.Name.Contains("Delete"))
            {
                TemplateDelete(templateNum);
                return;
            }
        }

        private void TemplatePlay(int templateNumber)
        {
            
        }

        private void TemplateEdit(int templateNumber)
        {

        }

        private void TemplateDelete(int templateNumber)
        {

        }

        private void TemplatesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
