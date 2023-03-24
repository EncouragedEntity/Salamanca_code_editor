﻿namespace SourceCodeEditor.UserControls.Options
{
    //TODO
    //Hotkey changing
    //

    public partial class HotKeysOptionsControl : UserControl
    {
        private MainForm? _mainForm = null;
        public HotKeysOptionsControl(MainForm? mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void UploadDictionaryToDataGrid(Dictionary<string, Keys> pairs)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in pairs)
            {
                dataGridView1.Rows.Add(item.Key, item.Value);
            }
        }

        private void SetDataGridWidth()
        {
            dataGridView1.Width = this.Width;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = dataGridView1.Width / 2;
            }
        }

        private void SetPanelButtonsPosition()
        {
            var buttons = panel1.Controls.OfType<Button>().ToList();
            buttons[0].Left = panel1.Width - 95;
            buttons[1].Left = panel1.Width - buttons[0].Width - 100;
        }

        private void ValidateSize()
        {
            SetDataGridWidth();
            SetPanelButtonsPosition();
        }

        private void HotKeysOptionsControl_SizeChanged(object sender, EventArgs e)
        {
            ValidateSize();
        }

        private void HotKeysOptionsControl_Load(object sender, EventArgs e)
        {
            var ActionHotkeyPairs = new Dictionary<string, Keys>();
            foreach (var MainItem in _mainForm!.MainMenuStrip.Items)
            {
                foreach (ToolStripMenuItem item in Header.GetHeaderItems(MainItem))
                {
                    ActionHotkeyPairs.Add(item.Text, item.ShortcutKeys);
                }
            }

            UploadDictionaryToDataGrid(ActionHotkeyPairs);
            ValidateSize();
        }

        private (bool, int, int) HotKeyExists(Keys hotKey)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == hotKey.ToString())
                        return (true, i, j);
                }
            }
            return (false, -1, -1);
        }

        private List<Keys> listofkeys = new List<Keys>();

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            listofkeys.Remove(e.KeyData);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex != 0)
            {
                var HotKey = (Keys)Enum.Parse(typeof(Keys), e.KeyValue.ToString());
                (bool, int, int) result = HotKeyExists(HotKey);

                if (!result.Item1)
                {
                    listofkeys.Add(e.KeyData);
                }
                else
                {
                    dataGridView1.Rows[result.Item2].Cells[result.Item3].Value = String.Empty;
                    listofkeys.Add(e.KeyData);
                }
                PrintHotKeys();
            }
        }

        private void PrintHotKeys()
        {
            dataGridView1.CurrentCell.Value = String.Empty;
            foreach (var key in listofkeys)
            {
                if (key != listofkeys.Last())
                {
                    dataGridView1.CurrentCell.Value += $"{key}";
                }
                else
                    dataGridView1.CurrentCell.Value += $"{key} ";
            }
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            HotKeysOptionsControl_Load(sender, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
