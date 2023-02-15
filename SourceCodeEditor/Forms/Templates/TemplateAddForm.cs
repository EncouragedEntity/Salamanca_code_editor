using FastColoredTextBoxNS;

namespace SourceCodeEditor.Forms.Templates
{
    public partial class TemplateAddForm : Form
    {
        private TemplatesForm Form { get; set; }
        private Template Template { get; set; }
        private string FilePath { get; set; }

        public TemplateAddForm(TemplatesForm form, Template template, string filePath)
        {
            InitializeComponent();
            Form = form;
            Template = template;
            FilePath = filePath;

            comboBoxLanguages.Text = Language.Custom.ToString();
        }

        public Template AddTemplate()
        {
            Template.Content = fastColoredTextBox1.Text;
            Template.Name = textBoxName.Text;
            Template.Language = (Language) Enum.Parse(typeof(Language), comboBoxLanguages.SelectedItem.ToString());
            try
            {
                ChangeTemplateLabelText(Form.GetLabelById(Template.Number));
                File.WriteAllText(FilePath, fastColoredTextBox1.Text);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Template;
        }

        public void ChangeTemplateLabelText(Label label)
        {
            label.Text = textBoxName.Text;
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
