namespace SourceCodeEditor.UserControls
{
    partial class GeneralOptionsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxZoom = new GroupBox();
            buttonToDefault = new Button();
            label2 = new Label();
            numericUpDownActualZoom = new NumericUpDown();
            buttonToHundred = new Button();
            numericUpDownDefaultZoom = new NumericUpDown();
            label1 = new Label();
            panel1 = new Panel();
            buttonDiscard = new Button();
            buttonSave = new Button();
            groupBoxFont = new GroupBox();
            numericUpDownFontSize = new NumericUpDown();
            label3 = new Label();
            fontDialog1 = new FontDialog();
            groupBoxZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownActualZoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDefaultZoom).BeginInit();
            panel1.SuspendLayout();
            groupBoxFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).BeginInit();
            SuspendLayout();
            // 
            // groupBoxZoom
            // 
            groupBoxZoom.Controls.Add(buttonToDefault);
            groupBoxZoom.Controls.Add(label2);
            groupBoxZoom.Controls.Add(numericUpDownActualZoom);
            groupBoxZoom.Controls.Add(buttonToHundred);
            groupBoxZoom.Controls.Add(numericUpDownDefaultZoom);
            groupBoxZoom.Controls.Add(label1);
            groupBoxZoom.Dock = DockStyle.Top;
            groupBoxZoom.Location = new Point(0, 0);
            groupBoxZoom.Name = "groupBoxZoom";
            groupBoxZoom.Size = new Size(482, 138);
            groupBoxZoom.TabIndex = 0;
            groupBoxZoom.TabStop = false;
            groupBoxZoom.Text = "Zoom";
            // 
            // buttonToDefault
            // 
            buttonToDefault.Location = new Point(162, 103);
            buttonToDefault.Name = "buttonToDefault";
            buttonToDefault.Size = new Size(94, 29);
            buttonToDefault.TabIndex = 5;
            buttonToDefault.Text = "to default";
            buttonToDefault.UseVisualStyleBackColor = true;
            buttonToDefault.Click += buttonToDefault_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 4;
            label2.Text = "Actual zoom value:";
            // 
            // numericUpDownActualZoom
            // 
            numericUpDownActualZoom.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownActualZoom.Location = new Point(6, 105);
            numericUpDownActualZoom.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            numericUpDownActualZoom.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownActualZoom.Name = "numericUpDownActualZoom";
            numericUpDownActualZoom.Size = new Size(150, 27);
            numericUpDownActualZoom.TabIndex = 3;
            numericUpDownActualZoom.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownActualZoom.KeyDown += numericUpDown1_KeyDown;
            // 
            // buttonToHundred
            // 
            buttonToHundred.Location = new Point(162, 46);
            buttonToHundred.Name = "buttonToHundred";
            buttonToHundred.Size = new Size(59, 29);
            buttonToHundred.TabIndex = 2;
            buttonToHundred.Text = "to 100";
            buttonToHundred.UseVisualStyleBackColor = true;
            buttonToHundred.Click += buttonToHundred_Click;
            // 
            // numericUpDownDefaultZoom
            // 
            numericUpDownDefaultZoom.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownDefaultZoom.Location = new Point(6, 46);
            numericUpDownDefaultZoom.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            numericUpDownDefaultZoom.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownDefaultZoom.Name = "numericUpDownDefaultZoom";
            numericUpDownDefaultZoom.Size = new Size(150, 27);
            numericUpDownDefaultZoom.TabIndex = 1;
            numericUpDownDefaultZoom.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownDefaultZoom.KeyDown += numericUpDown1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Default zoom value:";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDiscard);
            panel1.Controls.Add(buttonSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 464);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 48);
            panel1.TabIndex = 1;
            // 
            // buttonDiscard
            // 
            buttonDiscard.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDiscard.Location = new Point(285, 16);
            buttonDiscard.Name = "buttonDiscard";
            buttonDiscard.Size = new Size(94, 29);
            buttonDiscard.TabIndex = 1;
            buttonDiscard.Text = "Discard";
            buttonDiscard.UseVisualStyleBackColor = true;
            buttonDiscard.Click += buttonDiscard_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Location = new Point(385, 16);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupBoxFont
            // 
            groupBoxFont.Controls.Add(numericUpDownFontSize);
            groupBoxFont.Controls.Add(label3);
            groupBoxFont.Dock = DockStyle.Top;
            groupBoxFont.Location = new Point(0, 138);
            groupBoxFont.Name = "groupBoxFont";
            groupBoxFont.Size = new Size(482, 153);
            groupBoxFont.TabIndex = 2;
            groupBoxFont.TabStop = false;
            groupBoxFont.Text = "Font";
            // 
            // numericUpDownFontSize
            // 
            numericUpDownFontSize.DecimalPlaces = 2;
            numericUpDownFontSize.Location = new Point(6, 49);
            numericUpDownFontSize.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            numericUpDownFontSize.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownFontSize.Name = "numericUpDownFontSize";
            numericUpDownFontSize.Size = new Size(150, 27);
            numericUpDownFontSize.TabIndex = 3;
            numericUpDownFontSize.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Font size:";
            // 
            // fontDialog1
            // 
            fontDialog1.AllowScriptChange = false;
            fontDialog1.AllowSimulations = false;
            fontDialog1.AllowVectorFonts = false;
            fontDialog1.AllowVerticalFonts = false;
            fontDialog1.FixedPitchOnly = true;
            // 
            // GeneralOptionsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(groupBoxFont);
            Controls.Add(panel1);
            Controls.Add(groupBoxZoom);
            Name = "GeneralOptionsControl";
            Size = new Size(482, 512);
            Load += GeneralOptionsControl_Load;
            groupBoxZoom.ResumeLayout(false);
            groupBoxZoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownActualZoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDefaultZoom).EndInit();
            panel1.ResumeLayout(false);
            groupBoxFont.ResumeLayout(false);
            groupBoxFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxZoom;
        private NumericUpDown numericUpDownDefaultZoom;
        private Label label1;
        private Panel panel1;
        private Button buttonDiscard;
        private Button buttonSave;
        private Button buttonToHundred;
        private NumericUpDown numericUpDownActualZoom;
        private Label label2;
        private Button buttonToDefault;
        private GroupBox groupBoxFont;
        private FontDialog fontDialog1;
        private NumericUpDown numericUpDownFontSize;
        private Label label3;
    }
}
