using SourceCodeEditor.AppearenceConfig;
using System.Reflection;

namespace SourceCodeEditor.UserControls.Options
{
    public partial class SyntaxColorsOptionsControl : UserControl
    {
        private MainForm _mainForm { get; set; }
        private SyntaxColors _syntaxColors { get; set; }

        private List<PropertyInfo> Properties { get; set; }
        private List<Color> Colors { get; set; }
        private List<FontStyle> FontStyles { get; set; }
        public SyntaxColorsOptionsControl(MainForm form)
        {
            _mainForm = form;
            _syntaxColors = _mainForm.theme.syntaxColors!;
            Properties = _syntaxColors.GetType().GetProperties().ToList();
            Colors = new List<Color>();
            FontStyles = new List<FontStyle>();
            InitializeComponent();
        }

        private void SetButtonsColors()
        {

            foreach (var property in Properties)
            {
                var value = (Tuple<Color, FontStyle>)property.GetValue(_syntaxColors)!;
                Colors.Add(value.Item1);
            }

            var buttons = tableLayoutPanel1.Controls.OfType<Button>().ToList();

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].BackColor = Colors[i];
            }
        }
        private void SetFontStyles()
        {

            foreach (var property in Properties)
            {
                var value = (Tuple<Color, FontStyle>)property.GetValue(_syntaxColors)!;
                FontStyles.Add(value.Item2);
            }

            var fontStyleControls = tableLayoutPanel1.Controls.OfType<FontStyleControl>().ToList();

            for (int i = 0; i < fontStyleControls.Count; i++)
            {
                fontStyleControls[i].SetFontStyle(FontStyles[i]);
            }
        }

        private void SyntaxColorsOptionsControl_Load(object sender, EventArgs e)
        {
            SetButtonsColors();
            SetFontStyles();
        }
    }
}
