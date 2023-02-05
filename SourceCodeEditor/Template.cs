using FastColoredTextBoxNS;

namespace SourceCodeEditor
{
    public class Template
    {
        public string Name { get; set; } = String.Empty;
        public string Content { get; set; } = String.Empty;
        public Language Language { get; set; } = Language.Custom;

        public Template() : this(String.Empty, String.Empty, Language.Custom) { }

        public Template(string content) : this(String.Empty, content, Language.Custom) { }

        public Template(string name, string content, Language language)
        {
            Name = name;
            Content = content;
            Language = language;
        }
    }
}
