using FastColoredTextBoxNS;
using SourceCodeEditor.AppearenceConfig;
using System.Collections.Generic;
using System.Text.Json;

namespace SourceCodeEditor
{
    /// <summary>
    /// Main form of Application
    /// </summary>
    public partial class MainForm : Form
    {
        #region Fields
        /// <summary>
        /// Name of application
        /// </summary>
        private string _programName = "Salamanca";

        private Theme _currentTheme = Theme.Black;

        /// <summary>
        /// Current opened file
        /// </summary>
        private string _currentFile = String.Empty;

        /// <summary>
        /// Is file created on disk
        /// </summary>
        private bool _isFileCreated = false;

        /// <summary>
        /// Is file saved on disk
        /// </summary>
        private bool _isSaved = false;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new HotKeysConfig(MainHeader).LoadHotkeysConfig();

            //Change form theme to black on Load 
            ThemeChanger.ChangeTheme(_currentTheme, MainHeader, MainTextField, MainFooter, new List<Label> {labelLineCountText});
        }

        #region Methods
        /// <summary>
        /// Exit from application
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        /// <summary>
        /// Adds "*" at the end of the file name in form text
        /// </summary>
        private void MarkFileAsUnsaved() => this.Text += this.Text.Last() != '*' ? "*" : String.Empty;

        /// <summary>
        /// Removes "*" at the end of form text
        /// </summary>
        private void MarkFileAsSaved() => FileNameToFormText(_currentFile);

        /// <summary>
        /// Sets form text as App name and file opened name
        /// </summary>
        /// <param name="FileName">Name of file to set</param>
        private void FileNameToFormText(string FileName = "*") => this.Text = $"{_programName} | {Path.GetFileName(FileName)}";

        /// <summary>
        /// Display opened file content to FastColoredTextBox
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var op = openFileDialog1;
            if (op.ShowDialog() != DialogResult.OK) return;

            _isFileCreated = true;
            _currentFile = op.FileName;
            FileNameToFormText(_currentFile);   
            MainTextField.Text = File.ReadAllText(_currentFile);
        }

        /// <summary>
        /// Save RichTextBox content to current file
        /// </summary>
        private void SaveFile()
        {
            File.WriteAllLines(_currentFile, MainTextField.Lines);
            MarkFileAsSaved();
            _isSaved = true;
            _isFileCreated = true;
        }

        /// <summary>
        /// Save RichTextBox content to file
        /// </summary>
        /// <param name="FileName">Name of file to save to</param>
        private void SaveFile(string FileName)
        {
            File.WriteAllLines(FileName, MainTextField.Lines);
            MarkFileAsSaved();
            _isSaved = true;
            _isFileCreated = true;
        }

        /// <summary>
        /// Save FastColoredTextBox content to current file
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isFileCreated == true)
            {
                SaveFile();
                return;
            }
            newToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Save FastColoredTextBox content to new file
        /// </summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sv = saveFileDialog1;
            sv.FileName = _currentFile;
            if (sv.ShowDialog() != DialogResult.OK) return;

            SaveFile(sv.FileName);
            FileNameToFormText(sv.FileName);
        }

        /// <summary>
        /// Create new file and save FastColoredTextBox contents to it
        /// </summary>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sv = saveFileDialog1;
            sv.FileName = "untitled.txt";
            if (sv.ShowDialog() != DialogResult.OK) return;
            _currentFile = sv.FileName;
            FileNameToFormText(_currentFile);
            SaveFile();
        }

        private IEnumerable<Label> GetLabelsFromPanel(Panel panel)
        {
            var labels = new List<Label>();
            foreach (Control control in panel.Controls)
            {
                if (control is Label)
                    labels.Add((Label)control);
            }
            return labels;
        }

        private IEnumerable<Label> GetLabelsFromForm()
        {
            var labels = new List<Label>(); 
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                     labels.Add((Label)control);
                if (control is Panel)
                    labels.AddRange((List<Label>)GetLabelsFromPanel((Panel)control));
            }
            return labels;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var labels = this.GetLabelsFromForm();
            _currentTheme = Theme.Black;
            ThemeChanger.ChangeTheme(_currentTheme, MainHeader, MainTextField, MainFooter, labels);

            whiteToolStripMenuItem.Checked = false;
            blackToolStripMenuItem.Checked = true;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var labels = this.GetLabelsFromForm();
            _currentTheme = Theme.White;
            ThemeChanger.ChangeTheme(_currentTheme, MainHeader, MainTextField, MainFooter, labels);
            whiteToolStripMenuItem.Checked = true;
            blackToolStripMenuItem.Checked = false;
        }

        private void MainTextField_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            labelLineCountText.Text = $"Lines: {MainTextField.Lines.Count}";
            _isSaved = false;
            MarkFileAsUnsaved();
        }
        #endregion
    }
}
