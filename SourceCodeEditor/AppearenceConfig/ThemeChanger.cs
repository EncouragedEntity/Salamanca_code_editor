using FastColoredTextBoxNS;
using SourceCodeEditor.Enums;

namespace SourceCodeEditor.AppearenceConfig
{
    public class ThemeChanger
    {
        /// <summary>
        /// Theme is Black by default
        /// </summary>
        private Theme _theme = Theme.Black;
        private CurrentTheme currentTheme = new CurrentTheme();
        private readonly MainForm mainForm;
        private readonly MenuStrip _header;
        private readonly FastColoredTextBox _mainTextField;
        private readonly StatusStrip _footer;
        private readonly IEnumerable<ToolStripStatusLabel> _labels;

        private int SelectionStart = 0;

        public ThemeChanger(MainForm form, Theme theme, MenuStrip header, FastColoredTextBox mainTextField, StatusStrip footer, IEnumerable<ToolStripStatusLabel> labels)
        {
            mainForm = form;
            _theme = theme;
            _header = header;
            _mainTextField = mainTextField;
            _footer = footer;
            _labels = labels;
        }

        public ThemeChanger(MainForm form)
        {
            mainForm = form;
            _theme = form.CurrentTheme;
            _header = form.MainHeader;
            _mainTextField = form.MainTextField;
            _footer = form.MainFooter;
            _labels = form.GetLabelsFromForm();
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

        public void ChangeTheme(Theme theme)
        {
            switch (theme)
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
            mainForm.theme.ThemePath = currentTheme.ThemePath = "BlackTheme.theme";
            _theme = Theme.Black;

            currentTheme = ThemeSerializer.DeserializeTheme(currentTheme.ThemePath)!;

            _mainTextField.BackColor = currentTheme.MainTextFieldBack;
            _mainTextField.ForeColor = currentTheme.MainTextFieldFore;
            _mainTextField.IndentBackColor = currentTheme.MainTextFieldIndentBack;
            _mainTextField.LineNumberColor = currentTheme.MainTextFieldLineNumber;
            _header.BackColor = currentTheme.HeaderBack;
            _header.ForeColor = currentTheme.HeaderFore;
            _footer.BackColor = currentTheme.FooterBack;
            _footer.ForeColor = currentTheme.FooterFore;

            foreach (var label in _labels)
            {
                label.ForeColor = currentTheme.LabelsFore;
                label.BackColor = currentTheme.LabelsBack;
            }

            ChangeSyntaxHighlithingToBlack();
            ChangeHeaderTheme(currentTheme!);

            /*
             * MANUAL THEME CHANGING
             * 
            currentTheme.MainTextFieldBack = _mainTextField.BackColor = grey;
            currentTheme.MainTextFieldFore = _header.ForeColor = _mainTextField.ForeColor = Color.White;
            currentTheme.HeaderBack = _header.BackColor = darkGrey;
            currentTheme.FooterBack = _footer.BackColor = darkGrey;
            currentTheme.LabelsFore = Color.White;

            currentTheme.MainTextFieldIndentBack = _mainTextField.IndentBackColor;
            currentTheme.MainTextFieldLineNumber = _mainTextField.LineNumberColor;

            _mainTextField.IndentBackColor = darkGrey;
            _mainTextField.LineNumberColor = Color.Silver;
            */
        }

        /// <summary>
        /// Set Application controls theme to "White"
        /// </summary>
        public void ChangeGeneralThemeToWhite()
        {
            _theme = Theme.White;
            mainForm.theme.ThemePath =  currentTheme.ThemePath = "WhiteTheme.theme";

            currentTheme = ThemeSerializer.DeserializeTheme(currentTheme.ThemePath)!;
            _mainTextField.BackColor = currentTheme.MainTextFieldBack;
            _mainTextField.ForeColor = currentTheme.MainTextFieldFore;
            _mainTextField.IndentBackColor = currentTheme.MainTextFieldIndentBack;
            _mainTextField.LineNumberColor = currentTheme.MainTextFieldLineNumber;
            _header.BackColor = currentTheme.HeaderBack;
            _header.ForeColor = currentTheme.HeaderFore;
            _footer.BackColor = currentTheme.FooterBack;
            _footer.ForeColor = currentTheme.FooterFore;

            foreach (var label in _labels)
            {
                label.ForeColor = currentTheme.LabelsFore;
                label.BackColor = currentTheme.LabelsBack;
            }
            ChangeHeaderTheme(currentTheme);
            ChangeSyntaxHighlithingToWhite();


            /*
             * MANUAL THEME CHANGING
             * 
            _mainTextField.BackColor = Color.White;
            _mainTextField.LineNumberColor = Color.Black;
            _mainTextField.ForeColor = Color.Black;
            _mainTextField.IndentBackColor = Color.FromArgb(224, 224, 224);
            _header.BackColor = Color.FromArgb(224, 224, 224);
            _footer.BackColor = Color.FromArgb(224, 224, 224);
            _header.ForeColor = _mainTextField.ForeColor = Color.Black;

            currentTheme.MainTextFieldBack = _mainTextField.BackColor;
            currentTheme.MainTextFieldFore = _mainTextField.ForeColor;
            currentTheme.MainTextFieldIndentBack = _mainTextField.IndentBackColor;
            currentTheme.MainTextFieldLineNumber = _mainTextField.LineNumberColor;
            currentTheme.HeaderBack = _header.BackColor;
            currentTheme.HeaderFore = _header.ForeColor;
            currentTheme.FooterBack = _footer.BackColor;
            currentTheme.FooterFore = _footer.ForeColor;
            currentTheme.LabelsFore = Color.Black;
            */
        }





        ///TODO: 
        ///
        /// Set "white" styles to Highlidhter and CurrentTheme!!! 
        /// 




        private void SetColorsToHighlighter()
        {
            switch (_theme)
            {
                case Theme.Black: 
                    {
                        _mainTextField.SyntaxHighlighter.ClassNameStyle = new TextStyle(Brushes.MediumSpringGreen, null, FontStyle.Bold);
                        _mainTextField.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.CommentStyle = new TextStyle(Brushes.LimeGreen, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.CommentTagStyle = new TextStyle(Brushes.DarkGray, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.KeywordStyle = new TextStyle(Brushes.DeepSkyBlue, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.KeywordStyle2 = new TextStyle(Brushes.DeepSkyBlue, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.KeywordStyle3 = new TextStyle(Brushes.DarkBlue, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.AttributeStyle = new TextStyle(Brushes.Yellow, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.AttributeValueStyle = new TextStyle(Brushes.LightGreen, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.FunctionsStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.HtmlEntityStyle = new TextStyle(Brushes.LightBlue, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.XmlEntityStyle = new TextStyle(Brushes.LightBlue, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.NumberStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.StatementsStyle = new TextStyle(Brushes.LightCoral, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.TagBracketStyle = new TextStyle(Brushes.RoyalBlue, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.TagNameStyle = new TextStyle(Brushes.Salmon, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.TypesStyle = new TextStyle(Brushes.Aqua, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.VariableStyle = new TextStyle(Brushes.Cyan, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.XmlAttributeStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.XmlAttributeValueStyle = new TextStyle(Brushes.LightGreen, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.XmlCDataStyle = new TextStyle(Brushes.Salmon, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.XmlTagBracketStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
                        _mainTextField.SyntaxHighlighter.XmlTagNameStyle = new TextStyle(Brushes.Salmon, null, FontStyle.Regular);
                    }break;
                case Theme.White:
                    {
                    
                    }break;
            }

        }

        private void SetColorsToCurrentTheme()
        {
            currentTheme.syntaxColors = new SyntaxColors();
            switch (_theme)
            {
                case Theme.Black:
                    {
                        currentTheme.syntaxColors.ClassNameStyle = Tuple.Create(Color.MediumSpringGreen, FontStyle.Bold);
                        currentTheme.syntaxColors.StringStyle = Tuple.Create(Color.Orange, FontStyle.Regular);
                        currentTheme.syntaxColors.CommentStyle = Tuple.Create(Color.LimeGreen, FontStyle.Regular);
                        currentTheme.syntaxColors.CommentTagStyle = Tuple.Create(Color.DarkGray, FontStyle.Regular);
                        currentTheme.syntaxColors.KeywordStyle = Tuple.Create(Color.DeepSkyBlue, FontStyle.Regular);
                        currentTheme.syntaxColors.KeywordStyle2 = Tuple.Create(Color.DeepSkyBlue, FontStyle.Regular);
                        currentTheme.syntaxColors.KeywordStyle3 = Tuple.Create(Color.DarkBlue, FontStyle.Regular);
                        currentTheme.syntaxColors.AttributeStyle = Tuple.Create(Color.Green, FontStyle.Regular);
                        currentTheme.syntaxColors.AttributeValueStyle = Tuple.Create(Color.LightGreen, FontStyle.Regular);
                        currentTheme.syntaxColors.FunctionsStyle = Tuple.Create(Color.Blue, FontStyle.Regular);
                        currentTheme.syntaxColors.HtmlEntityStyle = Tuple.Create(Color.LightBlue, FontStyle.Regular);
                        currentTheme.syntaxColors.XmlEntityStyle = Tuple.Create(Color.LightBlue, FontStyle.Regular);
                        currentTheme.syntaxColors.NumberStyle = Tuple.Create(Color.Red, FontStyle.Regular);
                        currentTheme.syntaxColors.StatementsStyle = Tuple.Create(Color.LightCoral, FontStyle.Regular);
                        currentTheme.syntaxColors.TagBracketStyle = Tuple.Create(Color.RoyalBlue, FontStyle.Regular);
                        currentTheme.syntaxColors.TagNameStyle = Tuple.Create(Color.Salmon, FontStyle.Regular);
                        currentTheme.syntaxColors.TypesStyle = Tuple.Create(Color.Aqua, FontStyle.Regular);
                        currentTheme.syntaxColors.VariableStyle = Tuple.Create(Color.Cyan, FontStyle.Regular);
                        currentTheme.syntaxColors.XmlAttributeStyle = Tuple.Create(Color.Green, FontStyle.Regular);
                        currentTheme.syntaxColors.XmlAttributeValueStyle = Tuple.Create(Color.LightGreen, FontStyle.Regular);
                        currentTheme.syntaxColors.XmlCDataStyle = Tuple.Create(Color.Salmon, FontStyle.Regular);
                        currentTheme.syntaxColors.XmlTagBracketStyle = Tuple.Create(Color.Blue, FontStyle.Regular);
                        currentTheme.syntaxColors.XmlTagNameStyle = Tuple.Create(Color.Salmon, FontStyle.Regular);
                    }
                    break;
                case Theme.White:
                    {
                        
                    }break;
            }

        }

        /// <summary>
        /// Change syntax highlighting to white
        /// </summary>
        public void ChangeSyntaxHighlithingToWhite()
        {
            try
            {
                string text = _mainTextField.Text;
                SelectionStart = _mainTextField.SelectionStart;
                _mainTextField.Text = String.Empty;

                currentTheme.syntaxColors = new SyntaxColors();
                _mainTextField.SyntaxHighlighter.ClassNameStyle = new TextStyle(Brushes.Black, null, FontStyle.Bold | FontStyle.Underline);
                _mainTextField.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.CommentStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.CommentTagStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
                _mainTextField.SyntaxHighlighter.KeywordStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);

                currentTheme.syntaxColors.ClassNameStyle = Tuple.Create(Color.Black, FontStyle.Bold | FontStyle.Underline);
                currentTheme.syntaxColors.StringStyle = Tuple.Create(Color.Red, FontStyle.Regular);
                currentTheme.syntaxColors.CommentStyle = Tuple.Create(Color.Green, FontStyle.Regular);
                currentTheme.syntaxColors.CommentTagStyle = Tuple.Create(Color.Gray, FontStyle.Regular);
                currentTheme.syntaxColors.KeywordStyle = Tuple.Create(Color.Blue, FontStyle.Regular);

                mainForm.theme = currentTheme;
                _mainTextField.SelectionStart = SelectionStart;
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
                SelectionStart = _mainTextField.SelectionStart;
                _mainTextField.Text = String.Empty;

                SetColorsToHighlighter();
                SetColorsToCurrentTheme();

                mainForm.theme = currentTheme;
                _mainTextField.Text = text;
                _mainTextField.SelectionStart = SelectionStart;
            }
            catch (Exception)
            {
                _mainTextField.ClearStylesBuffer();
                ChangeSyntaxHighlithingToBlack();
            }
        }

        /// <summary>
        /// Changes "header's" items theme
        /// </summary>
        /// <param name="header">Object of main menu strip</param>
        private void ChangeHeaderTheme(CurrentTheme theme)
        {
            var allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in _header.Items)
            {
                allItems.Add(toolItem);
                allItems.AddRange(Header.GetHeaderItems(toolItem));
            }

            foreach (var item in allItems)
            {
                item.BackColor = theme.HeaderBack;
                item.ForeColor = theme.HeaderFore;
            }

            _header.BackColor = theme.HeaderBack;
            _header.ForeColor = theme.HeaderFore;
        }
    }
}
