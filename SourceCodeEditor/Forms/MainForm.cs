using FastColoredTextBoxNS;
using SourceCodeEditor.AppearenceConfig;
using SourceCodeEditor.Enums;
using SourceCodeEditor.Forms;
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
        private string _applicationName = "Salamanca";

        public Theme _currentTheme = Theme.Black;

        /// <summary>
        /// Current opened file
        /// </summary>
        private string _currentFile = String.Empty;

        /// <summary>
        /// Is file created on disk
        /// </summary>
        private bool _isFileCreated = false;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Load hotkeys config from file on form load
            new HotKeysConfig(MainHeader).LoadHotkeysConfig();

            //Change form theme to black on Load 
            new ThemeChanger(_currentTheme, MainHeader, MainTextField, MainFooter, new List<ToolStripStatusLabel> { LineCountLable }).ChangeTheme();
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
        private void FileNameToFormText(string FileName = "*") => this.Text = $"{_applicationName} | {Path.GetFileName(FileName)}";

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

        /// <summary>
        /// Get all labels from StatusStrip
        /// </summary>
        /// <param name="statusStrip">Control to get labels from</param>
        /// <returns>List of labels</returns>
        private IEnumerable<ToolStripStatusLabel> GetLabelsFromStatusStrip(StatusStrip statusStrip)
        {
            var labels = new List<ToolStripStatusLabel>();
            foreach (var item in statusStrip.Items)
            {
                if (item is ToolStripStatusLabel)
                    labels.Add((ToolStripStatusLabel)item);
            }
            return labels;
        }

        /// <summary>
        /// Get all labels from form
        /// </summary>
        /// <returns>List of labels</returns>
        private IEnumerable<ToolStripStatusLabel> GetLabelsFromForm()
        {
            var labels = new List<ToolStripStatusLabel>(); 
            foreach (var control in this.Controls)
            {
                if (control is ToolStripStatusLabel)
                     labels.Add((ToolStripStatusLabel)control);
                if (control is StatusStrip)
                    labels.AddRange((List<ToolStripStatusLabel>)GetLabelsFromStatusStrip((StatusStrip)control));
            }
            return labels;
        }

        /// <summary>
        /// Change theme of application to black
        /// </summary>
        public void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var labels = this.GetLabelsFromForm();
            _currentTheme = Theme.Black;
            new ThemeChanger(_currentTheme, MainHeader, MainTextField, MainFooter, labels).ChangeTheme();

            whiteToolStripMenuItem.Checked = false;
            blackToolStripMenuItem.Checked = true;
        }

        /// <summary>
        /// Change theme of application to white
        /// </summary>
        public void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var labels = this.GetLabelsFromForm();
            _currentTheme = Theme.White;
            new ThemeChanger(_currentTheme, MainHeader, MainTextField, MainFooter, labels).ChangeTheme();
            whiteToolStripMenuItem.Checked = true;
            blackToolStripMenuItem.Checked = false;
        }

        private void MainTextField_TextChanged(object sender, TextChangedEventArgs e)
        {
            LineCountLable.Text = $"Lines: {MainTextField.Lines.Count}";
            MarkFileAsUnsaved();
        }
        
        /// <summary>
        /// Show OptionsForm dialog
        /// </summary>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OptionsForm(this).ShowDialog();
        }
        #endregion 
    }
}
