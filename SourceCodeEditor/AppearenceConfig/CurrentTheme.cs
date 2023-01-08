namespace SourceCodeEditor.AppearenceConfig
{
    [Serializable]
    public class CurrentTheme
    {
        public string ThemePath = "BlackTheme.theme";

        public Color HeaderBack { get; set; }
        public Color HeaderFore { get; set; }
        public Color FooterBack { get; set; }
        public Color FooterFore { get; set; }
        public Color MainTextFieldBack { get; set; }
        public Color MainTextFieldFore { get; set; }
        public Color MainTextFieldIndentBack { get; set; }
        public Color MainTextFieldLineNumber { get; set; }
        public Color LabelsBack { get; set; }
        public Color LabelsFore { get; set; }

        public SyntaxColors? syntaxColors { get; set; }
        
        public CurrentTheme() : this(Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent,
                                     Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, 
                                     null) { }
        
        public CurrentTheme(Color headerBack, Color headerFore, Color footerBack, Color footerFore,
                            Color mainBack, Color mainFore,Color mainIndentBack, Color mainLineNumber, 
                            Color labelsBack, Color labelsFore, SyntaxColors? syntax)
        {
            HeaderBack = headerBack;
            HeaderFore = headerFore;
            FooterBack = footerBack;
            FooterFore = footerFore;
            MainTextFieldBack = mainBack;
            MainTextFieldFore = mainFore;
            MainTextFieldIndentBack = mainIndentBack;
            MainTextFieldLineNumber = mainLineNumber;
            LabelsBack = labelsBack;
            LabelsFore = labelsFore;
            syntaxColors = syntax;
        }
    }
}
