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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainHeader = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MainTextField = new FastColoredTextBoxNS.FastColoredTextBox();
            this.MainFooter = new System.Windows.Forms.StatusStrip();
            this.FooterContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LineCountLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.SymbolCountLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentLineLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.IsSavedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.zoomPercentageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.syntaxLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTextField)).BeginInit();
            this.MainFooter.SuspendLayout();
            this.FooterContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainHeader
            // 
            this.MainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MainHeader.ForeColor = System.Drawing.Color.White;
            this.MainHeader.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.templatesToolStripMenuItem});
            this.MainHeader.Location = new System.Drawing.Point(0, 0);
            this.MainHeader.Name = "MainHeader";
            this.MainHeader.Size = new System.Drawing.Size(800, 28);
            this.MainHeader.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Shift + S";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.screenModeToolStripMenuItem,
            this.syntaxToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.whiteToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.ShowShortcutKeys = false;
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Checked = true;
            this.blackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // screenModeToolStripMenuItem
            // 
            this.screenModeToolStripMenuItem.Name = "screenModeToolStripMenuItem";
            this.screenModeToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.screenModeToolStripMenuItem.Text = "Switch to Fullscreen";
            this.screenModeToolStripMenuItem.Click += new System.EventHandler(this.screenModeToolStripMenuItem_Click);
            // 
            // syntaxToolStripMenuItem
            // 
            this.syntaxToolStripMenuItem.Name = "syntaxToolStripMenuItem";
            this.syntaxToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.syntaxToolStripMenuItem.Text = "Syntax";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.templatesToolStripMenuItem.Text = "Templates";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainTextField
            // 
            this.MainTextField.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.MainTextField.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.MainTextField.AutoScrollMinSize = new System.Drawing.Size(35, 22);
            this.MainTextField.BackBrush = null;
            this.MainTextField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.MainTextField.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.MainTextField.CharHeight = 22;
            this.MainTextField.CharWidth = 12;
            this.MainTextField.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.MainTextField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTextField.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTextField.ForeColor = System.Drawing.Color.White;
            this.MainTextField.Hotkeys = resources.GetString("MainTextField.Hotkeys");
            this.MainTextField.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MainTextField.IsReplaceMode = false;
            this.MainTextField.LeftBracket = '(';
            this.MainTextField.LeftBracket2 = '{';
            this.MainTextField.LineNumberColor = System.Drawing.Color.Silver;
            this.MainTextField.Location = new System.Drawing.Point(0, 28);
            this.MainTextField.Name = "MainTextField";
            this.MainTextField.Paddings = new System.Windows.Forms.Padding(0);
            this.MainTextField.RightBracket = ')';
            this.MainTextField.RightBracket2 = '}';
            this.MainTextField.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.MainTextField.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("MainTextField.ServiceColors")));
            this.MainTextField.Size = new System.Drawing.Size(800, 422);
            this.MainTextField.TabIndex = 3;
            this.MainTextField.Zoom = 100;
            this.MainTextField.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.MainTextField_TextChanged);
            this.MainTextField.SelectionChanged += new System.EventHandler(this.MainTextField_SelectionChanged);
            this.MainTextField.LineInserted += new System.EventHandler<FastColoredTextBoxNS.LineInsertedEventArgs>(this.MainTextField_LineInserted);
            this.MainTextField.LineRemoved += new System.EventHandler<FastColoredTextBoxNS.LineRemovedEventArgs>(this.MainTextField_LineRemoved);
            this.MainTextField.ZoomChanged += new System.EventHandler(this.MainTextField_ZoomChanged);
            // 
            // MainFooter
            // 
            this.MainFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MainFooter.ContextMenuStrip = this.FooterContext;
            this.MainFooter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineCountLable,
            this.SymbolCountLable,
            this.CurrentLineLabel,
            this.IsSavedLabel,
            this.zoomPercentageLabel,
            this.syntaxLabel});
            this.MainFooter.Location = new System.Drawing.Point(0, 424);
            this.MainFooter.Name = "MainFooter";
            this.MainFooter.Size = new System.Drawing.Size(800, 26);
            this.MainFooter.TabIndex = 4;
            this.MainFooter.Text = "statusStrip1";
            // 
            // FooterContext
            // 
            this.FooterContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FooterContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linesToolStripMenuItem,
            this.symbolToolStripMenuItem,
            this.currentLineToolStripMenuItem,
            this.fileStatusToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.syntaxToolStripMenuItem1});
            this.FooterContext.Name = "contextMenuStrip1";
            this.FooterContext.Size = new System.Drawing.Size(179, 160);
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.Checked = true;
            this.linesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.linesToolStripMenuItem.Text = "Lines";
            this.linesToolStripMenuItem.Click += new System.EventHandler(this.linesToolStripMenuItem_Click);
            // 
            // symbolToolStripMenuItem
            // 
            this.symbolToolStripMenuItem.Checked = true;
            this.symbolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.symbolToolStripMenuItem.Name = "symbolToolStripMenuItem";
            this.symbolToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.symbolToolStripMenuItem.Text = "Current symbol";
            this.symbolToolStripMenuItem.Click += new System.EventHandler(this.symbolToolStripMenuItem_Click);
            // 
            // currentLineToolStripMenuItem
            // 
            this.currentLineToolStripMenuItem.Checked = true;
            this.currentLineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.currentLineToolStripMenuItem.Name = "currentLineToolStripMenuItem";
            this.currentLineToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.currentLineToolStripMenuItem.Text = "Current line";
            this.currentLineToolStripMenuItem.Click += new System.EventHandler(this.currentLineToolStripMenuItem_Click);
            // 
            // fileStatusToolStripMenuItem
            // 
            this.fileStatusToolStripMenuItem.Checked = true;
            this.fileStatusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileStatusToolStripMenuItem.Name = "fileStatusToolStripMenuItem";
            this.fileStatusToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.fileStatusToolStripMenuItem.Text = "File status";
            this.fileStatusToolStripMenuItem.Click += new System.EventHandler(this.fileStatusToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Checked = true;
            this.zoomToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.zoomToolStripMenuItem.Text = " Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // syntaxToolStripMenuItem1
            // 
            this.syntaxToolStripMenuItem1.Checked = true;
            this.syntaxToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.syntaxToolStripMenuItem1.Name = "syntaxToolStripMenuItem1";
            this.syntaxToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.syntaxToolStripMenuItem1.Text = "Syntax";
            this.syntaxToolStripMenuItem1.Click += new System.EventHandler(this.syntaxToolStripMenuItem1_Click);
            // 
            // LineCountLable
            // 
            this.LineCountLable.ForeColor = System.Drawing.Color.White;
            this.LineCountLable.Name = "LineCountLable";
            this.LineCountLable.Size = new System.Drawing.Size(57, 20);
            this.LineCountLable.Text = "Lines: 0";
            // 
            // SymbolCountLable
            // 
            this.SymbolCountLable.ForeColor = System.Drawing.Color.White;
            this.SymbolCountLable.Name = "SymbolCountLable";
            this.SymbolCountLable.Size = new System.Drawing.Size(124, 20);
            this.SymbolCountLable.Text = "Current symbol: 0";
            // 
            // CurrentLineLabel
            // 
            this.CurrentLineLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentLineLabel.Name = "CurrentLineLabel";
            this.CurrentLineLabel.Size = new System.Drawing.Size(100, 20);
            this.CurrentLineLabel.Text = "Current line: 0";
            // 
            // IsSavedLabel
            // 
            this.IsSavedLabel.ForeColor = System.Drawing.Color.White;
            this.IsSavedLabel.Name = "IsSavedLabel";
            this.IsSavedLabel.Size = new System.Drawing.Size(137, 20);
            this.IsSavedLabel.Text = "File status: Unsaved";
            // 
            // zoomPercentageLabel
            // 
            this.zoomPercentageLabel.AutoToolTip = true;
            this.zoomPercentageLabel.ForeColor = System.Drawing.Color.White;
            this.zoomPercentageLabel.Name = "zoomPercentageLabel";
            this.zoomPercentageLabel.Size = new System.Drawing.Size(92, 20);
            this.zoomPercentageLabel.Text = "Zoom: 100%";
            this.zoomPercentageLabel.ToolTipText = "Click to set to default";
            this.zoomPercentageLabel.Click += new System.EventHandler(this.zoomPercentageLabel_Click);
            // 
            // syntaxLabel
            // 
            this.syntaxLabel.ForeColor = System.Drawing.Color.White;
            this.syntaxLabel.Name = "syntaxLabel";
            this.syntaxLabel.Size = new System.Drawing.Size(109, 20);
            this.syntaxLabel.Text = "Syntax: Custom";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.templatesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainFooter);
            this.Controls.Add(this.MainTextField);
            this.Controls.Add(this.MainHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainHeader;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salamanca | *";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainHeader.ResumeLayout(false);
            this.MainHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTextField)).EndInit();
            this.MainFooter.ResumeLayout(false);
            this.MainFooter.PerformLayout();
            this.FooterContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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