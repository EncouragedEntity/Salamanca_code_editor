using System.Reflection.Metadata.Ecma335;

namespace SourceCodeEditor
{
    public partial class MainForm : Form
    {
        private string _currentFile = String.Empty;
        private bool isFileCreated = false;
        private bool isSaved = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        /// <summary>
        /// Adds "*" at the end of the file name in form text
        /// </summary>
        private void MarkFileAsUnsaved()
        {
            if(this.Text.Last()!='*')
                this.Text += "*";
        }
        /// <summary>
        /// Removes "*" at the end of form text
        /// </summary>
        private void MarkFileAsSaved()
        {
            this.Text = this.Text.Remove(this.Text.IndexOf(this.Text.Last()),1);
        }

        /// <summary>
        /// Sets form text as App name and file opened name
        /// </summary>
        /// <param name="FileName">Name of file to set</param>
        private void FileNameToFormText(string FileName = "*")
        {
            this.Text = "Salamanca | ";
            this.Text += Path.GetFileName(FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var op = openFileDialog1;
            if (op.ShowDialog() != DialogResult.OK) return;

            isFileCreated = true;
            _currentFile = op.FileName;
            FileNameToFormText(_currentFile);
            richTextBox1.Lines = File.ReadAllLines(_currentFile);
        }

        private void SaveFile()
        {
            File.WriteAllLines(_currentFile, richTextBox1.Lines);
            MarkFileAsSaved();
            isSaved = true;
            isFileCreated = true;
        }
        private void SaveFile(string FileName)
        {
            File.WriteAllLines(FileName, richTextBox1.Lines);
            MarkFileAsSaved();
            isSaved = true;
            isFileCreated = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFileCreated == true)
            {
                SaveFile();
                return;
            }
            newToolStripMenuItem_Click(sender, e);   
        }

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
            //Add all dropdown items color change
        }
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rich = richTextBox1;
            var toolStrip = menuStrip1;
            rich.BackColor = Color.White;
            toolStrip.BackColor = Color.FromArgb(224, 224, 224);
            toolStrip.ForeColor = rich.ForeColor = Color.Black;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
            MarkFileAsUnsaved();
        }
    }
}