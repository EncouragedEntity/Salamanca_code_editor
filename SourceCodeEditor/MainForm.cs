using System.Reflection.Metadata.Ecma335;

namespace SourceCodeEditor
{
    public partial class MainForm : Form
    {
        private string _currentFile = String.Empty;
        private string _fileExtension = String.Empty;
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var op = openFileDialog1;
            if (op.ShowDialog() != DialogResult.OK) return;

            _currentFile = op.FileName;
            _fileExtension = Path.GetExtension(_currentFile);
            richTextBox1.Lines = File.ReadAllLines(_currentFile);
        }

        private void SaveFile() => File.WriteAllLines(_currentFile, richTextBox1.Lines);
        private void SaveFile(string FileName) => File.WriteAllLines(FileName, richTextBox1.Lines);

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => SaveFile();

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sv = saveFileDialog1;
            if (sv.ShowDialog() != DialogResult.OK) return;
            SaveFile(sv.FileName);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sv = saveFileDialog1;
            sv.FileName = "untitled.txt";
            if (sv.ShowDialog() != DialogResult.OK) return;
            _currentFile = sv.FileName;
            SaveFile();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rich = richTextBox1;
            var toolStrip = menuStrip1;

            Color grey = Color.FromArgb(80, 80, 80);
            Color moreGrey = Color.FromArgb(50, 50, 50);

            rich.BackColor = grey;
            toolStrip.BackColor = moreGrey;
            toolStrip.ForeColor = rich.ForeColor = Color.White;
            foreach (ToolStripMenuItem item in toolStrip.Items)
            {
                foreach (ToolStripDropDownItem dropItem in item.DropDownItems)
                {
                    dropItem.BackColor = grey;
                    dropItem.ForeColor = Color.White;
                }
            }
        }
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rich = richTextBox1;
            var toolStrip = menuStrip1;
            rich.BackColor = Color.White;
            toolStrip.BackColor = Color.FromArgb(224, 224, 224);
            toolStrip.ForeColor = rich.ForeColor = Color.Black;
        }
    }
}