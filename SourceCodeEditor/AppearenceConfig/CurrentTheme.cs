using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SourceCodeEditor.AppearenceConfig
{
    public class CurrentTheme
    {
        public Color HeaderBack { get; set; } = Color.AliceBlue;
        public Color HeaderFore { get; set; }
        public Color FooterBack { get; set; }
        public Color FooterFore { get; set; }
        public Color MainTextFieldBack { get; set; }
        public Color MainTextFieldFore { get; set; }
        public Color LabelsBack { get; set; }
        public Color LabelsFore { get; set; }

        public SyntaxColors? syntaxColors { get; set; }
        
        public CurrentTheme() : this(Color.AliceBlue, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent,
                                     Color.Transparent, Color.Transparent, Color.Transparent, null) { }
        
        public CurrentTheme(Color headerBack, Color headerFore, Color footerBack, Color footerFore,
                            Color mainBack, Color mainFore, Color labelsBack, Color labelsFore, SyntaxColors? syntax)
        {
            HeaderBack = headerBack;
            HeaderFore = headerFore;
            FooterBack = footerBack;
            FooterFore = footerFore;
            MainTextFieldBack = mainBack;
            MainTextFieldFore = mainFore;
            LabelsBack = labelsBack;
            LabelsFore = labelsFore;
            syntaxColors = syntax;
        }
    }
}
