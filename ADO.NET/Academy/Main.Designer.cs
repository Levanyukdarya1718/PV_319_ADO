namespace Academy
{
	partial class Main
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.tabPageDirections = new System.Windows.Forms.TabPage();
            this.dgvDirections = new System.Windows.Forms.DataGridView();
            this.tabPageDisciplines = new System.Windows.Forms.TabPage();
            this.dgvDisciplines = new System.Windows.Forms.DataGridView();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.tabPageDirections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
            this.tabPageDisciplines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
            this.tabPageTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 956);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 33, 0);
            this.statusStrip.Size = new System.Drawing.Size(1867, 48);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelCount
            // 
            this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            this.toolStripStatusLabelCount.Size = new System.Drawing.Size(269, 37);
            this.toolStripStatusLabelCount.Text = "toolStripStatusLabel1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStudents);
            this.tabControl.Controls.Add(this.tabPageGroups);
            this.tabControl.Controls.Add(this.tabPageDirections);
            this.tabControl.Controls.Add(this.tabPageDisciplines);
            this.tabControl.Controls.Add(this.tabPageTeachers);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(7);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1867, 955);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.dgvStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(10, 47);
            this.tabPageStudents.Margin = new System.Windows.Forms.Padding(7);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageStudents.Size = new System.Drawing.Size(1847, 898);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(0, 109);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(7);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 92;
            this.dgvStudents.Size = new System.Drawing.Size(1848, 781);
            this.dgvStudents.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.comboBox1);
            this.tabPageGroups.Controls.Add(this.dgvGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(10, 47);
            this.tabPageGroups.Margin = new System.Windows.Forms.Padding(7);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageGroups.Size = new System.Drawing.Size(1847, 898);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // dgvGroups
            // 
            this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(0, 47);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowHeadersWidth = 92;
            this.dgvGroups.RowTemplate.Height = 37;
            this.dgvGroups.Size = new System.Drawing.Size(1873, 751);
            this.dgvGroups.TabIndex = 0;
            // 
            // tabPageDirections
            // 
            this.tabPageDirections.Controls.Add(this.dgvDirections);
            this.tabPageDirections.Location = new System.Drawing.Point(10, 47);
            this.tabPageDirections.Margin = new System.Windows.Forms.Padding(7);
            this.tabPageDirections.Name = "tabPageDirections";
            this.tabPageDirections.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageDirections.Size = new System.Drawing.Size(1847, 898);
            this.tabPageDirections.TabIndex = 2;
            this.tabPageDirections.Text = "Directions";
            this.tabPageDirections.UseVisualStyleBackColor = true;
            // 
            // dgvDirections
            // 
            this.dgvDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDirections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirections.Location = new System.Drawing.Point(0, 42);
            this.dgvDirections.Name = "dgvDirections";
            this.dgvDirections.RowHeadersWidth = 92;
            this.dgvDirections.RowTemplate.Height = 37;
            this.dgvDirections.Size = new System.Drawing.Size(1847, 959);
            this.dgvDirections.TabIndex = 0;
            // 
            // tabPageDisciplines
            // 
            this.tabPageDisciplines.Controls.Add(this.dgvDisciplines);
            this.tabPageDisciplines.Location = new System.Drawing.Point(10, 47);
            this.tabPageDisciplines.Margin = new System.Windows.Forms.Padding(7);
            this.tabPageDisciplines.Name = "tabPageDisciplines";
            this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageDisciplines.Size = new System.Drawing.Size(1847, 898);
            this.tabPageDisciplines.TabIndex = 3;
            this.tabPageDisciplines.Text = "Disciplines";
            this.tabPageDisciplines.UseVisualStyleBackColor = true;
            // 
            // dgvDisciplines
            // 
            this.dgvDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplines.Location = new System.Drawing.Point(0, 76);
            this.dgvDisciplines.Name = "dgvDisciplines";
            this.dgvDisciplines.RowHeadersWidth = 92;
            this.dgvDisciplines.RowTemplate.Height = 37;
            this.dgvDisciplines.Size = new System.Drawing.Size(1844, 929);
            this.dgvDisciplines.TabIndex = 0;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Controls.Add(this.dgvTeacher);
            this.tabPageTeachers.Location = new System.Drawing.Point(10, 47);
            this.tabPageTeachers.Margin = new System.Windows.Forms.Padding(7);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageTeachers.Size = new System.Drawing.Size(1847, 898);
            this.tabPageTeachers.TabIndex = 4;
            this.tabPageTeachers.Text = "Teachers";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(0, 41);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.RowHeadersWidth = 92;
            this.dgvTeacher.RowTemplate.Height = 37;
            this.dgvTeacher.Size = new System.Drawing.Size(1847, 847);
            this.dgvTeacher.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1841, 37);
            this.comboBox1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1004);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimumSize = new System.Drawing.Size(1456, 974);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academy_PV_319";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabPageGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.tabPageDirections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).EndInit();
            this.tabPageDisciplines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
            this.tabPageTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageDirections;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.DataGridView dgvDirections;
        private System.Windows.Forms.DataGridView dgvDisciplines;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

