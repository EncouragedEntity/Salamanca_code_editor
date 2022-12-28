using FastColoredTextBoxNS;

namespace SourceCodeEditor.AppearenceConfig
{
    public class SyntaxColors
    {
        public Tuple<Color, FontStyle> _classNameStyle { get; set; }
        public Tuple<Color, FontStyle> _stringStyle { get; set; }
        public Tuple<Color, FontStyle> _commentStyle { get; set; }
        public Tuple<Color, FontStyle> _commentTagStyle { get; set; }
        public Tuple<Color, FontStyle> _keywordStyle { get; set; }

        public SyntaxColors() : this(Tuple.Create(Color.Transparent,FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular)) { }

        public SyntaxColors(Tuple<Color, FontStyle> className, Tuple<Color, FontStyle> stringStyle, Tuple<Color, FontStyle> commentStyle,
                            Tuple<Color, FontStyle> commentTagStyle, Tuple<Color, FontStyle> keywordStyle)
        {
            _classNameStyle = className;
            _stringStyle = stringStyle;
            _commentStyle = commentStyle;
            _commentTagStyle = commentTagStyle;
            _keywordStyle = keywordStyle;
        }
    }
}
