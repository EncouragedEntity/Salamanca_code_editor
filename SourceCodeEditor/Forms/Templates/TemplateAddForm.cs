using FastColoredTextBoxNS;
using System.Linq;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

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
                this.Text = "Edit template";
                buttonAdd.Text = "Save";
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
            Template.Language = (Language)comboBoxLanguages.SelectedIndex;
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
            DeleteEmptyLines();
            AddTemplate();
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = (Language)Enum.Parse(typeof(Language), comboBoxLanguages.SelectedItem.ToString());
        }

        private void DeleteEmptyLines()
        {
            // Get the text from the FastColoredTextBox control
            string text = fastColoredTextBox1.Text;

            // Split the text into lines
            string[] lines = text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            // Loop through the lines from the start to find the first non-empty line
            int start = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    start = i;
                    break;
                }
            }

            // Loop through the lines from the end to find the last non-empty line
            int end = lines.Length - 1;
            for (int i = lines.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    end = i;
                    break;
                }
            }

            // Extract the non-empty lines between the start and end indexes
            string[] trimmedLines = new string[end - start + 1];
            Array.Copy(lines, start, trimmedLines, 0, trimmedLines.Length);

            // Join the trimmed lines back into a single string
            string trimmedText = string.Join(Environment.NewLine, trimmedLines);

            // Set the trimmed text back into the FastColoredTextBox control
            fastColoredTextBox1.Text = trimmedText;


            /*
            // Get the number of lines in the control
            int lineCount = fastColoredTextBox1.LinesCount;

            // Create a new list to hold the non-empty lines
            List<string> nonEmptyLines = new List<string>();

            // Loop through all lines in the control
            for (int i = 0; i < lineCount; i++)
            {
                // Get the text of the current line
                string lineText = fastColoredTextBox1.GetLineText(i);

                // If the line is not empty, add it to the nonEmptyLines list
                if (!string.IsNullOrWhiteSpace(lineText))
                {
                    nonEmptyLines.Add(lineText);
                }
            }

            // Clear the control
            fastColoredTextBox1.Clear();

            // Add the non-empty lines back to the control
            fastColoredTextBox1.Text = string.Join("\n", nonEmptyLines);
            */
        }

        private void fastColoredTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int MaxLines = 100;

            if (fastColoredTextBox1.LinesCount > MaxLines)
            {
                var lines = new List<string>(fastColoredTextBox1.Lines);

                while (lines.Count > MaxLines)
                {
                    lines.RemoveAt(lines.Count - 1);
                }

                fastColoredTextBox1.Text = string.Join(Environment.NewLine, lines);

                fastColoredTextBox1.SelectionStart = fastColoredTextBox1.LinesCount - 1;
            }
        }

        private void TemplateAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }

}
