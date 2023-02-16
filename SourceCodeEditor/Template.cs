using FastColoredTextBoxNS;

namespace SourceCodeEditor
{
    public class Template
    {
        public int Number { get; set; }
        public string Name { get; set; } = String.Empty;
        public Language Language { get; set; } = Language.Custom;

        public Template() : this(0, String.Empty, Language.Custom) { }

        public Template(int number, string name, Language language)
        {
            Number = number;
            Name = name;
            Language = language;
        }
    }
}
