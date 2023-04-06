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
            foreach (var file in new DirectoryInfo("Templates").GetFiles())
            {
                if (Path.GetExtension(file.Name) == ".json")
                {
                    Template template = JsonSerializer.Deserialize<Template>(File.ReadAllText($"Templates/{file.Name}"))!;
                    Templates[template.Number - 1] = (template);
                    IsTemplatesChanged = true;
                }
            }

            for (int i = 0; i < Templates.Count; i++)
            {
                if (!String.IsNullOrEmpty(Templates[i].Name))
                    GetLabelById(Templates[i].Number)!.Text = Templates[i].Name;
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

            if (Templates[templateNumber - 1].Language == TextField.Language)
            {
                TextField.InsertText(File.ReadAllText(TemplatePath));
                return;
            }

            MessageBox.Show("Wrong language selected at Main Text Field", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Templates[templateNumber] = template;
            }
        }

        private void TemplateEdit(int templateNumber)
        {
            string FolderPath = "Templates";
            string TemplateName = $"Template{templateNumber}.txt";
            string FilePath = $"{FolderPath}/{TemplateName}";

            var template = new Template();
            template.Name = GetLabelById(templateNumber)!.Text;
            template.Number = templateNumber;
            template.Language = Templates[templateNumber - 1].Language;

            var editTemplate = new TemplateAddForm(this, template, FilePath, TemplateAddMode.Editing);

            if (editTemplate.ShowDialog() == DialogResult.Yes)
            {
                LoadTemplates();
                IsTemplatesChanged = true;
            }
        }

        private void RenameTemplatesFiles()
        {
            var directory = new DirectoryInfo("Templates");
            var files = directory.GetFiles();

            for (int i = 1; i <= files.Length; i++)
            {
                var txtFiles = files.Where(file => file.Extension == ".txt").ToList();
                var jsonFiles = files.Where(file => file.Extension == ".json").ToList();

                for (int j = 1; j <= txtFiles.Count; j++)
                {
                    var txtFile = txtFiles[j - 1];

                    if (txtFile.Name != $"Template{j}{txtFile.Extension}")
                    {
                        if(!File.Exists($"Templates/Template{j}{txtFile.Extension}"))
                            File.Move(txtFile.FullName, $"Templates/Template{j}{txtFile.Extension}");
                    }
                }

                for (int j = 1; j <= jsonFiles.Count; j++)
                {
                    var jsonFile = jsonFiles[j - 1];

                    if (jsonFile.Name != $"Template{j}{jsonFile.Extension}")
                    {
                        if (!File.Exists($"Templates/Template{j}{jsonFile.Extension}"))
                            File.Move(jsonFile.FullName, $"Templates/Template{j}{jsonFile.Extension}");
                    }
                }
            }
        }

        private void TemplateDelete(int templateNumber)
        {
            string TemplatePath = $"Templates/Template{templateNumber}.txt";
            if (File.Exists(TemplatePath))
            {
                string JsonPath = TemplatePath.Replace("txt", "json");

                FileSystem.DeleteFile(TemplatePath, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                FileSystem.DeleteFile(JsonPath, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                Templates.Remove(Templates.ElementAt(templateNumber - 1));
                IsTemplatesChanged = true;

                GetLabelById(templateNumber)!.Text = $"Template{templateNumber}";
            }

            RenameTemplatesFiles();
            LoadTemplates();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            LoadTemplates();
        }
    }
}
