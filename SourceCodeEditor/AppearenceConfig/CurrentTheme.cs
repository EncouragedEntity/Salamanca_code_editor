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
        public Color _headerBack;
        public Color _headerFore;
        public Color _footerBack;
        public Color _footerFore;
        public Color _mainTextFieldBack;
        public Color _mainTextFieldFore;
        public Color _labelsBack;
        public Color _labelsFore;

        public readonly SyntaxColors syntaxColors;

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
