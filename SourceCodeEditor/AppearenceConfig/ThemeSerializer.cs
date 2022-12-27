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
        private CurrentTheme _theme;
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
                label.BackColor = _theme.LabelsBack;
                label.ForeColor = _theme.HeaderFore;
            }
        }
        private void SetColors()
        {
            _header.BackColor = _theme.HeaderBack;
            _header.ForeColor = _theme.HeaderFore;

            _footer.BackColor = _theme.FooterBack;
            _footer.ForeColor = _theme.FooterFore;

            _mainTextField.BackColor = _theme.MainTextFieldBack;
            _mainTextField.ForeColor = _theme.MainTextFieldFore;

            SetLabelsColors();
        }
        
        private void GetLabelsColors()
        {
            var firstLabel = _labels.FirstOrDefault();
            _theme.LabelsFore = firstLabel!.ForeColor;
            _theme.LabelsBack = firstLabel!.BackColor;

        }

        private void GetColors()
        {
            _theme.HeaderBack = _header.BackColor;
            _theme.HeaderFore = _header.ForeColor;

            _theme.FooterBack = _footer.BackColor;
            _theme.FooterFore = _footer.ForeColor;

            _theme.MainTextFieldBack = _mainTextField.BackColor;
            _theme.MainTextFieldFore = _mainTextField.ForeColor;

            GetLabelsColors();  
        }

        private string Serialize()
        {
            GetColors();
            return JsonSerializer.Serialize(_theme, new JsonSerializerOptions { WriteIndented = true });
        }

        private CurrentTheme Deserialize()
        {
            var jsonstring = File.ReadAllText("ColorsConfig.json");
            var theme = JsonSerializer.Deserialize<CurrentTheme>(jsonstring)!;
            return theme;
        }

        public CurrentTheme DeserializeTheme()
        {
            return _theme = Deserialize();
        }

        public void SetColorsOfTheme()
        {
            SetColors();
        }

        public void SerializeTheme()
        {
            File.WriteAllText("ColorsConfig.json", Serialize());
        }
    }
}
