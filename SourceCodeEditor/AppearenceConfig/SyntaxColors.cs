using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeEditor.AppearenceConfig
{
    public class SyntaxColors
    {
        public readonly TextStyle _classNameStyle;
        public readonly TextStyle _stringStyle;
        public readonly TextStyle _commentStyle;
        public readonly TextStyle _commentTagStyle;
        public readonly TextStyle _keywordStyle;

        public SyntaxColors(TextStyle className, TextStyle stringStyle, TextStyle comment, TextStyle commentTag, TextStyle keyword )
        {
            _classNameStyle= className;
            _stringStyle= stringStyle;
            _commentStyle= comment;
            _commentTagStyle= commentTag;
            _keywordStyle= keyword;
        }
    }
}
