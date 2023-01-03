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
            this.buttonToHundred = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxZoom
            // 
            this.groupBoxZoom.Controls.Add(this.buttonToHundred);
            this.groupBoxZoom.Controls.Add(this.numericUpDown1);
            this.groupBoxZoom.Controls.Add(this.label1);
            this.groupBoxZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxZoom.Location = new System.Drawing.Point(0, 0);
            this.groupBoxZoom.Name = "groupBoxZoom";
            this.groupBoxZoom.Size = new System.Drawing.Size(482, 125);
            this.groupBoxZoom.TabIndex = 0;
            this.groupBoxZoom.TabStop = false;
            this.groupBoxZoom.Text = "Zoom";
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
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(6, 46);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
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
            this.panel1.Location = new System.Drawing.Point(0, 290);
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
            // GeneralOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxZoom);
            this.Name = "GeneralOptionsControl";
            this.Size = new System.Drawing.Size(482, 338);
            this.Load += new System.EventHandler(this.GeneralOptionsControl_Load);
            this.groupBoxZoom.ResumeLayout(false);
            this.groupBoxZoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxZoom;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Panel panel1;
        private Button buttonDiscard;
        private Button buttonSave;
        private Button buttonToHundred;
    }
}
