namespace SourceCodeEditor.UserControls.Options
{
    partial class HotKeysOptionsControl
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
            dataGridView1 = new DataGridView();
            Action = new DataGridViewTextBoxColumn();
            HotKey = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Action, HotKey });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(581, 469);
            dataGridView1.TabIndex = 0;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            dataGridView1.KeyUp += dataGridView1_KeyUp;
            // 
            // Action
            // 
            Action.HeaderText = "ColumnActions";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Resizable = DataGridViewTriState.False;
            Action.Width = 125;
            // 
            // HotKey
            // 
            HotKey.HeaderText = "ColumnHotKeys";
            HotKey.MinimumWidth = 6;
            HotKey.Name = "HotKey";
            HotKey.ReadOnly = true;
            HotKey.Resizable = DataGridViewTriState.False;
            HotKey.Width = 125;
            // 
            // HotKeysOptionsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "HotKeysOptionsControl";
            Size = new Size(581, 469);
            Load += HotKeysOptionsControl_Load;
            SizeChanged += HotKeysOptionsControl_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Action;
        private DataGridViewTextBoxColumn HotKey;
    }
}
