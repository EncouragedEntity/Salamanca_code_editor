using FastColoredTextBoxNS;
using SourceCodeEditor.AppearenceConfig;
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
                SetFontSizeForEverything();
                return;
            }
            comboBoxLanguages.SelectedIndex = Convert.ToInt32(Language.Custom);
            SetFontSizeForEverything();
        }

        private void SetFontSizeForEverything()
        {
            foreach (Control control in this.Controls)
            {
                control.Font = Form.Font;
                if (control is GroupBox)
                {
                    foreach (Control control1 in control.Controls)
                    {
                        control1.Font = Form.Font;
                    }
                }
            }

            ValidateSize();
        }

        private void ValidateSize()
        {
            if (labelName.Bounds.IntersectsWith(textBoxName.Bounds))
            {
                textBoxName.Location = new Point(labelName.Location.X + labelName.Width, textBoxName.Location.Y);
            }

            if (this.Bounds.IntersectsWith(comboBoxLanguages.Bounds))
            {
                int newFormWidth = comboBoxLanguages.Bounds.Right + comboBoxLanguages.Margin.Right + this.Padding.Right;
                this.Width = newFormWidth;

                if (labelLanguage.Bounds.IntersectsWith(comboBoxLanguages.Bounds))
                {
                    int newLabelX = comboBoxLanguages.Bounds.Left - labelLanguage.Width - labelLanguage.Margin.Right;
                    labelLanguage.Location = new Point(newLabelX, labelLanguage.Location.Y);
                }
            }

            if (textBoxName.Bounds.IntersectsWith(labelLanguage.Bounds))
            {
                this.Width += textBoxName.Bounds.X + textBoxName.Width - labelLanguage.Bounds.X;
            }

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
                ChangeTemplateLabelText(Form.GetLabelById(Template.Number)!, Form.GetLabelById(Template.Number + 10)!);
                File.WriteAllText(FilePath, fastColoredTextBox1.Text);

                string JsonPath = FilePath.Replace("txt", "json");
                File.WriteAllText(JsonPath, JsonSerializer.Serialize(Template, new JsonSerializerOptions() { WriteIndented = true }));
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Template;
        }

        public void ChangeTemplateLabelText(Label labelName, Label labelLang)
        {
            try
            {
                labelName.Text = textBoxName.Text;
                labelLang.Text = comboBoxLanguages.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Change template name!");
            }
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
            ChangeTextBoxStyle();
        }

        private void ChangeTextBoxStyle()
        {
            var sercon = new ContentSerializer("AddFormContent.bin");
            fastColoredTextBox1.ClearStylesBuffer();
            sercon.SerializeContent(fastColoredTextBox1.Text);
            int SelectionStart = fastColoredTextBox1.SelectionStart;
            new ThemeChanger(this.fastColoredTextBox1).SetColorsToHighLighterWhiteManual();
            fastColoredTextBox1.Text = sercon.Deserialize();
            fastColoredTextBox1.SelectionStart = SelectionStart;
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
            if (this.DialogResult != DialogResult.Yes)
                this.DialogResult = DialogResult.No;
        }
    }

}
