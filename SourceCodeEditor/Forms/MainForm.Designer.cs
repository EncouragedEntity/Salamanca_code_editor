using FastColoredTextBoxNS;

namespace SourceCodeEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainHeader = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            screenModeToolStripMenuItem = new ToolStripMenuItem();
            syntaxToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            templatesToolStripMenuItem = new ToolStripMenuItem();
            configurationToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            MainTextField = new FastColoredTextBox();
            MainFooter = new StatusStrip();
            FooterContext = new ContextMenuStrip(components);
            linesToolStripMenuItem = new ToolStripMenuItem();
            symbolToolStripMenuItem = new ToolStripMenuItem();
            currentLineToolStripMenuItem = new ToolStripMenuItem();
            fileStatusToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            syntaxToolStripMenuItem1 = new ToolStripMenuItem();
            LineCountLable = new ToolStripStatusLabel();
            SymbolCountLable = new ToolStripStatusLabel();
            CurrentLineLabel = new ToolStripStatusLabel();
            IsSavedLabel = new ToolStripStatusLabel();
            zoomPercentageLabel = new ToolStripStatusLabel();
            syntaxLabel = new ToolStripStatusLabel();
            MainHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainTextField).BeginInit();
            MainFooter.SuspendLayout();
            FooterContext.SuspendLayout();
            SuspendLayout();
            // 
            // MainHeader
            // 
            MainHeader.BackColor = Color.FromArgb(50, 50, 50);
            MainHeader.ForeColor = Color.White;
            MainHeader.ImageScalingSize = new Size(20, 20);
            MainHeader.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, templatesToolStripMenuItem });
            MainHeader.Location = new Point(0, 0);
            MainHeader.Name = "MainHeader";
            MainHeader.Size = new Size(800, 28);
            MainHeader.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            openToolStripMenuItem.Size = new Size(247, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            newToolStripMenuItem.Size = new Size(247, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            saveToolStripMenuItem.Size = new Size(247, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Shift + S";
            saveAsToolStripMenuItem.Size = new Size(247, 26);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(224, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(224, 26);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(224, 26);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(224, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(224, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themeToolStripMenuItem, screenModeToolStripMenuItem, syntaxToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.BackColor = SystemColors.Control;
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blackToolStripMenuItem, whiteToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.ShowShortcutKeys = false;
            themeToolStripMenuItem.Size = new Size(224, 26);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Checked = true;
            blackToolStripMenuItem.CheckState = CheckState.Checked;
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(131, 26);
            blackToolStripMenuItem.Text = "Black";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new Size(131, 26);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // screenModeToolStripMenuItem
            // 
            screenModeToolStripMenuItem.Name = "screenModeToolStripMenuItem";
            screenModeToolStripMenuItem.Size = new Size(224, 26);
            screenModeToolStripMenuItem.Text = "Switch to Fullscreen";
            screenModeToolStripMenuItem.Click += screenModeToolStripMenuItem_Click;
            // 
            // syntaxToolStripMenuItem
            // 
            syntaxToolStripMenuItem.Name = "syntaxToolStripMenuItem";
            syntaxToolStripMenuItem.Size = new Size(224, 26);
            syntaxToolStripMenuItem.Text = "Syntax";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(224, 26);
            optionsToolStripMenuItem.Text = "Options";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // templatesToolStripMenuItem
            // 
            templatesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configurationToolStripMenuItem });
            templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            templatesToolStripMenuItem.Size = new Size(91, 24);
            templatesToolStripMenuItem.Text = "Templates";
            // 
            // configurationToolStripMenuItem
            // 
            configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            configurationToolStripMenuItem.Size = new Size(183, 26);
            configurationToolStripMenuItem.Text = "Configuration";
            configurationToolStripMenuItem.Click += templatesToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainTextField
            // 
            MainTextField.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            MainTextField.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            MainTextField.AutoScrollMinSize = new Size(35, 22);
            MainTextField.BackBrush = null;
            MainTextField.BackColor = Color.FromArgb(80, 80, 80);
            MainTextField.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
            MainTextField.CharHeight = 22;
            MainTextField.CharWidth = 12;
            MainTextField.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            MainTextField.Dock = DockStyle.Fill;
            MainTextField.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainTextField.ForeColor = Color.White;
            MainTextField.Hotkeys = resources.GetString("MainTextField.Hotkeys");
            MainTextField.IndentBackColor = Color.FromArgb(50, 50, 50);
            MainTextField.IsReplaceMode = false;
            MainTextField.LeftBracket = '(';
            MainTextField.LeftBracket2 = '{';
            MainTextField.LineNumberColor = Color.Silver;
            MainTextField.Location = new Point(0, 28);
            MainTextField.Name = "MainTextField";
            MainTextField.Paddings = new Padding(0);
            MainTextField.RightBracket = ')';
            MainTextField.RightBracket2 = '}';
            MainTextField.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            MainTextField.ServiceColors = (ServiceColors)resources.GetObject("MainTextField.ServiceColors");
            MainTextField.Size = new Size(800, 422);
            MainTextField.TabIndex = 3;
            MainTextField.Zoom = 100;
            MainTextField.TextChanged += MainTextField_TextChanged;
            MainTextField.SelectionChanged += MainTextField_SelectionChanged;
            MainTextField.LineInserted += MainTextField_LineInserted;
            MainTextField.LineRemoved += MainTextField_LineRemoved;
            MainTextField.ZoomChanged += MainTextField_ZoomChanged;
            // 
            // MainFooter
            // 
            MainFooter.BackColor = Color.FromArgb(50, 50, 50);
            MainFooter.ContextMenuStrip = FooterContext;
            MainFooter.ImageScalingSize = new Size(20, 20);
            MainFooter.Items.AddRange(new ToolStripItem[] { LineCountLable, SymbolCountLable, CurrentLineLabel, IsSavedLabel, zoomPercentageLabel, syntaxLabel });
            MainFooter.Location = new Point(0, 424);
            MainFooter.Name = "MainFooter";
            MainFooter.Size = new Size(800, 26);
            MainFooter.TabIndex = 4;
            MainFooter.Text = "statusStrip1";
            // 
            // FooterContext
            // 
            FooterContext.ImageScalingSize = new Size(20, 20);
            FooterContext.Items.AddRange(new ToolStripItem[] { linesToolStripMenuItem, symbolToolStripMenuItem, currentLineToolStripMenuItem, fileStatusToolStripMenuItem, zoomToolStripMenuItem, syntaxToolStripMenuItem1 });
            FooterContext.Name = "contextMenuStrip1";
            FooterContext.Size = new Size(179, 160);
            // 
            // linesToolStripMenuItem
            // 
            linesToolStripMenuItem.Checked = true;
            linesToolStripMenuItem.CheckState = CheckState.Checked;
            linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            linesToolStripMenuItem.Size = new Size(178, 26);
            linesToolStripMenuItem.Text = "Lines";
            linesToolStripMenuItem.Click += linesToolStripMenuItem_Click;
            // 
            // symbolToolStripMenuItem
            // 
            symbolToolStripMenuItem.Checked = true;
            symbolToolStripMenuItem.CheckState = CheckState.Checked;
            symbolToolStripMenuItem.Name = "symbolToolStripMenuItem";
            symbolToolStripMenuItem.Size = new Size(178, 26);
            symbolToolStripMenuItem.Text = "Current symbol";
            symbolToolStripMenuItem.Click += symbolToolStripMenuItem_Click;
            // 
            // currentLineToolStripMenuItem
            // 
            currentLineToolStripMenuItem.Checked = true;
            currentLineToolStripMenuItem.CheckState = CheckState.Checked;
            currentLineToolStripMenuItem.Name = "currentLineToolStripMenuItem";
            currentLineToolStripMenuItem.Size = new Size(178, 26);
            currentLineToolStripMenuItem.Text = "Current line";
            currentLineToolStripMenuItem.Click += currentLineToolStripMenuItem_Click;
            // 
            // fileStatusToolStripMenuItem
            // 
            fileStatusToolStripMenuItem.Checked = true;
            fileStatusToolStripMenuItem.CheckState = CheckState.Checked;
            fileStatusToolStripMenuItem.Name = "fileStatusToolStripMenuItem";
            fileStatusToolStripMenuItem.Size = new Size(178, 26);
            fileStatusToolStripMenuItem.Text = "File status";
            fileStatusToolStripMenuItem.Click += fileStatusToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Checked = true;
            zoomToolStripMenuItem.CheckState = CheckState.Checked;
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(178, 26);
            zoomToolStripMenuItem.Text = " Zoom";
            zoomToolStripMenuItem.Click += zoomToolStripMenuItem_Click;
            // 
            // syntaxToolStripMenuItem1
            // 
            syntaxToolStripMenuItem1.Checked = true;
            syntaxToolStripMenuItem1.CheckState = CheckState.Checked;
            syntaxToolStripMenuItem1.Name = "syntaxToolStripMenuItem1";
            syntaxToolStripMenuItem1.Size = new Size(178, 26);
            syntaxToolStripMenuItem1.Text = "Syntax";
            syntaxToolStripMenuItem1.Click += syntaxToolStripMenuItem1_Click;
            // 
            // LineCountLable
            // 
            LineCountLable.ForeColor = Color.White;
            LineCountLable.Name = "LineCountLable";
            LineCountLable.Size = new Size(57, 20);
            LineCountLable.Text = "Lines: 0";
            // 
            // SymbolCountLable
            // 
            SymbolCountLable.ForeColor = Color.White;
            SymbolCountLable.Name = "SymbolCountLable";
            SymbolCountLable.Size = new Size(124, 20);
            SymbolCountLable.Text = "Current symbol: 0";
            // 
            // CurrentLineLabel
            // 
            CurrentLineLabel.ForeColor = Color.White;
            CurrentLineLabel.Name = "CurrentLineLabel";
            CurrentLineLabel.Size = new Size(100, 20);
            CurrentLineLabel.Text = "Current line: 0";
            // 
            // IsSavedLabel
            // 
            IsSavedLabel.ForeColor = Color.White;
            IsSavedLabel.Name = "IsSavedLabel";
            IsSavedLabel.Size = new Size(137, 20);
            IsSavedLabel.Text = "File status: Unsaved";
            // 
            // zoomPercentageLabel
            // 
            zoomPercentageLabel.AutoToolTip = true;
            zoomPercentageLabel.ForeColor = Color.White;
            zoomPercentageLabel.Name = "zoomPercentageLabel";
            zoomPercentageLabel.Size = new Size(92, 20);
            zoomPercentageLabel.Text = "Zoom: 100%";
            zoomPercentageLabel.ToolTipText = "Click to set to default";
            zoomPercentageLabel.Click += zoomPercentageLabel_Click;
            // 
            // syntaxLabel
            // 
            syntaxLabel.ForeColor = Color.White;
            syntaxLabel.Name = "syntaxLabel";
            syntaxLabel.Size = new Size(109, 20);
            syntaxLabel.Text = "Syntax: Custom";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainFooter);
            Controls.Add(MainTextField);
            Controls.Add(MainHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = MainHeader;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salamanca | *";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            MainHeader.ResumeLayout(false);
            MainHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainTextField).EndInit();
            MainFooter.ResumeLayout(false);
            MainFooter.PerformLayout();
            FooterContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public MenuStrip MainHeader;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem viewToolStripMenuItem;
        public FastColoredTextBox MainTextField;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        public StatusStrip MainFooter;
        private ToolStripStatusLabel LineCountLable;
        private ContextMenuStrip FooterContext;
        private ToolStripMenuItem linesToolStripMenuItem;
        private ToolStripMenuItem symbolToolStripMenuItem;
        private ToolStripStatusLabel SymbolCountLable;
        private ToolStripStatusLabel CurrentLineLabel;
        private ToolStripMenuItem currentLineToolStripMenuItem;
        private ToolStripStatusLabel IsSavedLabel;
        private ToolStripMenuItem fileStatusToolStripMenuItem;
        private ToolStripMenuItem screenModeToolStripMenuItem;
        public ToolStripMenuItem syntaxToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripStatusLabel zoomPercentageLabel;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        public ToolStripStatusLabel syntaxLabel;
        private ToolStripMenuItem syntaxToolStripMenuItem1;
        private ToolStripMenuItem templatesToolStripMenuItem;
        private ToolStripMenuItem configurationToolStripMenuItem;
    }
}