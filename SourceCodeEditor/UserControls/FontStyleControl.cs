namespace SourceCodeEditor.UserControls
{
    public partial class FontStyleControl : UserControl
    {
        public FontStyleControl()
        {
            InitializeComponent();
        }

        public void SetFontStyle(FontStyle fontStyle)
        {
            switch(fontStyle)
            {
                case FontStyle.Regular:
                    {
                         checkBoxRegular.Checked = true;
                    }
                    break;
                case FontStyle.Bold:
                    {
                        checkBoxBold.Checked = true;
                    }break;
                case FontStyle.Italic:
                    {
                        checkBoxItalic.Checked = true;
                    }
                    break;
                case FontStyle.Underline:
                    {
                        checkBoxUnderline.Checked = true;
                    }
                    break;
                case FontStyle.Strikeout:
                    {
                        checkBoxStrike.Checked = true;
                    }
                    break;
            }
        }
        public FontStyle GetFontStyle() 
        {
            FontStyle style = new FontStyle();
            if (checkBoxRegular.Checked)
                style = FontStyle.Regular;
            if (checkBoxBold.Checked)
                style = FontStyle.Bold;
            if (checkBoxItalic.Checked)
                style = FontStyle.Italic;
            if (checkBoxUnderline.Checked)
                style = FontStyle.Underline;
            if(checkBoxStrike.Checked)
                style = FontStyle.Strikeout;
            return style;
        }
    }
}
