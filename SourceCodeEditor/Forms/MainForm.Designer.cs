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
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MainTextField = new FastColoredTextBoxNS.FastColoredTextBox();
            this.MainFooter = new System.Windows.Forms.StatusStrip();
            this.FooterContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineCountLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.SymbolCountLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentLineLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.IsSavedLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.toolsToolStripMenuItem});
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
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
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
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
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
            this.MainTextField.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MainTextField.IsReplaceMode = false;
            this.MainTextField.Language = FastColoredTextBoxNS.Language.CSharp;
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
            this.IsSavedLabel});
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
            this.fileStatusToolStripMenuItem});
            this.FooterContext.Name = "contextMenuStrip1";
            this.FooterContext.Size = new System.Drawing.Size(179, 108);
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
        private MenuStrip MainHeader;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox MainTextField;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private StatusStrip MainFooter;
        private ToolStripStatusLabel LineCountLable;
        private ContextMenuStrip FooterContext;
        private ToolStripMenuItem linesToolStripMenuItem;
        private ToolStripMenuItem symbolToolStripMenuItem;
        private ToolStripStatusLabel SymbolCountLable;
        private ToolStripStatusLabel CurrentLineLabel;
        private ToolStripMenuItem currentLineToolStripMenuItem;
        private ToolStripStatusLabel IsSavedLabel;
        private ToolStripMenuItem fileStatusToolStripMenuItem;
    }
}