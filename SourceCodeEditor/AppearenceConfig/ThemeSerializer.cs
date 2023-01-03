using FastColoredTextBoxNS;
using System.Runtime.Serialization.Formatters.Binary;

namespace SourceCodeEditor.AppearenceConfig
{
    public class ThemeSerializer
    {
        private CurrentTheme _theme;
        private readonly MainForm _form;
        private readonly MenuStrip _header;
        private readonly FastColoredTextBox _mainTextField;
        private readonly StatusStrip _footer;
        private readonly IEnumerable<ToolStripStatusLabel> _labels;

        public ThemeSerializer(CurrentTheme theme, MainForm form)
        {
            _theme = theme;
            _theme.ThemePath = form.theme!.ThemePath;
            _form = form;
            _header = form.MainHeader;
            _mainTextField = form.MainTextField;
            _footer = form.MainFooter;
            _labels = form.GetLabelsFromForm();
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

       /* public void SetColorsOfTheme()
        {
            SetColors();
        }*/

        public static CurrentTheme? DeserializeTheme(string path)
        {
            using (Stream str = File.Open(path, FileMode.Open))
            {
                var bf = new BinaryFormatter();
                return bf.Deserialize(str) as CurrentTheme;
            }
        }

        public void SerializeTheme()
        {
            using (Stream str = File.Open(_theme.ThemePath, FileMode.Create))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(str, _theme);
                str.Close();
            }
        }
    }
}
