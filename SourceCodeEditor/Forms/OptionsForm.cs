using SourceCodeEditor.AppearenceConfig;
using SourceCodeEditor.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCodeEditor.Forms
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void ValidateSize()
        {
            dataGridView1.Width = this.Width / 4;
            dataGridView1.Columns[0].Width = dataGridView1.Width-3;
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            GeneralOptionsControl optionsControl = new GeneralOptionsControl();
            optionsControl.Dock = DockStyle.Fill;
            WorkPanel.Controls.Add(optionsControl);
            ValidateSize();
        }

        private void OptionsForm_SizeChanged(object sender, EventArgs e)
        {
            ValidateSize();
        }
    }
}
