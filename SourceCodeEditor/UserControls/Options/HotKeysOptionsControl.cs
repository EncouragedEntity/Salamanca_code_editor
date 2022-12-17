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
    }
}
