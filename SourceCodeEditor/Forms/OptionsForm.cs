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

        private void ReverseDataGridViewRows(DataGridView dg)
        {
            var rows = new List<DataGridViewRow>();
            rows.AddRange(dg.Rows.Cast<DataGridViewRow>());
            rows.Reverse();
            dg.Rows.Clear();
            dg.Rows.AddRange(rows.ToArray());
        }

        private void SetDataGridItems()
        {
            dataGridView1.Rows.Add("General");
            dataGridView1.Rows.Add("Theme");

        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            SetDataGridItems();
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
