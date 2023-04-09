using FastColoredTextBoxNS;
using Microsoft.VisualBasic.FileIO;
using SourceCodeEditor.Forms.Templates;
using System.Text.Json;

namespace SourceCodeEditor.Forms
{
    public partial class TemplatesForm : Form
    {
        public FastColoredTextBox TextField { get; set; }
        public Font Font { get; set; }
        private List<Template> Templates { get; set; }
        public bool IsTemplatesChanged = false;

        public TemplatesForm(FastColoredTextBox textField)
        {
            Templates = Enumerable.Repeat(new Template(), 10).ToList();
            InitializeComponent();
            SetButtonsEvents();
            LoadTemplates();

            TextField = textField;

            SetLabelsFontSize();

            IsTemplatesChanged = false;

            new TemplateFileManager().RenameTemplatesFiles();
        }

        private void SetLabelsFontSize()
        {
            Font = new Font(TextField.Font.FontFamily, TextField.Font.Size, TextField.Font.Style);
            foreach (var control in tableLayoutPanel1.Controls)
            {
                if (control is Label)
                {
                    var label = (Label)control;
                    label.Font = Font;
                }
            }
        }

        private void LoadTemplates()
        {
            new TemplateFileManager().RenameTemplatesFiles();

            var tempList = new List<Template>();
            if (!Templates.All(value => value.Number == 0))
            {
                Templates.Clear();
                Templates = Enumerable.Repeat(new Template(), 10).ToList();
            }

            foreach (var file in new DirectoryInfo("Templates").GetFiles().Where(file => file.Extension == ".json"))
            {
                tempList.Add(JsonSerializer.Deserialize<Template>(File.ReadAllText($"Templates/{file.Name}"))!);
            }

            for (int i = 0; i < Templates.Count; i++)
            {
                try
                {
                    Templates[i] = tempList[i];
                }
                catch (ArgumentOutOfRangeException)
                {
                    Templates[i] = new Template(); 
                }
            }

            SetLabelsContent();
        }

        private void SetLabelsContent()
        {
            SetLabelsNameContent();
            SetLabelsLanguageContent();
        }

        private void SetLabelsNameContent()
        {
            for (int i = 0; i < Templates.Count; i++)
            {
                if (!String.IsNullOrEmpty(Templates[i].Name))
                {
                    GetLabelById(Templates[i].Number)!.Text = $"{Templates[i].Name}";
                    continue;
                }

                GetLabelById(i + 1)!.Text = $"Template{i + 1}";
            }
        }

        private void SetLabelsLanguageContent()
        {
            for (int i = 11; i <= 20; i++)
            {
                GetLabelById(i)!.Text = $"{Templates[i - 11].Language}";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetButtonsEvents()
        {
            foreach (var control in tableLayoutPanel1.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox picbox = (PictureBox)control;
                    picbox.Click += ButtonClick!;
                }
            }
        }

        private int GetPictureBoxNumber(PictureBox button)
        {
            int lastDigit = int.Parse(button.Name.Last().ToString());

            int num = lastDigit;
            if (char.IsDigit(button.Name[button.Name.Length - 2]))
            {
                num = 10;
            }
            return num;
        }

        public Label? GetLabelById(int id)
        {
            return tableLayoutPanel1.Controls.OfType<Label>().Where(value => value.Name == $"label{id}").FirstOrDefault();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            var button = (PictureBox)sender;
            int templateNum = GetPictureBoxNumber(button);

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
            string TemplatePath = $"Templates/Template{templateNumber}.txt";
            if (!File.Exists(TemplatePath))
            {
                TemplateAdd(templateNumber);
                return;
            }
            var template = Templates[templateNumber - 1];

            if (template.Language == TextField.Language)
            {
                TextField.InsertText(File.ReadAllText(TemplatePath));
                return;
            }

            MessageBox.Show($"Wrong language selected at Main Text Field.\nYou should select \"{template.Language}\"!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TemplateAdd(int templateNumber)
        {
            string FolderPath = "Templates";
            string TemplateName = $"Template{templateNumber}.txt";
            string FilePath = $"{FolderPath}/{TemplateName}";

            var template = new Template();
            template.Name = TemplateName;
            template.Number = templateNumber;


            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            var addTemplate = new TemplateAddForm(this, template, FilePath);

            if (addTemplate.ShowDialog() == DialogResult.Yes)
            {
                IsTemplatesChanged = true;
                Templates[templateNumber - 1] = template;
            }
        }

        private string GetTemplateNameFromLabel(int templateNumber)
        {
            var text = GetLabelById(templateNumber)!.Text;

            foreach (var value in Enum.GetNames<Language>())
            {
                if (text.Contains("(" + value + ")"))
                {
                    return text.Replace($"({value})", "").Trim();
                }
            }
            return text;
        }

        private void TemplateEdit(int templateNumber)
        {
            string FolderPath = "Templates";
            string TemplateName = $"Template{templateNumber}.txt";
            string FilePath = $"{FolderPath}/{TemplateName}";

            var template = new Template();

            template.Name = GetTemplateNameFromLabel(templateNumber);

            template.Number = templateNumber;
            template.Language = Templates[templateNumber - 1].Language;

            var editTemplate = new TemplateAddForm(this, template, FilePath, TemplateAddMode.Editing);

            if (editTemplate.ShowDialog() == DialogResult.Yes)
            {
                LoadTemplates();
                IsTemplatesChanged = true;
            }
        }

        

        private void TemplateDelete(int templateNumber)
        {
            string TemplatePath = $"Templates/Template{templateNumber}.txt";
            if (File.Exists(TemplatePath))
            {
                string JsonPath = TemplatePath.Replace("txt", "json");
                    try
                    {
                        FileSystem.DeleteFile(TemplatePath, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                        FileSystem.DeleteFile(JsonPath, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                    }
                    catch (FileNotFoundException)
                    {
                    
                    }
                Templates[templateNumber - 1] = new Template($"Template{templateNumber}", templateNumber);
                IsTemplatesChanged = true;

                GetLabelById(templateNumber)!.Text = $"Template{templateNumber}";
            }

            LoadTemplates();
        }

        private void TemplatesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            new TemplateFileManager().RenameTemplatesFiles();
        }
    }
}
