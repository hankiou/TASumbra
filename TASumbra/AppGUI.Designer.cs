namespace TASumbra
{
    partial class AppGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppGUI));
            this.Label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Settings = new System.Windows.Forms.TabPage();
            this.PenumbraPathSelect = new System.Windows.Forms.Button();
            this.PenumbraPathTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MovieNumberLabel = new System.Windows.Forms.Label();
            this.FrameNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forwards = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Backwards = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Left = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Right = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MouseX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MouseY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.Settings.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Game Path :";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Settings);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 502);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.PenumbraPathSelect);
            this.Settings.Controls.Add(this.PenumbraPathTextBox);
            this.Settings.Controls.Add(this.Label1);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(936, 476);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // PenumbraPathSelect
            // 
            this.PenumbraPathSelect.Location = new System.Drawing.Point(456, 18);
            this.PenumbraPathSelect.Name = "PenumbraPathSelect";
            this.PenumbraPathSelect.Size = new System.Drawing.Size(26, 22);
            this.PenumbraPathSelect.TabIndex = 2;
            this.PenumbraPathSelect.Text = "...";
            this.PenumbraPathSelect.UseVisualStyleBackColor = true;
            this.PenumbraPathSelect.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PenumbraPathTextBox
            // 
            this.PenumbraPathTextBox.Location = new System.Drawing.Point(8, 19);
            this.PenumbraPathTextBox.Name = "PenumbraPathTextBox";
            this.PenumbraPathTextBox.Size = new System.Drawing.Size(442, 20);
            this.PenumbraPathTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MovieNumberLabel);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.DataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movie Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrameNumber,
            this.Forwards,
            this.Backwards,
            this.Left,
            this.Right,
            this.MouseX,
            this.MouseY});
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DataGridView1.Location = new System.Drawing.Point(0, 49);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "dataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView1.Size = new System.Drawing.Size(544, 427);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(483, 23);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // MovieNumberLabel
            // 
            this.MovieNumberLabel.AutoSize = true;
            this.MovieNumberLabel.Location = new System.Drawing.Point(400, 26);
            this.MovieNumberLabel.Name = "MovieNumberLabel";
            this.MovieNumberLabel.Size = new System.Drawing.Size(80, 13);
            this.MovieNumberLabel.TabIndex = 2;
            this.MovieNumberLabel.Text = "Movie number :";
            this.MovieNumberLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrameNumber
            // 
            this.FrameNumber.FillWeight = 55F;
            this.FrameNumber.Frozen = true;
            this.FrameNumber.HeaderText = "Frame n°";
            this.FrameNumber.Name = "FrameNumber";
            this.FrameNumber.Width = 55;
            // 
            // Forwards
            // 
            this.Forwards.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Forwards.FillWeight = 65F;
            this.Forwards.Frozen = true;
            this.Forwards.HeaderText = "Forwards";
            this.Forwards.Name = "Forwards";
            this.Forwards.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Forwards.Width = 56;
            // 
            // Backwards
            // 
            this.Backwards.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Backwards.FillWeight = 75F;
            this.Backwards.Frozen = true;
            this.Backwards.HeaderText = "Backwards";
            this.Backwards.Name = "Backwards";
            this.Backwards.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Backwards.Width = 66;
            // 
            // Left
            // 
            this.Left.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Left.FillWeight = 50F;
            this.Left.Frozen = true;
            this.Left.HeaderText = "Left";
            this.Left.Name = "Left";
            this.Left.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Left.Width = 31;
            // 
            // Right
            // 
            this.Right.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Right.Frozen = true;
            this.Right.HeaderText = "Right";
            this.Right.Name = "Right";
            this.Right.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Right.Width = 38;
            // 
            // MouseX
            // 
            this.MouseX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MouseX.Frozen = true;
            this.MouseX.HeaderText = "MouseX";
            this.MouseX.Name = "MouseX";
            this.MouseX.Width = 71;
            // 
            // MouseY
            // 
            this.MouseY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MouseY.Frozen = true;
            this.MouseY.HeaderText = "MouseY";
            this.MouseY.Name = "MouseY";
            this.MouseY.Width = 71;
            // 
            // AppGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppGUI";
            this.Text = "TASumbra";
            this.Load += new System.EventHandler(this.App_Load);
            this.tabControl.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox PenumbraPathTextBox;
        private System.Windows.Forms.Button PenumbraPathSelect;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label MovieNumberLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Forwards;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Backwards;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Left;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Right;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouseX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MouseY;
    }
}