using FastColoredTextBoxNS;
using SourceCodeEditor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SourceCodeEditor.AppearenceConfig
{
    public class ThemeSerializer
    {
        private readonly CurrentTheme _theme;
        private readonly MenuStrip _header;
        private readonly FastColoredTextBox _mainTextField;
        private readonly StatusStrip _footer;
        private readonly IEnumerable<ToolStripStatusLabel> _labels;

        public ThemeSerializer(CurrentTheme theme, MenuStrip header, FastColoredTextBox mainTextField, StatusStrip footer, IEnumerable<ToolStripStatusLabel> labels)
        {
            _theme = theme;
            _header = header;
            _mainTextField = mainTextField;
            _footer = footer;
            _labels = labels;
        }

        private void SetLabelsColors()
        {
            foreach (var label in _labels)
            {
                label.BackColor = _theme._labelsBack;
                label.ForeColor = _theme._headerFore;
            }
        }

        private void SetColors()
        {
            _header.BackColor = _theme._headerBack;
            _header.ForeColor = _theme._headerFore;

            _footer.BackColor = _theme._footerBack;
            _footer.ForeColor = _theme._footerFore;

            _mainTextField.BackColor = _theme._mainTextFieldBack;
            _mainTextField.ForeColor = _theme._mainTextFieldFore;

            SetLabelsColors();
        }

        private void GetLabelsColors()
        {
            var firstLabel = _labels.FirstOrDefault();
            _theme._labelsFore = firstLabel!.ForeColor;
            _theme._labelsBack = firstLabel!.BackColor;

        }

        private void GetColors()
        {
            _theme._headerBack = _header.BackColor;
            _theme._headerFore = _header.ForeColor;

            _theme._footerBack = _footer.BackColor;
            _theme._footerFore = _footer.ForeColor;

            _theme._mainTextFieldBack = _mainTextField.BackColor;
            _theme._mainTextFieldFore = _mainTextField.ForeColor;

            GetLabelsColors();  
        }

        private string Serialize()
        {
            GetColors();
            return JsonSerializer.Serialize<CurrentTheme>(_theme, new JsonSerializerOptions { WriteIndented = true });
        }

        public void SerializeTheme()
        {
            string JsonText = Serialize();
            File.WriteAllText("ColorsConfig.json",JsonText);
        }
    }
}
