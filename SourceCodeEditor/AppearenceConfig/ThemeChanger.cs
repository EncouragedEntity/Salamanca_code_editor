using FastColoredTextBoxNS;

namespace SourceCodeEditor.AppearenceConfig
{
    public class ThemeChanger
    {
        private static Color grey = Color.FromArgb(90, 90, 90);
        private static Color darkGrey = Color.FromArgb(50, 50, 50);

        public static void ChangeTheme(Theme theme, MenuStrip header, FastColoredTextBox mainTextField, Panel footer, IEnumerable<Label> labels)
        {
            switch (theme)
            {
                case Theme.White:
                    {
                        ChangeGeneralThemeToWhite(header, mainTextField, footer, labels);
                    }
                    break;
                case Theme.Black:
                    {
                        ChangeGeneralThemeToBlack(header,mainTextField,footer,labels);
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
        static public void ChangeGeneralThemeToBlack(MenuStrip header, FastColoredTextBox mainTextField, Panel footer, params Label[]labels)
        {
            
            mainTextField.BackColor = grey;
            mainTextField.ForeColor = Color.White;
            mainTextField.IndentBackColor = darkGrey;
            mainTextField.LineNumberColor = Color.Silver;
            header.BackColor = darkGrey;
            footer.BackColor = darkGrey;
            header.ForeColor = mainTextField.ForeColor = Color.White;
            foreach (var label in labels)
            {
                label.ForeColor = Color.White;
            }


            ChangeSyntaxHighlithingToBlack(mainTextField);
            ChangeHeaderThemeToBlack(header);
        }

        /// <summary>
        /// Set Application controls theme to "Black"
        /// </summary>
        /// <param name="header">Main menu strip on form</param>
        /// <param name="mainTextField">Main text field on form</param>
        /// <param name="footer">Bottom form panel, that contains info about application</param>
        /// <param name="labels">All labels on form</param>
        static public void ChangeGeneralThemeToBlack(MenuStrip header, FastColoredTextBox mainTextField, Panel footer, IEnumerable<Label> labels)
        {
            mainTextField.BackColor = grey;
            mainTextField.ForeColor = Color.White;
            mainTextField.IndentBackColor = darkGrey;
            mainTextField.LineNumberColor = Color.Silver;
            header.BackColor = darkGrey;
            footer.BackColor = darkGrey;
            header.ForeColor = mainTextField.ForeColor = Color.White;
            foreach (var label in labels)
            {
                label.ForeColor = Color.White;
            }

            ChangeSyntaxHighlithingToBlack(mainTextField);
            ChangeHeaderThemeToBlack(header);
        }

        /// <summary>
        /// Set Application controls theme to "White"
        /// </summary>
        /// <param name="header">Main menu strip on form</param>
        /// <param name="mainTextField">Main text field on form</param>
        /// <param name="footer">Bottom form panel, that contains info about application</param>
        /// <param name="labels">All labels on form</param>
        static public void ChangeGeneralThemeToWhite(MenuStrip header, FastColoredTextBox mainTextField, Panel footer, params Label[] labels)
        {
            mainTextField.BackColor = Color.White;
            mainTextField.LineNumberColor = Color.Black;
            mainTextField.IndentBackColor = Color.FromArgb(224, 224, 224);
            header.BackColor = Color.FromArgb(224, 224, 224);
            footer.BackColor = Color.FromArgb(224, 224, 224);
            header.ForeColor = mainTextField.ForeColor = Color.Black;
            foreach (var label in labels)
            {
                label.ForeColor = Color.Black;
            }
            
            ChangeHeaderThemeToWhite(header);
            ChangeSyntaxHighlithingToWhite(mainTextField);
        }

        /// <summary>
        /// Set Application controls theme to "White"
        /// </summary>
        /// <param name="header">Main menu strip on form</param>
        /// <param name="mainTextField">Main text field on form</param>
        /// <param name="footer">Bottom form panel, that contains info about application</param>
        /// <param name="labels">All labels on form</param>
        static public void ChangeGeneralThemeToWhite(MenuStrip header, FastColoredTextBox mainTextField, Panel footer, IEnumerable<Label> labels)
        {
            mainTextField.BackColor = Color.White;
            mainTextField.LineNumberColor = Color.Black;
            mainTextField.ForeColor = Color.Black;
            mainTextField.IndentBackColor = Color.FromArgb(224, 224, 224);
            header.BackColor = Color.FromArgb(224, 224, 224);
            footer.BackColor = Color.FromArgb(224, 224, 224);
            header.ForeColor = mainTextField.ForeColor = Color.Black;
            foreach (var label in labels)
            {
                label.ForeColor = Color.Black;
            }

            ChangeHeaderThemeToWhite(header);
            ChangeSyntaxHighlithingToWhite(mainTextField);
        }

        static public void ChangeSyntaxHighlithingToWhite(FastColoredTextBox mainTextField)
        {
            try
            {

                string text = mainTextField.Text;
                mainTextField.Text = String.Empty;
                mainTextField.SyntaxHighlighter.ClassNameStyle = new TextStyle(Brushes.Black, null, FontStyle.Bold | FontStyle.Underline);
                mainTextField.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
                mainTextField.SyntaxHighlighter.CommentStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
                mainTextField.SyntaxHighlighter.CommentTagStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
                mainTextField.SyntaxHighlighter.KeywordStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
                mainTextField.Text = text;
            }
            catch(Exception) 
            {
                mainTextField.ClearStylesBuffer();
                ChangeSyntaxHighlithingToWhite(mainTextField);
            }
        }

        static public void ChangeSyntaxHighlithingToBlack(FastColoredTextBox mainTextField)
        {
            try
            {
                string text = mainTextField.Text;
                mainTextField.Text = String.Empty;
                mainTextField.SyntaxHighlighter.ClassNameStyle = new TextStyle(Brushes.White, null, FontStyle.Bold | FontStyle.Underline);
                mainTextField.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
                mainTextField.SyntaxHighlighter.CommentStyle = new TextStyle(Brushes.LimeGreen, null, FontStyle.Regular);
                mainTextField.SyntaxHighlighter.CommentTagStyle = new TextStyle(Brushes.DarkGray, null, FontStyle.Regular);
                mainTextField.SyntaxHighlighter.KeywordStyle = new TextStyle(Brushes.DeepSkyBlue, null, FontStyle.Regular);
                mainTextField.Text = text;
            }
            catch (Exception)
            {
                mainTextField.ClearStylesBuffer();
                ChangeSyntaxHighlithingToBlack(mainTextField);
            }
        }

        /// <summary>
        /// Changes "header's" items theme to "Black"
        /// </summary>
        /// <param name="header">Object of main menu strip</param>
        private static void ChangeHeaderThemeToBlack(MenuStrip header)
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in header.Items)
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
        private static void ChangeHeaderThemeToWhite(MenuStrip header)
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in header.Items)
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
