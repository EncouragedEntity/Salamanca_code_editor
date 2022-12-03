using FastColoredTextBoxNS;
using SourceCodeEditor.AppearenceConfig;
using System.Collections.Generic;

namespace SourceCodeEditor
{
    /// <summary>
    /// Main form of Application
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainTextField.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            ThemeChanger.ChangeGeneralThemeToBlack(MainHeader, MainTextField, MainFooter, labelLineCountText);
        }

        #region Fields
        /// <summary>
        /// Name of application
        /// </summary>
        private string _programName = "Salamanca";

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
        /// Display opened file content to RichTextBox
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var op = openFileDialog1;
            if (op.ShowDialog() != DialogResult.OK) return;

            _isFileCreated = true;
            _currentFile = op.FileName;
            FileNameToFormText(_currentFile);
            StreamWriter sw = new StreamWriter(_currentFile);
            sw.Write(MainTextField.Text);
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
        /// Save RichTextBox content to current file
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
        /// Save RichTextBox content to new file
        /// </summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sv = saveFileDialog1;
            if (sv.ShowDialog() != DialogResult.OK) return;
            SaveFile(sv.FileName);
            FileNameToFormText(sv.FileName);
        }

        /// <summary>
        /// Create new file and save RichTextBox contents to it
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
            ThemeChanger.ChangeGeneralThemeToBlack(MainHeader, MainTextField, MainFooter, labels);
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var labels = this.GetLabelsFromForm();
            ThemeChanger.ChangeGeneralThemeToWhite(MainHeader, MainTextField, MainFooter, labels);
        }

        /// <summary>
        /// Shortcuts on form
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
	        if(!e.Control) return;
	        switch(e.KeyCode)
	        {
	    	    case Keys.O:
			            openToolStripMenuItem_Click(sender,e);
		    break; 
	    	    case Keys.N:
			            newToolStripMenuItem_Click(sender, e);
		    break; 
	    	    case Keys.S:
                        if (e.Shift)
                        {
                            saveAsToolStripMenuItem_Click(sender, e);
                            break;
                        }
                        saveToolStripMenuItem_Click(sender, e);
                        break;
                default: return;
            }
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
