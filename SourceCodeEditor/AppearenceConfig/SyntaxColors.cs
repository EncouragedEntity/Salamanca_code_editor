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
        public readonly Style _classNameStyle;
        public readonly Style _stringStyle;
        public readonly Style _commentStyle;
        public readonly Style _commentTagStyle;
        public readonly Style _keywordStyle;

        public SyntaxColors(Style className, Style stringStyle, Style comment, Style commentTag, Style keyword )
        {
            _classNameStyle = className;
            _stringStyle = stringStyle;
            _commentStyle = comment;
            _commentTagStyle = commentTag;
            _keywordStyle = keyword;
        }
    }
}
