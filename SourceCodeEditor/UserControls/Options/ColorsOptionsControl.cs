﻿using SourceCodeEditor.AppearenceConfig;
using SourceCodeEditor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCodeEditor.UserControls.Options
{
    public partial class ColorsOptionsControl : UserControl
    {
        public OptionsForm optionsForm { get; set; }
        public CurrentTheme CurrentTheme { get; set; }
        public MainForm form;

        private string _defaultTheme { get; set; } = String.Empty;

        private int BackColorChangingCounter = 0;

        public ColorsOptionsControl(MainForm form, OptionsForm optForm)
        {
            this.form = form;
            optionsForm = optForm;

            _defaultTheme = form.CurrentTheme == Enums.Theme.Black ? "BlackThemeDefault.theme" : "WhiteThemeDefault.theme";

            SetTheme();
            InitializeComponent();
        }

        /// <summary>
        /// Sets deserialized theme to CurrentTheme
        /// </summary>
        private void SetTheme()
        {
            var path = form.theme.ThemePath;
            if (File.Exists(path))
            {
                CurrentTheme = ThemeSerializer.DeserializeTheme(path)!;
                return;
            }
            File.Create(path);
            GetButtonsColors();
            form.theme = CurrentTheme;
            new ThemeSerializer(CurrentTheme, form).SerializeTheme();

        }

        /// <summary>
        /// Set buttons colors from CurrentTheme colors
        /// </summary>
        private void SetButtonsColors()
        {
            buttonHeaderBack.BackColor = CurrentTheme.HeaderBack;
            buttonHeaderFore.BackColor = CurrentTheme.HeaderFore;
            buttonFooterBack.BackColor = CurrentTheme.FooterBack;
            buttonFooterFore.BackColor = CurrentTheme.FooterFore;
            buttonTextBack.BackColor = CurrentTheme.MainTextFieldBack;
            buttonTextFore.BackColor = CurrentTheme.MainTextFieldFore;
            buttonTextIndent.BackColor = CurrentTheme.MainTextFieldIndentBack;
            buttonTextLineNumber.BackColor = CurrentTheme.MainTextFieldLineNumber;
            buttonLabelsBack.BackColor = CurrentTheme.LabelsBack;
            buttonLabelsFore.BackColor = CurrentTheme.LabelsFore;
        }

        /// <summary>
        /// Set CurrentTheme colors from buttons colors
        /// </summary>
        private void GetButtonsColors()
        {
            CurrentTheme.HeaderBack = buttonHeaderBack.BackColor;
            CurrentTheme.HeaderFore = buttonHeaderFore.BackColor;
            CurrentTheme.FooterBack = buttonFooterBack.BackColor;
            CurrentTheme.FooterFore = buttonFooterFore.BackColor;
            CurrentTheme.MainTextFieldBack = buttonTextBack.BackColor;
            CurrentTheme.MainTextFieldFore = buttonTextFore.BackColor;
            CurrentTheme.MainTextFieldIndentBack = buttonTextIndent.BackColor;
            CurrentTheme.MainTextFieldLineNumber = buttonTextLineNumber.BackColor;
            CurrentTheme.LabelsBack = buttonLabelsBack.BackColor;
            CurrentTheme.LabelsFore = buttonLabelsFore.BackColor;
        }

        /// <summary>
        /// Set color changing buttons events
        /// </summary>
        private void SetButtonsEvents()
        {
            foreach (var control in tableLayoutPanel1.Controls)
            {
                if (control is Button)
                {
                    var button = (Button)control;
                    button.Click += ColorButton_Click;
                    button.BackColorChanged += buttonBack_BackColorChanged;
                }
            }
        }

        /// <summary>
        /// Sets background color of button to Color Dialog as default
        /// </summary>
        /// <param name="sender">Button color of sets to Color Dialog</param>
        private void SetCurrentButtonColorToColorDialog(Button sender)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.Color = sender.BackColor;
        }

        private void ColorButton_Click(object? sender, EventArgs e)
        {
            var obj = sender as Button;

            SetCurrentButtonColorToColorDialog(obj!);

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                obj!.BackColor = colorDialog1.Color; 
            }
            
        }

        private void ColorsOptionsControl_Load(object sender, EventArgs e)
        {
            SetButtonsEvents();
            SetButtonsColors();
        }

        /// <summary>
        /// Discard all of the buttons colors changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            ColorsOptionsControl_Load(sender, e);
        }

        /// <summary>
        /// Serializes color changes to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            GetButtonsColors();
            new ThemeSerializer(CurrentTheme, form).SerializeTheme();
            if (optionsForm.ColorsChanged)
                new ThemeChanger(form).ChangeTheme();
            
        }

        /// <summary>
        /// Counter to check if colors changed
        /// </summary>
        /// 
        ///Do not remove. On control load colors of buttons are already changed,
        ///so we need to count it as second change
        private void buttonBack_BackColorChanged(object sender, EventArgs e)
        {
            if (BackColorChangingCounter == 0)
            {
                BackColorChangingCounter++;
                return;
            }
            if (BackColorChangingCounter >= 0)
            {
                optionsForm.ColorsChanged = true;
                return;
            }
        }

        /// <summary>
        /// Return to default theme and apply it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDefault_Click(object sender, EventArgs e)
        {
            CurrentTheme = ThemeSerializer.DeserializeTheme(_defaultTheme)!;
            SetButtonsColors();
            buttonSave_Click(sender,e);
        }
    }
}
