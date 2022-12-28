using FastColoredTextBoxNS;
namespace SourceCodeEditor.AppearenceConfig
{
    public class SyntaxColors
    {
        public Tuple<Color, FontStyle> ClassNameStyle { get; set; }
        public Tuple<Color, FontStyle> AttributeStyle { get; set; }
        public Tuple<Color, FontStyle> AttributeValueStyle { get; set; }
        public Tuple<Color, FontStyle> HtmlEntityStyle { get; set; }
        public Tuple<Color, FontStyle> FunctionsStyle { get; set; }
        public Tuple<Color, FontStyle> StringStyle { get; set; }
        public Tuple<Color, FontStyle> CommentStyle { get; set; }
        public Tuple<Color, FontStyle> CommentTagStyle { get; set; }
        public Tuple<Color, FontStyle> KeywordStyle { get; set; }
        public Tuple<Color, FontStyle> KeywordStyle2 { get; set; }
        public Tuple<Color, FontStyle> KeywordStyle3 { get; set; }
        public Tuple<Color, FontStyle> VariableStyle { get; set; }
        public Tuple<Color, FontStyle> TypesStyle { get; set; }
        public Tuple<Color, FontStyle> NumberStyle { get; set; }
        public Tuple<Color, FontStyle> StatementsStyle { get; set; }
        public Tuple<Color, FontStyle> TagBracketStyle { get; set; }
        public Tuple<Color, FontStyle> TagNameStyle { get; set; }

        public Tuple<Color, FontStyle> XmlEntityStyle { get; set; }
        public Tuple<Color, FontStyle> XmlAttributeStyle { get; set; }
        public Tuple<Color, FontStyle> XmlAttributeValueStyle { get; set; }
        public Tuple<Color, FontStyle> XmlCDataStyle { get; set; }
        public Tuple<Color, FontStyle> XmlTagBracketStyle { get; set; }
        public Tuple<Color, FontStyle> XmlTagNameStyle { get; set; }



        
        public SyntaxColors() : this(Tuple.Create(Color.Transparent,FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
                                     Tuple.Create(Color.Transparent, FontStyle.Regular)) { }

        public SyntaxColors(Tuple<Color, FontStyle> className, Tuple<Color, FontStyle> stringStyle, Tuple<Color, FontStyle> commentStyle,
                            Tuple<Color, FontStyle> commentTagStyle, Tuple<Color, FontStyle> keywordStyle, Tuple<Color, FontStyle> keywordStyle2,
                            Tuple<Color, FontStyle> keywordStyle3, Tuple<Color, FontStyle> attributeStyle, Tuple<Color, FontStyle> attributeValueStyle,
                            Tuple<Color, FontStyle> htmlEntityStyle, Tuple<Color, FontStyle> functionStyle, Tuple<Color, FontStyle> variableStyle,
                            Tuple<Color, FontStyle> typesStyle, Tuple<Color, FontStyle> numberStyle, Tuple<Color, FontStyle> statementsStyle,
                            Tuple<Color, FontStyle> tagBracketStyle, Tuple<Color, FontStyle> tagNameStyle, Tuple<Color, FontStyle> xmlEntityStyle,
                            Tuple<Color, FontStyle> xmlAttributeStyle, Tuple<Color, FontStyle> xmlAttributeValueStyle,
                            Tuple<Color, FontStyle> xmlCDataStyle, Tuple<Color, FontStyle> xmlTagBracketStyle, Tuple<Color, FontStyle> xmlTagNameSTyle)
        {
            ClassNameStyle = className;
            StringStyle = stringStyle;
            CommentStyle = commentStyle;
            CommentTagStyle = commentTagStyle;
            KeywordStyle = keywordStyle;
            KeywordStyle2 = keywordStyle2;
            KeywordStyle3 = keywordStyle3;
            AttributeStyle = attributeStyle;
            AttributeValueStyle = attributeValueStyle;
            HtmlEntityStyle = htmlEntityStyle;
            FunctionsStyle = functionStyle;
            VariableStyle = variableStyle;
            TypesStyle = typesStyle;
            NumberStyle = numberStyle;
            StatementsStyle = statementsStyle;
            TagBracketStyle = tagBracketStyle;
            TagNameStyle = tagNameStyle;
            XmlEntityStyle = xmlEntityStyle;
            XmlAttributeStyle = xmlAttributeStyle;
            XmlCDataStyle = xmlCDataStyle;
            XmlAttributeValueStyle = xmlAttributeValueStyle;
            XmlTagBracketStyle = xmlTagBracketStyle;
            XmlTagNameStyle = xmlTagNameSTyle;
        }
    }
}
