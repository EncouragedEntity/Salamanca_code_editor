using FastColoredTextBoxNS;
namespace SourceCodeEditor.AppearenceConfig
{
    [Serializable]
    public class SyntaxColors
    {
        public string SyntaxPath = "BlackSyntax.syn";

        public Tuple<Color, FontStyle> AttributeStyle { get; set; }
        public Tuple<Color, FontStyle> AttributeValueStyle { get; set; }

        public Tuple<Color, FontStyle> ClassNameStyle { get; set; }
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

        #region Constructors
        public SyntaxColors() : this(Tuple.Create(Color.Transparent, FontStyle.Regular), Tuple.Create(Color.Transparent, FontStyle.Regular),
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
                                     Tuple.Create(Color.Transparent, FontStyle.Regular))
        { SyntaxPath = "BlackSyntax.syn"; }

        public SyntaxColors(Tuple<Color, FontStyle> className, Tuple<Color, FontStyle> stringStyle, Tuple<Color, FontStyle> commentStyle,
                            Tuple<Color, FontStyle> commentTagStyle, Tuple<Color, FontStyle> keywordStyle, Tuple<Color, FontStyle> keywordStyle2,
                            Tuple<Color, FontStyle> keywordStyle3, Tuple<Color, FontStyle> attributeStyle, Tuple<Color, FontStyle> attributeValueStyle,
                            Tuple<Color, FontStyle> htmlEntityStyle, Tuple<Color, FontStyle> functionStyle, Tuple<Color, FontStyle> variableStyle,
                            Tuple<Color, FontStyle> typesStyle, Tuple<Color, FontStyle> numberStyle, Tuple<Color, FontStyle> statementsStyle,
                            Tuple<Color, FontStyle> tagBracketStyle, Tuple<Color, FontStyle> tagNameStyle, Tuple<Color, FontStyle> xmlEntityStyle,
                            Tuple<Color, FontStyle> xmlAttributeStyle, Tuple<Color, FontStyle> xmlAttributeValueStyle,
                            Tuple<Color, FontStyle> xmlCDataStyle, Tuple<Color, FontStyle> xmlTagBracketStyle, Tuple<Color, FontStyle> xmlTagNameSTyle)
        {
            SyntaxPath = "BlackSyntax.syn";

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
        #endregion

        public void SetColorsToHighlighter(FastColoredTextBox textBox)
        {
            string Text = textBox.Text;
            textBox.Text = String.Empty;
            int SelectionStart = textBox.SelectionStart;

            textBox.ClearStylesBuffer();
            textBox.SyntaxHighlighter.ClassNameStyle = new TextStyle(new SolidBrush(ClassNameStyle.Item1), null, ClassNameStyle.Item2);
            textBox.SyntaxHighlighter.StringStyle = new TextStyle(new SolidBrush(StringStyle.Item1), null, StringStyle.Item2);
            textBox.SyntaxHighlighter.CommentStyle = new TextStyle(new SolidBrush(CommentStyle.Item1), null, CommentStyle.Item2);
            textBox.SyntaxHighlighter.CommentTagStyle = new TextStyle(new SolidBrush(CommentTagStyle.Item1), null, CommentTagStyle.Item2);
            textBox.SyntaxHighlighter.KeywordStyle = new TextStyle(new SolidBrush(KeywordStyle.Item1), null, KeywordStyle.Item2);
            textBox.SyntaxHighlighter.KeywordStyle2 = new TextStyle(new SolidBrush(KeywordStyle2.Item1), null, KeywordStyle2.Item2);
            textBox.SyntaxHighlighter.KeywordStyle3 = new TextStyle(new SolidBrush(KeywordStyle3.Item1), null, KeywordStyle3.Item2);
            textBox.SyntaxHighlighter.AttributeStyle = new TextStyle(new SolidBrush(AttributeStyle.Item1), null, AttributeStyle.Item2);
            textBox.SyntaxHighlighter.AttributeValueStyle = new TextStyle(new SolidBrush(AttributeValueStyle.Item1), null, AttributeValueStyle.Item2);
            textBox.SyntaxHighlighter.FunctionsStyle = new TextStyle(new SolidBrush(FunctionsStyle.Item1), null, FunctionsStyle.Item2);
            textBox.SyntaxHighlighter.HtmlEntityStyle = new TextStyle(new SolidBrush(HtmlEntityStyle.Item1), null, HtmlEntityStyle.Item2);
            textBox.SyntaxHighlighter.XmlEntityStyle = new TextStyle(new SolidBrush(XmlEntityStyle.Item1), null, XmlEntityStyle.Item2);
            textBox.SyntaxHighlighter.NumberStyle = new TextStyle(new SolidBrush(NumberStyle.Item1), null, NumberStyle.Item2);
            textBox.SyntaxHighlighter.StatementsStyle = new TextStyle(new SolidBrush(StatementsStyle.Item1), null, StatementsStyle.Item2);
            textBox.SyntaxHighlighter.TagBracketStyle = new TextStyle(new SolidBrush(TagBracketStyle.Item1), null, TagBracketStyle.Item2);
            textBox.SyntaxHighlighter.TagNameStyle = new TextStyle(new SolidBrush(TagNameStyle.Item1), null, TagNameStyle.Item2);
            textBox.SyntaxHighlighter.TypesStyle = new TextStyle(new SolidBrush(TypesStyle.Item1), null, TypesStyle.Item2);
            textBox.SyntaxHighlighter.VariableStyle = new TextStyle(new SolidBrush(VariableStyle.Item1), null, VariableStyle.Item2);
            textBox.SyntaxHighlighter.XmlAttributeStyle = new TextStyle(new SolidBrush(XmlAttributeStyle.Item1), null, XmlAttributeStyle.Item2);
            textBox.SyntaxHighlighter.XmlAttributeValueStyle = new TextStyle(new SolidBrush(XmlAttributeValueStyle.Item1),
                                                                             null, XmlAttributeValueStyle.Item2);
            textBox.SyntaxHighlighter.XmlCDataStyle = new TextStyle(new SolidBrush(XmlCDataStyle.Item1), null, XmlCDataStyle.Item2);
            textBox.SyntaxHighlighter.XmlTagBracketStyle = new TextStyle(new SolidBrush(XmlTagBracketStyle.Item1),
                                                                         null, XmlTagBracketStyle.Item2);
            textBox.SyntaxHighlighter.XmlTagNameStyle = new TextStyle(new SolidBrush(XmlTagNameStyle.Item1), null, XmlTagNameStyle.Item2);

            textBox.Text = Text;
            textBox.SelectionStart = SelectionStart;
        }
    }
}
