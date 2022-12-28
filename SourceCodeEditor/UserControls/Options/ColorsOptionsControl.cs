using SourceCodeEditor.AppearenceConfig;
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
        public CurrentTheme? CurrentTheme { get; set; }
        public MainForm? form;

        public ColorsOptionsControl(MainForm? form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void SetButtonsColors()
        {
            buttonHeaderBack.BackColor = CurrentTheme!.HeaderBack;
            buttonHeaderFore.BackColor = CurrentTheme.HeaderFore;
            buttonFooterBack.BackColor = CurrentTheme.FooterBack;
            buttonFooterFore.BackColor = CurrentTheme.FooterFore;
            buttonTextBack.BackColor = CurrentTheme.MainTextFieldBack;
            buttonTextFore.BackColor = CurrentTheme.MainTextFieldFore;
            buttonLabelsBack.BackColor = CurrentTheme.LabelsBack;
            buttonLabelsFore.BackColor = CurrentTheme.LabelsFore;
        }

        private void ColorsOptionsControl_Load(object sender, EventArgs e)
        {
            CurrentTheme = new ThemeSerializer(form!.theme, form.MainHeader, form.MainTextField, form.MainFooter,
                                               form.GetLabelsFromForm()).DeserializeTheme();
            SetButtonsColors();
        }
    }
}
