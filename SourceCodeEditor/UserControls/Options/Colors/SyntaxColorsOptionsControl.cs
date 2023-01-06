using SourceCodeEditor.AppearenceConfig;

namespace SourceCodeEditor.UserControls.Options
{
    public partial class SyntaxColorsOptionsControl : UserControl
    {
        private MainForm _mainForm { get; set; }
        private SyntaxColors _syntaxColors { get; set; }
        public SyntaxColorsOptionsControl(MainForm form)
        {
            _mainForm = form;
            _syntaxColors = _mainForm.theme.syntaxColors!;
            InitializeComponent();
        }

        private void SyntaxColorsOptionsControl_Load(object sender, EventArgs e)
        {
            var properties = _syntaxColors.GetType().GetProperties();
            var colors = new List<Color>();
            foreach (var property in properties) 
            {
                var value = (Tuple<Color,FontStyle>)property.GetValue(_syntaxColors)!;
                colors.Add(value.Item1);
            }

        }
    }
}
