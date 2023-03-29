using FastColoredTextBoxNS;
using SourceCodeEditor.AppearenceConfig;
using SourceCodeEditor.Enums;
using SourceCodeEditor.Forms;
using System.Text.Json;

namespace SourceCodeEditor
{
    delegate DialogResult DialogRes(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);

    /// <summary>
    /// Main form of Application
    /// </summary>
    public partial class MainForm : Form
    {
        #region Fields
        private string _applicationName { get; set; } = "Salamanca";
        public Theme CurrentTheme { get; set; }
        private Theme DefaultTheme { get; set; } = Theme.Black;
        public CurrentTheme theme;
        public Font DefaultTextFont { get; set; } = new Font(new FontFamily("Courier New"), 12);
        public WindowState StateOfWindow { get; set; } = Enums.WindowState.Windowed;
        public int DefaultZoom { get; set; } = 100;

        /// <summary>
        /// Current opened file
        /// </summary>
        private string _currentFile { get; set; } = String.Empty;
        /// <summary>
        /// Is file created on disk
        /// </summary>
        private bool _isFileCreated { get; set; } = false;
        /// <summary>
        /// Is file saved on disk
        /// </summary>
        private bool _isFileSaved { get; set; } = false;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            theme = ThemeSerializer.Deserialize<CurrentTheme>("Themes/BlackTheme.theme")!;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set toolStripMenuItem dropdown items from "MainTextField.Languages" on load
            new LanguageConfig(this).LoadLanguages();

            //Load hotkeys config from file on form load
            new HotKeysConfig(MainHeader).LoadHotkeysConfig();
            LoadTemplatesToolStrips();


            //Get default theme from file and apply it on load
            theme.syntaxColors = ThemeSerializer.Deserialize<SyntaxColors>("SyntaxColors/BlackSyntax.syn");
            CurrentTheme = DefaultTheme;
            new ThemeChanger(this).ChangeTheme(CurrentTheme);
            DeleteUnnecessaryLabels();
        }

        #region Methods

        #region File
        private async Task ReadTextFromFile()
        {
            var astr = await File.ReadAllTextAsync(_currentFile);
            MainTextField.Text = astr;
        }

        /// <summary>
        /// Display opened file content to FastColoredTextBox
        /// </summary>
        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var op = openFileDialog1;
            op.FileName = "untitled.txt";
            if (op.ShowDialog() != DialogResult.OK) return;

            _isFileCreated = true;
            _currentFile = op.FileName;
            FileNameToFormText(_currentFile);

            await ReadTextFromFile();
        }
        /// <summary>
        /// Save RichTextBox content to current file
        /// </summary>
        private void SaveFile()
        {
            File.WriteAllLines(_currentFile, MainTextField.Lines);
            _isFileSaved = true;
            _isFileCreated = true;
            SwitchFileSavedMark();
        }
        /// <summary>
        /// Save RichTextBox content to file
        /// </summary>
        /// <param name="FileName">Name of file to save to</param>
        private void SaveFile(string FileName)
        {
            File.WriteAllLines(FileName, MainTextField.Lines);
            _isFileCreated = true;
            _isFileSaved = true;
            SwitchFileSavedMark();
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
        #endregion
        #region Edit
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextField.Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextField.Redo();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextField.Cut();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextField.Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextField.Paste();
        }
        #endregion
        #region Theme
        /// <summary>
        /// Change theme of application to black
        /// </summary>
        public void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theme.syntaxColors!.SyntaxPath = "SyntaxColors/BlackSyntax.syn";
            CurrentTheme = Theme.Black;
            new ThemeChanger(this).ChangeTheme();

            whiteToolStripMenuItem.Checked = false;
            blackToolStripMenuItem.Checked = true;
        }
        /// <summary>
        /// Change theme of application to white
        /// </summary>
        public void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theme.syntaxColors!.SyntaxPath = "SyntaxColors/WhiteSyntax.syn";
            CurrentTheme = Theme.White;
            new ThemeChanger(this).ChangeTheme();

            whiteToolStripMenuItem.Checked = true;
            blackToolStripMenuItem.Checked = false;
        }
        #endregion


        /// <summary>
        ///  Deletes not default labels
        /// </summary>
        private void DeleteUnnecessaryLabels()
        {
            DeleteLineCountLabel();
            DeleteLineLabel();
            DeleteSymbolLabel();
            DeleteFileStatusLabel();
            DeleteSyntaxLabel();
            DeleteFontSizeLabel(); 
        }

        /// <summary>
        /// Switches file save mark ("*") in form text
        /// </summary>
        private void SwitchFileSavedMark()
        {
            switch (_isFileSaved)
            {
                case true:
                    {
                        MarkFileAsSaved();
                    }
                    break;
                case false:
                    {
                        MarkFileAsUnsaved();
                    }
                    break;
            }
        }
        /// <summary>
        /// Marks current opened file as unsaved
        /// </summary>
        private void MarkFileAsUnsaved()
        {
            this.Text += this.Text.Last() != '*' ? "*" : String.Empty;
            IsSavedLabel.Text = "File status: Unsaved";
        }
        /// <summary>
        /// Marks current opened file as saved
        /// </summary>
        private void MarkFileAsSaved()
        {
            FileNameToFormText(_currentFile);
            IsSavedLabel.Text = "File status: Saved";
        }

        /// <summary>
        /// Sets form text as App name and file opened name
        /// </summary>
        /// <param name="FileName">Name of file to set</param>
        private void FileNameToFormText(string FileName = "*") => this.Text = $"{_applicationName} | {Path.GetFileName(FileName)}";

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
        /// Get all status labels from form
        /// </summary>
        /// <returns>List of labels</returns>
        public IEnumerable<ToolStripStatusLabel> GetLabelsFromForm()
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
        /// Show OptionsForm dialog
        /// </summary>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OptionsForm(this).ShowDialog();
        }

        /// <summary>
        /// Deletes status label from footer and unchecks context menu item
        /// </summary>
        /// <param name="label">label to delete</param>
        /// <param name="item">context menu item to uncheck</param>
        private void DeleteStatusLabel(ToolStripStatusLabel label, ToolStripMenuItem item)
        {
            item.Checked = false;
            MainFooter.Items.Remove(label);
        }
        private void DeleteLineCountLabel()
        {
            DeleteStatusLabel(LineCountLable, linesToolStripMenuItem);
        }
        private void DeleteSymbolLabel()
        {
            DeleteStatusLabel(SymbolCountLable, symbolToolStripMenuItem);
        }
        private void DeleteLineLabel()
        {
            DeleteStatusLabel(CurrentLineLabel, currentLineToolStripMenuItem);
        }
        private void DeleteFileStatusLabel()
        {
            DeleteStatusLabel(IsSavedLabel, fileStatusToolStripMenuItem);
        }
        private void DeleteZoomLabel()
        {
            DeleteStatusLabel(zoomPercentageLabel, zoomToolStripMenuItem);
        }
        private void DeleteSyntaxLabel()
        {
            DeleteStatusLabel(syntaxLabel, syntaxToolStripMenuItem1);
        }

        private void DeleteFontSizeLabel()
        {
            DeleteStatusLabel(FontSizeLabel, fontSizeToolStripMenuItem);
        }

        /// <summary>
        /// Line count status switching
        /// </summary>
        private void linesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var label = LineCountLable;
            if (item.Checked)
            {
                DeleteLineCountLabel();
                return;
            }
            item.Checked = true;
            if (CurrentTheme == Theme.Black)
                label.ForeColor = Color.White;
            else
                label.ForeColor = Color.Black;
            label.Font = new Font(MainFooter.Font.FontFamily, MainTextField.Font.Size - 3, MainFooter.Font.Style);
            MainFooter.Items.Add(label);
        }
        /// <summary>
        /// Current symbol status switching
        /// </summary>
        private void symbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var label = SymbolCountLable;
            if (item.Checked)
            {
                DeleteSymbolLabel();
                return;
            }
            item.Checked = true;
            if (CurrentTheme == Theme.Black)
                label.ForeColor = Color.White;
            else
                label.ForeColor = Color.Black;
            label.Font = new Font(MainFooter.Font.FontFamily, MainTextField.Font.Size - 3, MainFooter.Font.Style);
            MainFooter.Items.Add(SymbolCountLable);
        }
        /// <summary>
        /// Current line status switching
        /// </summary>
        private void currentLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var label = CurrentLineLabel;
            if (item.Checked)
            {
                DeleteLineLabel();
                return;
            }
            item.Checked = true;
            if (CurrentTheme == Theme.Black)
                label.ForeColor = Color.White;
            else
                label.ForeColor = Color.Black;
            label.Font = new Font(MainFooter.Font.FontFamily, MainTextField.Font.Size - 3, MainFooter.Font.Style);
            MainFooter.Items.Add(CurrentLineLabel);
        }
        /// <summary>
        /// Current file status label switching
        /// </summary>
        private void fileStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var label = IsSavedLabel;
            if (item.Checked)
            {
                DeleteFileStatusLabel();
                return;
            }
            item.Checked = true;
            if (CurrentTheme == Theme.Black)
                label.ForeColor = Color.White;
            else
                label.ForeColor = Color.Black;
            label.Font = new Font(MainFooter.Font.FontFamily, MainTextField.Font.Size - 3, MainFooter.Font.Style);
            MainFooter.Items.Add(label);
        }
        /// <summary>
        /// Zoom status label switching
        /// </summary>
        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var button = zoomPercentageLabel;
            if (item.Checked)
            {
                DeleteZoomLabel();
                return;
            }
            item.Checked = true;
            if (CurrentTheme == Theme.Black)
                button.ForeColor = Color.White;
            else
                button.ForeColor = Color.Black;
            button.Font = new Font(MainFooter.Font.FontFamily, MainTextField.Font.Size - 3, MainFooter.Font.Style);
            MainFooter.Items.Add(button);
        }
        private void syntaxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var button = syntaxLabel;
            if (item.Checked)
            {
                DeleteSyntaxLabel();
                return;
            }
            item.Checked = true;
            if (CurrentTheme == Theme.Black)
                button.ForeColor = Color.White;
            else
                button.ForeColor = Color.Black;
            button.Font = new Font(MainFooter.Font.FontFamily, MainTextField.Font.Size - 3, MainFooter.Font.Style);
            MainFooter.Items.Add(button);
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var label = FontSizeLabel;
            if (item.Checked)
            {
                DeleteFontSizeLabel();
                return;
            }
            label.Text = $"Font size: {MainTextField.Font.Size}";
            item.Checked = true;
            if (CurrentTheme == Theme.Black)
                label.ForeColor = Color.White;
            else
                label.ForeColor = Color.Black;
            label.Font = new Font(MainFooter.Font.FontFamily, MainTextField.Font.Size - 3, MainFooter.Font.Style);
            MainFooter.Items.Add(label);
        }

        /// <summary>
        /// Set the selection details into status labels
        /// </summary>
        private void MainTextField_SelectionChanged(object sender, EventArgs e)
        {
            SymbolCountLable.Text = $"Current symbol: {MainTextField.Selection.Start.iChar}";
            CurrentLineLabel.Text = $"Current line: {MainTextField.Selection.Start.iLine + 1}";
        }

        /// <summary>
        /// Occurs when content of MainTextField changes somehow
        /// </summary>
        private void MainTextField_OnContentChanged()
        {
            LineCountLable.Text = $"Lines: {MainTextField.Lines.Count}";
            _isFileSaved = false;
            SwitchFileSavedMark();
        }
        private void MainTextField_TextChanged(object sender, TextChangedEventArgs e)
        {
            MainTextField_OnContentChanged();
        }
        private void MainTextField_LineInserted(object sender, LineInsertedEventArgs e)
        {
            MainTextField_OnContentChanged();
        }
        private void MainTextField_LineRemoved(object sender, LineRemovedEventArgs e)
        {
            MainTextField_OnContentChanged();
        }

        private void MainTextField_ZoomChanged(object sender, EventArgs e)
        {
            var zoom = MainTextField.Zoom;
            zoomPercentageLabel.Text = $"Zoom: {zoom}%";
        }

        private void zoomPercentageLabel_Click(object sender, EventArgs e)
        {
            MainTextField.Zoom = DefaultZoom;
        }

        /// <summary>
        /// Shows message box on form closing if file is unsaved to confirm closing with or without save
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_currentFile != String.Empty)
            {
                if (!_isFileSaved)
                {
                    DialogRes AskToSave = new DialogRes(MessageBox.Show);
                    var result = AskToSave("Do you want to save your file?", "Save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        SaveFile();
                        return;
                    }

                    /// If user wants to cancel the operation of closing
                    /// We use "FormClosingEvents" object and set its property "Cancel" to true
                    if (result == DialogResult.Cancel)
                        e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Switch state of window
        /// </summary>
        private void screenModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;

            switch (StateOfWindow)
            {
                case Enums.WindowState.Windowed:
                    {
                        FormBorderStyle = FormBorderStyle.None;
                        WindowState = FormWindowState.Maximized;

                        item.Text = $"Switch to {StateOfWindow}";
                        StateOfWindow = Enums.WindowState.Fullscreen;

                    }
                    break;
                case Enums.WindowState.Fullscreen:
                    {
                        FormBorderStyle = FormBorderStyle.Sizable;
                        WindowState = FormWindowState.Normal;

                        item.Text = $"Switch to {StateOfWindow}";

                        StateOfWindow = Enums.WindowState.Windowed;
                    }
                    break;
            }
        }

        private void templatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var templatesForm = new TemplatesForm(MainTextField);
            templatesForm.ShowDialog();

            if (templatesForm.IsTemplatesChanged)
            {
                LoadTemplatesToolStrips();

                new ThemeChanger(this).ChangeHeaderTheme(theme);
            }

        }

        private void OnTemplateClick(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            string templateName = item.Text.Substring(0, 9);
            Template temp;
            try
            {
                temp = JsonSerializer.Deserialize<Template>(File.ReadAllText($"Templates/{templateName}.json"))!;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Template file(s) was not found!\nThe menu item will be removed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                templatesToolStripMenuItem.DropDownItems.Remove(item);
                return;
            }

            if (MainTextField.Language == temp.Language)
            {
                try
                {
                    MainTextField.InsertText(File.ReadAllText($"Templates/{templateName}.txt"));
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Template file(s) was not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                return;
            }
            MessageBox.Show("Wrong language selected at Main Text Field", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DeleteTemplatesToolStrips()
        {
            templatesToolStripMenuItem.DropDownItems.Clear();
            templatesToolStripMenuItem.DropDownItems.Add("Configuration", null, templatesToolStripMenuItem_Click!);
        }

        private void LoadTemplatesToolStrips()
        {
            var dir = new DirectoryInfo("Templates");
            var files = dir.GetFiles();

            var infoFiles = files.Where(value => value.Extension == ".json");

            List<Template> infoFilesDeserialized = new List<Template>();

            foreach (var file in infoFiles)
            {
                try
                {
                    infoFilesDeserialized.Add(JsonSerializer.Deserialize<Template>(File.ReadAllText(file.FullName))!);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Template file(s) was not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DeleteTemplatesToolStrips();
            int count = files.Length / 2;
            for (int i = 0; i < count; i++)
            {
                templatesToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem($"Template{infoFilesDeserialized[i].Number} - {infoFilesDeserialized[i].Name} ({infoFilesDeserialized[i].Language})", null, OnTemplateClick!));
            }
        }

        #region Font
        public void SetFontSizeForEverything(float fontSize)
        {
            SetFontSizeForMainTextField(fontSize);
            SetFontSizeForHeader(fontSize);
            SetFontSizeForFooter(fontSize);
        }
        public void SetFontSizeForMainTextField(float fontSize)
        {
            MainTextField.Font = new Font(MainTextField.Font.FontFamily, fontSize, MainTextField.Font.Style);
        }
        public void SetFontSizeForHeader(float fontSize)
        {
            foreach (ToolStripItem item in MainHeader.Items)
            {
                item.Font = new Font(MainHeader.Font.FontFamily, fontSize - 3, MainHeader.Font.Style);
            }
        }
        public void SetFontSizeForFooter(float fontSize)
        {
            foreach (ToolStripItem item in MainFooter.Items)
            {
                item.Font = new Font(MainHeader.Font.FontFamily, fontSize - 3, MainHeader.Font.Style);
            }
        } 
        #endregion


        #endregion
    }
}
