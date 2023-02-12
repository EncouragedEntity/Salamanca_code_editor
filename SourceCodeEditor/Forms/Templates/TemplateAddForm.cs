using FastColoredTextBoxNS;

namespace SourceCodeEditor.Forms.Templates
{
    public partial class TemplateAddForm : Form
    {
        private TemplatesForm Form { get; set; }
        private Template Template { get; set; }
        public TemplateAddForm(TemplatesForm form, Template template)
        {
            InitializeComponent();
            Form = form;
            Template = template;
        }

        public Template AddTemplate()
        {
            Template.Content = fastColoredTextBox1.Text;
            Template.Name = textBoxName.Text;
            Template.Language = (Language) Enum.Parse(typeof(Language), comboBoxLanguages.SelectedItem.ToString());
            try
            {
                MainForm.Templates[Template.Number] = Template;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Template;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTemplate();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = (Language)Enum.Parse(typeof(Language), comboBoxLanguages.SelectedItem.ToString());
        }
    }
}
