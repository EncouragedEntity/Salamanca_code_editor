using FastColoredTextBoxNS;

namespace SourceCodeEditor
{
    public class Template
    {
        public int Number { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Content { get; set; } = String.Empty;
        public Language Language { get; set; } = Language.Custom;

        public Template() : this(0, String.Empty, String.Empty, Language.Custom) { }

        public Template(string content) : this(0, String.Empty, content, Language.Custom) { }

        public Template(int number, string name, string content, Language language)
        {
            Number = number;
            Name = name;
            Content = content;
            Language = language;
        }
    }
}
