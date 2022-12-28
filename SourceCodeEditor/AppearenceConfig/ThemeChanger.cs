using FastColoredTextBoxNS;
using SourceCodeEditor.Enums;

namespace SourceCodeEditor.AppearenceConfig
{
    public class ThemeChanger
    {
        private readonly Color grey = Color.FromArgb(90, 90, 90);
        private readonly Color darkGrey = Color.FromArgb(50, 50, 50);

        /// <summary>
        /// Theme is Black by default
        /// </summary>
        private readonly Theme _theme = Theme.Black;
        private CurrentTheme currentTheme;
        private readonly MainForm mainForm;
        private readonly MenuStrip _header;
        private readonly FastColoredTextBox _mainTextField;
        private readonly StatusStrip _footer;
        private readonly IEnumerable<ToolStripStatusLabel> _labels;

        public ThemeChanger(MainForm form, Theme theme, MenuStrip header, FastColoredTextBox mainTextField, StatusStrip footer, IEnumerable<ToolStripStatusLabel> labels)
        {
            mainForm = form;
            _theme = theme;
            _header = header;
            _mainTextField = mainTextField;
            _footer = footer;
            _labels = labels;
        }

        /// <summary>
        /// Change theme
        /// </summary>
        public void ChangeTheme()
        {
            switch (_theme)
            {
                case Theme.White:
                    {
                        ChangeGeneralThemeToWhite();
                    }
                    break;
                case Theme.Black:
                    {
                        ChangeGeneralThemeToBlack();
                    }
                    break;
            }
        }

        /// <summary>
        /// Set Application controls theme to "Black"
        /// </summary>
        public void ChangeGeneralThemeToBlack()
        {
            currentTheme = new CurrentTheme();
            currentTheme.MainTextFieldBack = _mainTextField.BackColor = grey;
            currentTheme.MainTextFieldFore = _header.ForeColor = _mainTextField.ForeColor = Color.White;
            currentTheme.HeaderBack = _header.BackColor = darkGrey;
            currentTheme.FooterBack = _footer.BackColor = darkGrey;
            currentTheme.LabelsFore = Color.White;

            _mainTextField.IndentBackColor = darkGrey;
            _mainTextField.LineNumberColor = Color.Silver;
            foreach (var label in _labels)
            {
                label.ForeColor = Color.White;
            }
            ChangeSyntaxHighlithingToBlack();
            ChangeHeaderThemeToBlack();
        }

        /// <summary>
        /// Set Application controls theme to "White"
        /// </summary>
        public void ChangeGeneralThemeToWhite()
        {
            currentTheme = new CurrentTheme();

            _mainTextField.BackColor = Color.White;
            _mainTextField.LineNumberColor = Color.Black;
            _mainTextField.ForeColor = Color.Black;
            _mainTextField.IndentBackColor = Color.FromArgb(224, 224, 224);
            _header.BackColor = Color.FromArgb(224, 224, 224);
            _footer.BackColor = Color.FromArgb(224, 224, 224);
            _header.ForeColor = _mainTextField.ForeColor = Color.Black;

            currentTheme.MainTextFieldBack = _mainTextField.BackColor;
            currentTheme.MainTextFieldFore = _mainTextField.ForeColor;
            currentTheme.HeaderBack = _header.BackColor;
            currentTheme.HeaderFore = _header.ForeColor;
            currentTheme.FooterBack = _footer.BackColor;
            currentTheme.FooterFore = _footer.ForeColor;
            currentTheme.LabelsFore = Color.Black;

            foreach (var label in _labels)
            {
                label.ForeColor = Color.Black;
            }

            ChangeHeaderThemeToWhite();
            ChangeSyntaxHighlithingToWhite();
        }

        /// <summary>
        /// Change syntax highlighting to white
        /// </summary>
        public void ChangeSyntaxHighlithingToWhite()
        {
            try
            {
                string text = _mainTextField.Text;
                _mainTextField.Text = String.Empty;

                currentTheme.syntaxColors = new SyntaxColors();
                _mainTextField.SyntaxHighlighter.ClassNameStyle = new TextStyle(Brushes.Black, null, FontStyle.Bold | FontStyle.Underline);
                _mainTextField.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.CommentStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.CommentTagStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.KeywordStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);

                currentTheme.syntaxColors._classNameStyle = Tuple.Create(Color.Black, FontStyle.Bold | FontStyle.Underline);
                currentTheme.syntaxColors._stringStyle = Tuple.Create(Color.Red, FontStyle.Regular);
                currentTheme.syntaxColors._commentStyle = Tuple.Create(Color.Green, FontStyle.Regular);
                currentTheme.syntaxColors._commentTagStyle = Tuple.Create(Color.Gray, FontStyle.Regular);
                currentTheme.syntaxColors._keywordStyle = Tuple.Create(Color.Blue, FontStyle.Regular);

                mainForm.theme = currentTheme;

                _mainTextField.Text = text;
            }
            catch(Exception) 
            {
                _mainTextField.ClearStylesBuffer();
                ChangeSyntaxHighlithingToWhite();
            }
        }

        /// <summary>
        /// Change syntax highlighting to black
        /// </summary>
        public void ChangeSyntaxHighlithingToBlack()
        {
            try
            {
                string text = _mainTextField.Text;
                _mainTextField.Text = String.Empty;

                currentTheme.syntaxColors = new SyntaxColors();
                _mainTextField.SyntaxHighlighter.ClassNameStyle = new TextStyle(Brushes.White, null, FontStyle.Bold | FontStyle.Underline);
                _mainTextField.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.CommentStyle = new TextStyle(Brushes.LimeGreen, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.CommentTagStyle = new TextStyle(Brushes.DarkGray, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.KeywordStyle = new TextStyle(Brushes.DeepSkyBlue, null, FontStyle.Regular);

                currentTheme.syntaxColors._classNameStyle = Tuple.Create(Color.White, FontStyle.Bold | FontStyle.Underline);
                currentTheme.syntaxColors._stringStyle = Tuple.Create(Color.Orange, FontStyle.Regular);
                currentTheme.syntaxColors._commentStyle = Tuple.Create(Color.LimeGreen, FontStyle.Regular);
                currentTheme.syntaxColors._commentTagStyle = Tuple.Create(Color.DarkGray, FontStyle.Regular);
                currentTheme.syntaxColors._keywordStyle = Tuple.Create(Color.DeepSkyBlue, FontStyle.Regular);

                mainForm.theme = currentTheme;

                _mainTextField.Text = text;
            }
            catch (Exception)
            {
                _mainTextField.ClearStylesBuffer();
                ChangeSyntaxHighlithingToBlack();
            }
        }

        /// <summary>
        /// Changes "header's" items theme to "Black"
        /// </summary>
        /// <param name="header">Object of main menu strip</param>
        private void ChangeHeaderThemeToBlack()
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in _header.Items)
            {
                    allItems.Add(toolItem);
                    allItems.AddRange(Header.GetHeaderItems(toolItem));
            }

            foreach (var item in allItems)
            {
                item.BackColor = darkGrey;
                item.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Changes "header's" items theme to "White"
        /// </summary>
        /// <param name="header">Object of main menu strip</param>
        private void ChangeHeaderThemeToWhite()
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in _header.Items)
            {
                allItems.Add(toolItem);
                allItems.AddRange(Header.GetHeaderItems(toolItem));
            }

            foreach (var item in allItems)
            {
                item.BackColor = Color.FromArgb(224, 224, 224);
                item.ForeColor = Color.Black;
            }
        }
    }
}
