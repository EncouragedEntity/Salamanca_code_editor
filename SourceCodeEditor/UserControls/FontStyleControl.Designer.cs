namespace SourceCodeEditor.UserControls
{
    partial class FontStyleControl
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
            this.checkBoxRegular = new System.Windows.Forms.CheckBox();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxUnderline = new System.Windows.Forms.CheckBox();
            this.checkBoxStrike = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxRegular
            // 
            this.checkBoxRegular.AutoSize = true;
            this.checkBoxRegular.Location = new System.Drawing.Point(3, 3);
            this.checkBoxRegular.Name = "checkBoxRegular";
            this.checkBoxRegular.Size = new System.Drawing.Size(82, 24);
            this.checkBoxRegular.TabIndex = 0;
            this.checkBoxRegular.Text = "Regular";
            this.checkBoxRegular.UseVisualStyleBackColor = true;
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.AutoSize = true;
            this.checkBoxBold.Location = new System.Drawing.Point(3, 33);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(62, 24);
            this.checkBoxBold.TabIndex = 1;
            this.checkBoxBold.Text = "Bold";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.AutoSize = true;
            this.checkBoxItalic.Location = new System.Drawing.Point(3, 63);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(63, 24);
            this.checkBoxItalic.TabIndex = 2;
            this.checkBoxItalic.Text = "Italic";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnderline
            // 
            this.checkBoxUnderline.AutoSize = true;
            this.checkBoxUnderline.Location = new System.Drawing.Point(110, 3);
            this.checkBoxUnderline.Name = "checkBoxUnderline";
            this.checkBoxUnderline.Size = new System.Drawing.Size(95, 24);
            this.checkBoxUnderline.TabIndex = 3;
            this.checkBoxUnderline.Text = "Underline";
            this.checkBoxUnderline.UseVisualStyleBackColor = true;
            // 
            // checkBoxStrike
            // 
            this.checkBoxStrike.AutoSize = true;
            this.checkBoxStrike.Location = new System.Drawing.Point(110, 33);
            this.checkBoxStrike.Name = "checkBoxStrike";
            this.checkBoxStrike.Size = new System.Drawing.Size(90, 24);
            this.checkBoxStrike.TabIndex = 4;
            this.checkBoxStrike.Text = "Strikeout";
            this.checkBoxStrike.UseVisualStyleBackColor = true;
            // 
            // FontStyleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxStrike);
            this.Controls.Add(this.checkBoxUnderline);
            this.Controls.Add(this.checkBoxItalic);
            this.Controls.Add(this.checkBoxBold);
            this.Controls.Add(this.checkBoxRegular);
            this.Name = "FontStyleControl";
            this.Size = new System.Drawing.Size(232, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CheckBox checkBoxRegular;
        public CheckBox checkBoxBold;
        public CheckBox checkBoxItalic;
        public CheckBox checkBoxUnderline;
        public CheckBox checkBoxStrike;
    }
}
