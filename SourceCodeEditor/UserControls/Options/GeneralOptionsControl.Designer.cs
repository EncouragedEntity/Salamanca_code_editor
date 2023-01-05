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
            this.groupBoxZoom = new System.Windows.Forms.GroupBox();
            this.buttonToDefault = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownActualZoom = new System.Windows.Forms.NumericUpDown();
            this.buttonToHundred = new System.Windows.Forms.Button();
            this.numericUpDownDefaultZoom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.buttonFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBoxZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActualZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefaultZoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxZoom
            // 
            this.groupBoxZoom.Controls.Add(this.buttonToDefault);
            this.groupBoxZoom.Controls.Add(this.label2);
            this.groupBoxZoom.Controls.Add(this.numericUpDownActualZoom);
            this.groupBoxZoom.Controls.Add(this.buttonToHundred);
            this.groupBoxZoom.Controls.Add(this.numericUpDownDefaultZoom);
            this.groupBoxZoom.Controls.Add(this.label1);
            this.groupBoxZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxZoom.Location = new System.Drawing.Point(0, 0);
            this.groupBoxZoom.Name = "groupBoxZoom";
            this.groupBoxZoom.Size = new System.Drawing.Size(482, 138);
            this.groupBoxZoom.TabIndex = 0;
            this.groupBoxZoom.TabStop = false;
            this.groupBoxZoom.Text = "Zoom";
            // 
            // buttonToDefault
            // 
            this.buttonToDefault.Location = new System.Drawing.Point(162, 103);
            this.buttonToDefault.Name = "buttonToDefault";
            this.buttonToDefault.Size = new System.Drawing.Size(94, 29);
            this.buttonToDefault.TabIndex = 5;
            this.buttonToDefault.Text = "to default";
            this.buttonToDefault.UseVisualStyleBackColor = true;
            this.buttonToDefault.Click += new System.EventHandler(this.buttonToDefault_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actual zoom value:";
            // 
            // numericUpDownActualZoom
            // 
            this.numericUpDownActualZoom.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownActualZoom.Location = new System.Drawing.Point(6, 105);
            this.numericUpDownActualZoom.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownActualZoom.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownActualZoom.Name = "numericUpDownActualZoom";
            this.numericUpDownActualZoom.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownActualZoom.TabIndex = 3;
            this.numericUpDownActualZoom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownActualZoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // buttonToHundred
            // 
            this.buttonToHundred.Location = new System.Drawing.Point(162, 46);
            this.buttonToHundred.Name = "buttonToHundred";
            this.buttonToHundred.Size = new System.Drawing.Size(59, 29);
            this.buttonToHundred.TabIndex = 2;
            this.buttonToHundred.Text = "to 100";
            this.buttonToHundred.UseVisualStyleBackColor = true;
            this.buttonToHundred.Click += new System.EventHandler(this.buttonToHundred_Click);
            // 
            // numericUpDownDefaultZoom
            // 
            this.numericUpDownDefaultZoom.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDefaultZoom.Location = new System.Drawing.Point(6, 46);
            this.numericUpDownDefaultZoom.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownDefaultZoom.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDefaultZoom.Name = "numericUpDownDefaultZoom";
            this.numericUpDownDefaultZoom.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownDefaultZoom.TabIndex = 1;
            this.numericUpDownDefaultZoom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDefaultZoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default zoom value:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDiscard);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 48);
            this.panel1.TabIndex = 1;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiscard.Location = new System.Drawing.Point(285, 16);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(94, 29);
            this.buttonDiscard.TabIndex = 1;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(385, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxFont
            // 
            this.groupBoxFont.Controls.Add(this.buttonFont);
            this.groupBoxFont.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFont.Location = new System.Drawing.Point(0, 138);
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.Size = new System.Drawing.Size(482, 153);
            this.groupBoxFont.TabIndex = 2;
            this.groupBoxFont.TabStop = false;
            this.groupBoxFont.Text = "Font";
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(6, 36);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(135, 29);
            this.buttonFont.TabIndex = 0;
            this.buttonFont.Text = "Choose font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.AllowScriptChange = false;
            this.fontDialog1.AllowSimulations = false;
            this.fontDialog1.AllowVectorFonts = false;
            this.fontDialog1.AllowVerticalFonts = false;
            this.fontDialog1.FixedPitchOnly = true;
            // 
            // GeneralOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.groupBoxFont);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxZoom);
            this.Name = "GeneralOptionsControl";
            this.Size = new System.Drawing.Size(482, 512);
            this.Load += new System.EventHandler(this.GeneralOptionsControl_Load);
            this.groupBoxZoom.ResumeLayout(false);
            this.groupBoxZoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActualZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefaultZoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxFont.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Button buttonFont;
    }
}
