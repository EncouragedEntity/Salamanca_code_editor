using SourceCodeEditor.AppearenceConfig;
using System.Reflection;

namespace SourceCodeEditor.UserControls.Options
{
    public partial class SyntaxColorsOptionsControl : UserControl
    {
        private MainForm _mainForm { get; set; }
        private SyntaxColors? _syntaxColors { get; set; }
        private string _defaultSyntax { get; set; } = String.Empty;

        private List<PropertyInfo> Properties { get; set; }
        private List<Color> Colors { get; set; }
        private List<FontStyle> FontStyles { get; set; }

        public SyntaxColorsOptionsControl(MainForm form)
        {
            _mainForm = form;
            _syntaxColors = _mainForm.theme.syntaxColors!;
            _defaultSyntax = form.CurrentTheme == Enums.Theme.Black ? "SyntaxColors/BlackSyntaxDefault.syn" : "SyntaxColors/WhiteSyntaxDefault.syn";

            Properties = _syntaxColors.GetType().GetProperties().ToList();
            Colors = new List<Color>(23);
            Colors = Enumerable.Repeat(new Color(), 23).ToList();

            FontStyles = new List<FontStyle>();
            InitializeComponent();
            SetButtonsEvents();
        }

        private void SetButtonsColors()
        {
            for (int i = 0; i < Properties.Count; i++)
            {
                var property = Properties[i];
                var value = (Tuple<Color, FontStyle>)property.GetValue(_syntaxColors)!;

                Colors[i] = value.Item1;
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

        private SyntaxColors GetSyntaxColors()
        {
            var syntaxColors = new SyntaxColors();
            var buttons = tableLayoutPanel1.Controls.OfType<Button>().ToList();
            var fontStyleControls = tableLayoutPanel1.Controls.OfType<FontStyleControl>().ToList();

            for (int i = 0; i < Properties.Count; i++)
            {
                var property = Properties[i];
                property.SetValue(syntaxColors, Tuple.Create(buttons[i].BackColor, fontStyleControls[i].GetFontStyle()));
            }

            return syntaxColors;
        }

        private void SetButtonsEvents()
        {
            foreach (var button in tableLayoutPanel1.Controls.OfType<Button>())
            {
                button.Click += buttonColor_Click;
            }
        }

        private void SetCurrentButtonColorToColorDialog(Button sender)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.Color = sender.BackColor;
        }

        private void buttonColor_Click(object? sender, EventArgs e)
        {
            var obj = (Button)sender!;
            SetCurrentButtonColorToColorDialog(obj);
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                obj.BackColor = colorDialog1.Color;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SyntaxColors colors = GetSyntaxColors();
            if (_mainForm.CurrentTheme == Enums.Theme.Black)
                colors.SyntaxPath = "SyntaxColors/BlackSyntax.syn";
            else
                colors.SyntaxPath = "SyntaxColors/WhiteSyntax.syn";
            _mainForm.theme.syntaxColors = colors;
            _mainForm.theme.syntaxColors.SetColorsToHighlighter(_mainForm.MainTextField);
            new ThemeSerializer(_mainForm.theme, _mainForm).SerializeSyntax();
        }

        private void buttonToDefault_Click(object sender, EventArgs e)
        {
            _syntaxColors = ThemeSerializer.Deserialize<SyntaxColors>(_defaultSyntax);
            SyntaxColorsOptionsControl_Load(sender, e);
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            if (_mainForm.CurrentTheme == Enums.Theme.Black)
                _syntaxColors = ThemeSerializer.Deserialize<SyntaxColors>("SyntaxColors/BlackSyntax.syn");
            if (_mainForm.CurrentTheme == Enums.Theme.White)
                _syntaxColors = ThemeSerializer.Deserialize<SyntaxColors>("SyntaxColors/WhiteSyntax.syn");
            SyntaxColorsOptionsControl_Load(sender, e);
        }
    }
}
