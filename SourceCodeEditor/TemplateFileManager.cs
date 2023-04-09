using System.Text.Json;

namespace SourceCodeEditor
{
    public class TemplateFileManager
    {

        /// <summary>
        /// If there are spaces between templates, clear them and put templates in order
        /// </summary>
        public void RenameTemplatesFiles()
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
                        if (!File.Exists($"Templates/Template{j}{txtFile.Extension}"))
                            File.Move(txtFile.FullName, $"Templates/Template{j}{txtFile.Extension}");
                    }
                }

                for (int j = 1; j <= jsonFiles.Count; j++)
                {
                    var jsonFile = jsonFiles[j - 1];

                    if (jsonFile.Name != $"Template{j}{jsonFile.Extension}")
                    {
                        if (!File.Exists($"Templates/Template{j}{jsonFile.Extension}"))
                        {
                            File.Move(jsonFile.FullName, $"Templates/Template{j}{jsonFile.Extension}");
                        }
                    }

                    var temp = JsonSerializer.Deserialize<Template>(File.ReadAllText($"Templates/Template{j}{jsonFile.Extension}"));
                    temp.Number = j;
                    File.WriteAllText($"Templates/Template{j}{jsonFile.Extension}", JsonSerializer.Serialize(temp));
                }
            }
        }
    }
}
