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
        private readonly MenuStrip _header;
        private readonly FastColoredTextBox _mainTextField;
        private readonly StatusStrip _footer;
        private readonly IEnumerable<ToolStripStatusLabel> _labels;

        public ThemeChanger(Theme theme, MenuStrip header, FastColoredTextBox mainTextField, StatusStrip footer, IEnumerable<ToolStripStatusLabel> labels)
        {
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
        /// <param name="header">Main menu strip on form</param>
        /// <param name="mainTextField">Main text field on form</param>
        /// <param name="footer">Bottom form panel, that contains info about application</param>
        /// <param name="labels">All labels on form</param>
        public void ChangeGeneralThemeToBlack()
        {
            _mainTextField.BackColor = grey;
            _mainTextField.ForeColor = Color.White;
            _mainTextField.IndentBackColor = darkGrey;
            _mainTextField.LineNumberColor = Color.Silver;
            _header.BackColor = darkGrey;
            _footer.BackColor = darkGrey;
            _header.ForeColor = _mainTextField.ForeColor = Color.White;
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
        /// <param name="header">Main menu strip on form</param>
        /// <param name="mainTextField">Main text field on form</param>
        /// <param name="footer">Bottom form panel, that contains info about application</param>
        /// <param name="labels">All labels on form</param>
        public void ChangeGeneralThemeToWhite()
        {
            _mainTextField.BackColor = Color.White;
            _mainTextField.LineNumberColor = Color.Black;
            _mainTextField.ForeColor = Color.Black;
            _mainTextField.IndentBackColor = Color.FromArgb(224, 224, 224);
            _header.BackColor = Color.FromArgb(224, 224, 224);
            _footer.BackColor = Color.FromArgb(224, 224, 224);
            _header.ForeColor = _mainTextField.ForeColor = Color.Black;
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
                _mainTextField.SyntaxHighlighter.ClassNameStyle = new TextStyle(Brushes.Black, null, FontStyle.Bold | FontStyle.Underline);
                _mainTextField.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.CommentStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.CommentTagStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.KeywordStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
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
                _mainTextField.SyntaxHighlighter.ClassNameStyle = new TextStyle(Brushes.White, null, FontStyle.Bold | FontStyle.Underline);
                _mainTextField.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.CommentStyle = new TextStyle(Brushes.LimeGreen, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.CommentTagStyle = new TextStyle(Brushes.DarkGray, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.KeywordStyle = new TextStyle(Brushes.DeepSkyBlue, null, FontStyle.Regular);
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
