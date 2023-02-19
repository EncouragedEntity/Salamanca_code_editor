using FastColoredTextBoxNS;
using System.Text.Json;

namespace SourceCodeEditor.Forms.Templates
{
    public partial class TemplateAddForm : Form
    {
        
        private TemplatesForm Form { get; set; }
        private Template Template { get; set; }
        private string FilePath { get; set; }

        public TemplateAddForm(TemplatesForm form, Template template, string filePath, TemplateAddMode mode = TemplateAddMode.Addition)
        {
            InitializeComponent();
            Form = form;
            Template = template;

            FilePath = filePath;

            if (mode == TemplateAddMode.Editing)
            {
                try
                {
                    if (File.Exists(FilePath))
                        SetDefaultValues(Template);
                    else
                        SetDefaultValues(new Template()); 
                }
                catch (FileNotFoundException)
                {
                    
                }
                return;
            }
            comboBoxLanguages.SelectedIndex = Convert.ToInt32(Language.Custom);
        }

        private void SetDefaultValues(Template temp)
        {
            comboBoxLanguages.SelectedItem = temp.Language.ToString();
            fastColoredTextBox1.Text = File.ReadAllText(FilePath);
            textBoxName.Text = temp.Name;
            fastColoredTextBox1.Language = temp.Language;
        }

        public Template AddTemplate()
        {
            Template.Name = textBoxName.Text;
            Template.Language = (Language) comboBoxLanguages.SelectedIndex;
            try
            {
                    ChangeTemplateLabelText(Form.GetLabelById(Template.Number));
                    File.WriteAllText(FilePath, fastColoredTextBox1.Text);

                    string JsonPath = FilePath.Replace("txt", "json");
                    Template.Number++;
                    File.WriteAllText(JsonPath, JsonSerializer.Serialize(Template, new JsonSerializerOptions() { WriteIndented = true }));
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
