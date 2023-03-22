using FastColoredTextBoxNS;
using Microsoft.VisualBasic.FileIO;
using SourceCodeEditor.Forms.Templates;
using System.Text.Json;

namespace SourceCodeEditor.Forms
{
    public partial class TemplatesForm : Form
    {
        public FastColoredTextBox TextField { get; set; }
        private List<Template> Templates { get; set; }

        public bool IsTemplatesChanged = false;

        public TemplatesForm(FastColoredTextBox textField)
        {
            Templates = Enumerable.Repeat(new Template(), 10).ToList();
            InitializeComponent();
            SetButtonsEvents();
            LoadTemplates();

            TextField = textField;
            IsTemplatesChanged = false;
        }

        private void LoadTemplates()
        {
            foreach (var file in new DirectoryInfo("Templates").GetFiles())
            {
                if (Path.GetExtension(file.Name) == ".json")
                {
                    Template template = new Template();
                    template = JsonSerializer.Deserialize<Template>(File.ReadAllText($"Templates/{file.Name}"))!;
                    Templates[template.Number - 1] = (template);
                    IsTemplatesChanged = true;
                }
            }

            for (int i = 0; i < Templates.Count; i++)
            {
                if (!String.IsNullOrEmpty(Templates[i].Name))
                    GetLabelById(Templates[i].Number - 1)!.Text = Templates[i].Name;
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
            return int.Parse(button.Name.Last().ToString()) - 1;
        }

        public Label? GetLabelById(int id)
        {
            return tableLayoutPanel1.Controls.OfType<Label>().Where(value => value.Name == $"label{id + 1}").FirstOrDefault();
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
            string TemplatePath = $"Templates/Template{templateNumber + 1}.txt";
            if (!File.Exists(TemplatePath))
            {
                TemplateAdd(templateNumber);
                return;
            }

            if (Templates[templateNumber].Language == TextField.Language)
            {
                TextField.InsertText(File.ReadAllText(TemplatePath));
                return;
            }

            MessageBox.Show("Wrong language selected at Main Text Field", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TemplateAdd(int templateNumber)
        {
            string FolderPath = "Templates";
            string TemplateName = $"Template{templateNumber + 1}.txt";
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
            }
        }

        private void TemplateEdit(int templateNumber)
        {
            string FolderPath = "Templates";
            string TemplateName = $"Template{templateNumber + 1}.txt";
            string FilePath = $"{FolderPath}/{TemplateName}";

            var template = new Template();
            template.Name = GetLabelById(templateNumber)!.Text;
            template.Number = templateNumber;
            template.Language = Templates[templateNumber].Language;

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
                        File.Move(txtFile.FullName, $"Templates/Template{j}{txtFile.Extension}");
                    }
                }

                for (int j = 1; j <= jsonFiles.Count; j++)
                {
                    var jsonFile = jsonFiles[j - 1];

                    if (jsonFile.Name != $"Template{j}{jsonFile.Extension}")
                    {
                        File.Move(jsonFile.FullName, $"Templates/Template{j}{jsonFile.Extension}");
                    }
                }
            }
        }

        private void TemplateDelete(int templateNumber)
        {
            string TemplatePath = $"Templates/Template{templateNumber + 1}.txt";
            if (File.Exists(TemplatePath))
            {
                string JsonPath = TemplatePath.Replace("txt", "json");

                FileSystem.DeleteFile(TemplatePath, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                FileSystem.DeleteFile(JsonPath, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                Templates.Remove(Templates.ElementAt(templateNumber));
                IsTemplatesChanged = true;

                GetLabelById(templateNumber)!.Text = $"Template{templateNumber + 1}";
            }

            RenameTemplatesFiles();
            LoadTemplates();
        }
    }
}
