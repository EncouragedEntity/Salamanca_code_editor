using FastColoredTextBoxNS;

namespace SourceCodeEditor.AppearenceConfig
{
    public class SyntaxColors
    {
        public TextStyle _classNameStyle { get; set; }
        public TextStyle _stringStyle { get; set; }
        public TextStyle _commentStyle { get; set; }
        public TextStyle _commentTagStyle { get; set; }
        public TextStyle _keywordStyle { get; set; }

        public SyntaxColors() : this(null, null, null, null, null) { }

        public SyntaxColors(Style className, Style stringStyle, Style comment, Style commentTag, Style keyword)
        {
            
            _classNameStyle = className as TextStyle;
            _stringStyle = stringStyle as TextStyle;
            _commentStyle = comment as TextStyle;
            _commentTagStyle = commentTag as TextStyle;
            _keywordStyle = keyword as TextStyle;
        }
    }
}
