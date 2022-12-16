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

namespace SourceCodeEditor.UserControls
{
    public partial class ThemeOptionsControl : UserControl
    {
        public ThemeOptionsControl()
        {
            InitializeComponent();
        }

        private void ThemeOptionsControl_Load(object sender, EventArgs e)
        {
            comboBoxThemes.DataSource = Enum.GetNames(typeof(Theme));
        }
    }
}
