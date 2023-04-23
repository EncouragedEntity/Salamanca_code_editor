namespace SourceCodeEditor.UserControls.Options
{
    //TODO
    //Hotkey changing
    //

    public partial class HotKeysOptionsControl : UserControl
    {
        private MainForm? _mainForm = null;
        private List<Keys> listofkeys = new List<Keys>();

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

        private void ValidateSize()
        {
            SetDataGridWidth();
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
    }
}
