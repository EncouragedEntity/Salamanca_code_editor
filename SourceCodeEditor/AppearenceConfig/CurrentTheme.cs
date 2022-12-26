using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeEditor.AppearenceConfig
{
    public class CurrentTheme
    {
        public Color _headerBack { get; set; }
        public Color _headerFore { get; set; }
        public Color _footerBack { get; set; }
        public Color _footerFore { get; set; }
        public Color _mainTextFieldBack { get; set; }
        public Color _mainTextFieldFore { get; set; }
        public Color _labelsBack { get; set; }
        public Color _labelsFore { get; set; }

        public SyntaxColors syntaxColors { get; set; }

        public CurrentTheme() : this(Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent,
                                     Color.Transparent, Color.Transparent, Color.Transparent, null) { }

        public CurrentTheme(Color headerBack, Color headerFore, Color footerBack, Color footerFore,
                            Color mainBack, Color mainFore, Color labelsBack, Color labelsFore, SyntaxColors syntax)
        {
            _headerBack = headerBack;
            _headerFore = headerFore;
            _footerBack = footerBack;
            _footerFore = footerFore;
            _mainTextFieldBack = mainBack;
            _mainTextFieldFore = mainFore;
            _labelsBack = labelsBack;
            _labelsFore = labelsFore;
            syntaxColors = syntax;
        }
    }
}
