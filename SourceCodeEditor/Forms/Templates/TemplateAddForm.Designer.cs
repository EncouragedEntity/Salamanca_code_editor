namespace SourceCodeEditor.Forms.Templates
{
    partial class TemplateAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateAddForm));
            panel1 = new Panel();
            buttonBack = new Button();
            buttonAdd = new Button();
            panel2 = new Panel();
            comboBoxLanguages = new ComboBox();
            labelLanguage = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 64);
            panel1.TabIndex = 1;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.Location = new Point(12, 23);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdd.Location = new Point(462, 23);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBoxLanguages);
            panel2.Controls.Add(labelLanguage);
            panel2.Controls.Add(textBoxName);
            panel2.Controls.Add(labelName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(568, 67);
            panel2.TabIndex = 2;
            // 
            // comboBoxLanguages
            // 
            comboBoxLanguages.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguages.FormattingEnabled = true;
            comboBoxLanguages.Items.AddRange(new object[] { "Custom", "CSharp", "VB", "HTML", "XML", "SQL", "PHP", "JS", "Lua" });
            comboBoxLanguages.Location = new Point(408, 24);
            comboBoxLanguages.Name = "comboBoxLanguages";
            comboBoxLanguages.Size = new Size(139, 28);
            comboBoxLanguages.TabIndex = 3;
            comboBoxLanguages.SelectedIndexChanged += comboBoxLanguages_SelectedIndexChanged;
            // 
            // labelLanguage
            // 
            labelLanguage.Anchor = AnchorStyles.Right;
            labelLanguage.AutoSize = true;
            labelLanguage.Location = new Point(321, 27);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(81, 20);
            labelLanguage.TabIndex = 2;
            labelLanguage.Text = "Language: ";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(61, 24);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(109, 27);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Template";
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Location = new Point(3, 27);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // fastColoredTextBox1
            // 
            fastColoredTextBox1.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            fastColoredTextBox1.AutoScrollMinSize = new Size(31, 18);
            fastColoredTextBox1.BackBrush = null;
            fastColoredTextBox1.CharHeight = 18;
            fastColoredTextBox1.CharWidth = 10;
            fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fastColoredTextBox1.Dock = DockStyle.Fill;
            fastColoredTextBox1.IsReplaceMode = false;
            fastColoredTextBox1.Location = new Point(0, 67);
            fastColoredTextBox1.Name = "fastColoredTextBox1";
            fastColoredTextBox1.Paddings = new Padding(0);
            fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            fastColoredTextBox1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors");
            fastColoredTextBox1.Size = new Size(568, 319);
            fastColoredTextBox1.TabIndex = 3;
            fastColoredTextBox1.Zoom = 100;
            fastColoredTextBox1.TextChanged += fastColoredTextBox1_TextChanged;
            // 
            // TemplateAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(fastColoredTextBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TemplateAddForm";
            Text = "New Template";
            FormClosing += TemplateAddForm_FormClosing;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelLanguage;
        private ComboBox comboBoxLanguages;
        private Button buttonBack;
        private Button buttonAdd;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    }
}