﻿using SourceCodeEditor.AppearenceConfig;
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
            SetButtonsEvents();
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
            _mainForm.theme.syntaxColors = colors;
            _mainForm.theme.syntaxColors.SetColorsToHighlighter(_mainForm.MainTextField);
        }
    }
}