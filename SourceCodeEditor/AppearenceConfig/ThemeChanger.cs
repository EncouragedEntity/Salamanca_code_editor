using FastColoredTextBoxNS;
using SourceCodeEditor.Enums;
using System.Security.Permissions;

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
        private bool IsContentSerialized { get; set; } = false;

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

            IsContentSerialized = false;
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

            ChangeSyntaxHighlithing();
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
            ChangeSyntaxHighlithing();


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

        private void SetColorsToHighLighterBlack()
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
        }
        private void SetColorsToHighLighterWhite()
        {
            _mainTextField.SyntaxHighlighter.ClassNameStyle = new TextStyle(Brushes.DarkGreen, null, FontStyle.Bold);
            _mainTextField.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.DarkRed, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.CommentStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.CommentTagStyle = new TextStyle(Brushes.DarkViolet, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.KeywordStyle = new TextStyle(Brushes.BlueViolet, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.KeywordStyle2 = new TextStyle(Brushes.BlueViolet, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.KeywordStyle3 = new TextStyle(Brushes.DarkBlue, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.AttributeStyle = new TextStyle(Brushes.DarkOrange, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.AttributeValueStyle = new TextStyle(Brushes.DarkGreen, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.FunctionsStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.HtmlEntityStyle = new TextStyle(Brushes.DarkMagenta, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.XmlEntityStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.NumberStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.StatementsStyle = new TextStyle(Brushes.Coral, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.TagBracketStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.TagNameStyle = new TextStyle(Brushes.Salmon, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.TypesStyle = new TextStyle(Brushes.DarkOrchid, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.VariableStyle = new TextStyle(Brushes.DarkSlateBlue, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.XmlAttributeStyle = new TextStyle(Brushes.DarkGreen, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.XmlAttributeValueStyle = new TextStyle(Brushes.DeepPink, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.XmlCDataStyle = new TextStyle(Brushes.Salmon, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.XmlTagBracketStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
            _mainTextField.SyntaxHighlighter.XmlTagNameStyle = new TextStyle(Brushes.Salmon, null, FontStyle.Regular);
        }
        private void SetColorsToHighlighter()
        {
            switch (_theme)
            {
                case Theme.Black: 
                    {
                        SetColorsToHighLighterBlack();
                    }
                    break;
                case Theme.White:
                    {
                        SetColorsToHighLighterWhite();
                    }
                    break;
            }

        }

        private void SetColorsToCurrentThemeBlack()
        {
            currentTheme.syntaxColors!.ClassNameStyle = Tuple.Create(Color.MediumSpringGreen, FontStyle.Bold);
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
        private void SetColorsToCurrentThemeWhite()
        {
            currentTheme.syntaxColors!.ClassNameStyle = Tuple.Create(Color.DarkGreen, FontStyle.Bold);
            currentTheme.syntaxColors.StringStyle = Tuple.Create(Color.DarkRed, FontStyle.Regular);
            currentTheme.syntaxColors.CommentStyle = Tuple.Create(Color.Green, FontStyle.Regular);
            currentTheme.syntaxColors.CommentTagStyle = Tuple.Create(Color.DarkViolet, FontStyle.Regular);
            currentTheme.syntaxColors.KeywordStyle = Tuple.Create(Color.BlueViolet, FontStyle.Regular);
            currentTheme.syntaxColors.KeywordStyle2 = Tuple.Create(Color.BlueViolet, FontStyle.Regular);
            currentTheme.syntaxColors.KeywordStyle3 = Tuple.Create(Color.DarkBlue, FontStyle.Regular);
            currentTheme.syntaxColors.AttributeStyle = Tuple.Create(Color.DarkOrange, FontStyle.Regular);
            currentTheme.syntaxColors.AttributeValueStyle = Tuple.Create(Color.DarkGreen, FontStyle.Regular);
            currentTheme.syntaxColors.FunctionsStyle = Tuple.Create(Color.Blue, FontStyle.Regular);
            currentTheme.syntaxColors.HtmlEntityStyle = Tuple.Create(Color.DarkMagenta, FontStyle.Regular);
            currentTheme.syntaxColors.XmlEntityStyle = Tuple.Create(Color.Blue, FontStyle.Regular);
            currentTheme.syntaxColors.NumberStyle = Tuple.Create(Color.Red, FontStyle.Regular);
            currentTheme.syntaxColors.StatementsStyle = Tuple.Create(Color.Coral, FontStyle.Regular);
            currentTheme.syntaxColors.TagBracketStyle = Tuple.Create(Color.Blue, FontStyle.Regular);
            currentTheme.syntaxColors.TagNameStyle = Tuple.Create(Color.Salmon, FontStyle.Regular);
            currentTheme.syntaxColors.TypesStyle = Tuple.Create(Color.DarkOrchid, FontStyle.Regular);
            currentTheme.syntaxColors.VariableStyle = Tuple.Create(Color.DarkSlateBlue, FontStyle.Regular);
            currentTheme.syntaxColors.XmlAttributeStyle = Tuple.Create(Color.DarkGreen, FontStyle.Regular);
            currentTheme.syntaxColors.XmlAttributeValueStyle = Tuple.Create(Color.DeepPink, FontStyle.Regular);
            currentTheme.syntaxColors.XmlCDataStyle = Tuple.Create(Color.Salmon, FontStyle.Regular);
            currentTheme.syntaxColors.XmlTagBracketStyle = Tuple.Create(Color.Blue, FontStyle.Regular);
            currentTheme.syntaxColors.XmlTagNameStyle = Tuple.Create(Color.Salmon, FontStyle.Regular);
        }
        private void SetColorsToCurrentTheme()
        {
            currentTheme.syntaxColors = new SyntaxColors();
            switch (_theme)
            {
                case Theme.Black:
                    {
                        SetColorsToCurrentThemeBlack();
                    }
                    break;
                case Theme.White:
                    {
                        SetColorsToCurrentThemeWhite();
                    }
                    break;
            }

        }

        /// <summary>
        /// Change syntax highlighting
        /// </summary>
        public void ChangeSyntaxHighlithing()
        {
            var sercon = new ContentSerializer(_mainTextField.Text);
            _mainTextField.ClearStylesBuffer();
            sercon.SerializeContent();
            SelectionStart = _mainTextField.SelectionStart;
            _mainTextField.Text = String.Empty;
            SetColorsToHighlighter();
            SetColorsToCurrentTheme();
            mainForm.theme = currentTheme;
            _mainTextField.Text = sercon.Deserialize();
            _mainTextField.SelectionStart = SelectionStart;
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
