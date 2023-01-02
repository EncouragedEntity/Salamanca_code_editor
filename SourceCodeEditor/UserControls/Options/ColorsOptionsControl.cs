using SourceCodeEditor.AppearenceConfig;
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

        private int BackColorChangingCounter = 0;

        public ColorsOptionsControl(MainForm form, OptionsForm optForm)
        {
            this.form = form;
            optionsForm = optForm;
            CurrentTheme = ThemeSerializer.DeserializeTheme(form.theme.ThemePath)!;
            InitializeComponent();
        }

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

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            ColorsOptionsControl_Load(sender, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            GetButtonsColors();
            new ThemeSerializer(CurrentTheme, form).SerializeTheme();
        }

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
    }
}
