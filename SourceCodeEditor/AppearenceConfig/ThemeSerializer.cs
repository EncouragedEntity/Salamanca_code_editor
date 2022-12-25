using FastColoredTextBoxNS;
using SourceCodeEditor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeEditor.AppearenceConfig
{
    public class ThemeSerializer
    {
        #region elements
        private readonly Theme _theme;
        private readonly MenuStrip _header;
        private readonly FastColoredTextBox _mainTextField;
        private readonly StatusStrip _footer;
        private readonly IEnumerable<ToolStripStatusLabel> _labels;
        #endregion

       

        public ThemeSerializer(Theme theme, MenuStrip header, FastColoredTextBox mainTextField, StatusStrip footer, IEnumerable<ToolStripStatusLabel> labels)
        {
            _theme = theme;
            _header = header;
            _mainTextField = mainTextField;
            _footer = footer;
            _labels = labels;
        }

        private void Serialize()
        {
            
        }

        public void SerializeTheme()
        {
            
        }
    }
}
