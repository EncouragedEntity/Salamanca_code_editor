using FastColoredTextBoxNS;

namespace SourceCodeEditor.AppearenceConfig
{
    public class ThemeChanger
    {
        private static Color grey = Color.FromArgb(90, 90, 90);
        private static Color darkGrey = Color.FromArgb(50, 50, 50);

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
            mainTextField.IndentBackColor = darkGrey;
            mainTextField.LineNumberColor = Color.Silver;
            header.BackColor = darkGrey;
            footer.BackColor = darkGrey;
            header.ForeColor = mainTextField.ForeColor = Color.White;
            foreach (var label in labels)
            {
                label.ForeColor = Color.White;
            }

            ChangeHeaderThemeToBlack(header);
        }

        static public void ChangeGeneralThemeToBlack(MenuStrip header, FastColoredTextBox mainTextField, Panel footer, IEnumerable<Label> labels)
        {
            mainTextField.BackColor = grey;
            mainTextField.IndentBackColor = darkGrey;
            mainTextField.LineNumberColor = Color.Silver;
            header.BackColor = darkGrey;
            footer.BackColor = darkGrey;
            header.ForeColor = mainTextField.ForeColor = Color.White;
            foreach (var label in labels)
            {
                label.ForeColor = Color.White;
            }

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
        }

        static public void ChangeGeneralThemeToWhite(MenuStrip header, FastColoredTextBox mainTextField, Panel footer, IEnumerable<Label> labels)
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
