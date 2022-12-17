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
    public partial class HotKeysOptionsControl : UserControl
    {
        private MainForm? _mainForm = null;
        public HotKeysOptionsControl(MainForm? mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.H))
                return true;

            if (keyData == (Keys.Control | Keys.A))
                return true;
            if (keyData == (Keys.Control | Keys.O))
                return true;
            if (keyData == (Keys.Control | Keys.D))
                return true;


            return base.ProcessCmdKey(ref msg, keyData); //we didn't handle it
        }

        private void UploadDictionaryToDataGrid(Dictionary<string, Keys> pairs)
        {
            foreach (var item in pairs)
            {
                dataGridView1.Rows.Add(item.Key,item.Value);
            }
        }

        private void HotKeysOptionsControl_Load(object sender, EventArgs e)
        {
            var ActionHotkeyPairs = new Dictionary<string, Keys>();
            foreach (var MainItem in _mainForm!.MainMenuStrip.Items)
            {
                foreach (ToolStripMenuItem item in Header.GetHeaderItems(MainItem))
                {
                    ActionHotkeyPairs.Add(item.Text,item.ShortcutKeys);
                }
            }

            UploadDictionaryToDataGrid(ActionHotkeyPairs);
        }

        private (bool,int,int) HotKeyExists(Keys hotKey)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == hotKey.ToString())
                        return (true,i,j);
                }
            }
            return (false,-1,-1);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex != 0)
            {
                var HotKey = (Keys)Enum.Parse(typeof(Keys), e.KeyValue.ToString());
                (bool, int, int) result = HotKeyExists(HotKey);

                if (!result.Item1)
                {
                    /*if (e.Modifiers == Keys.ControlKey || e.Modifiers == Keys.ShiftKey)
                    {
                        var modifier = (Keys)Enum.Parse(typeof(Keys), e.Modifiers.ToString());
                        dataGridView1.CurrentCell.Value = $"{modifier} + {HotKey}";
                    }*/
                    dataGridView1.CurrentCell.Value = HotKey;
                }
                else
                {
                    dataGridView1.Rows[result.Item2].Cells[result.Item3].Value = String.Empty;
                    dataGridView1.CurrentCell.Value = HotKey;
                }
            }
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
