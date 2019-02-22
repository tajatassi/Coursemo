namespace Coursemo {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.StudentsLstBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentCoursesLstBox = new System.Windows.Forms.ListBox();
            this.CoursesLstBox = new System.Windows.Forms.ListBox();
            this.StudentsEnrolledLstBox = new System.Windows.Forms.ListBox();
            this.TermLabel = new System.Windows.Forms.Label();
            this.TermTxtBox = new System.Windows.Forms.TextBox();
            this.ClassTypeLabel = new System.Windows.Forms.Label();
            this.ClassTypeTxtBox = new System.Windows.Forms.TextBox();
            this.DaysTxtBox = new System.Windows.Forms.TextBox();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimesTxtBox = new System.Windows.Forms.TextBox();
            this.NumWaitlistLabel = new System.Windows.Forms.Label();
            this.NumWaitlistTxtBox = new System.Windows.Forms.TextBox();
            this.EnrollBtn = new System.Windows.Forms.Button();
            this.StudentWaitlistLstBox = new System.Windows.Forms.ListBox();
            this.CourseWaitlistLstBox = new System.Windows.Forms.ListBox();
            this.CoursesLbl = new System.Windows.Forms.Label();
            this.StudentWaitlistLbl = new System.Windows.Forms.Label();
            this.ClassSizeLbl = new System.Windows.Forms.Label();
            this.ClassSizeTxtBox = new System.Windows.Forms.TextBox();
            this.DropBtn = new System.Windows.Forms.Button();
            this.SwapBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimeInMS = new System.Windows.Forms.TextBox();
            this.DelayChkBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsLstBox
            // 
            this.StudentsLstBox.FormattingEnabled = true;
            this.StudentsLstBox.Location = new System.Drawing.Point(12, 32);
            this.StudentsLstBox.Name = "StudentsLstBox";
            this.StudentsLstBox.Size = new System.Drawing.Size(256, 563);
            this.StudentsLstBox.TabIndex = 0;
            this.StudentsLstBox.SelectedIndexChanged += new System.EventHandler(this.StudentsLstBox_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetDatabaseToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetDatabaseToolStripMenuItem
            // 
            this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
            this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.resetDatabaseToolStripMenuItem.Text = "Reset Database";
            this.resetDatabaseToolStripMenuItem.Click += new System.EventHandler(this.resetDatabaseToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // StudentCoursesLstBox
            // 
            this.StudentCoursesLstBox.FormattingEnabled = true;
            this.StudentCoursesLstBox.Location = new System.Drawing.Point(289, 55);
            this.StudentCoursesLstBox.Name = "StudentCoursesLstBox";
            this.StudentCoursesLstBox.Size = new System.Drawing.Size(252, 147);
            this.StudentCoursesLstBox.TabIndex = 6;
            this.StudentCoursesLstBox.SelectedIndexChanged += new System.EventHandler(this.StudentCoursesLstBox_SelectedIndexChanged);
            // 
            // CoursesLstBox
            // 
            this.CoursesLstBox.FormattingEnabled = true;
            this.CoursesLstBox.Location = new System.Drawing.Point(925, 32);
            this.CoursesLstBox.Name = "CoursesLstBox";
            this.CoursesLstBox.Size = new System.Drawing.Size(252, 394);
            this.CoursesLstBox.TabIndex = 7;
            this.CoursesLstBox.SelectedIndexChanged += new System.EventHandler(this.CoursesLstBox_SelectedIndexChanged);
            // 
            // StudentsEnrolledLstBox
            // 
            this.StudentsEnrolledLstBox.FormattingEnabled = true;
            this.StudentsEnrolledLstBox.Location = new System.Drawing.Point(635, 55);
            this.StudentsEnrolledLstBox.Name = "StudentsEnrolledLstBox";
            this.StudentsEnrolledLstBox.Size = new System.Drawing.Size(252, 147);
            this.StudentsEnrolledLstBox.TabIndex = 8;
            // 
            // TermLabel
            // 
            this.TermLabel.AutoSize = true;
            this.TermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TermLabel.Location = new System.Drawing.Point(921, 438);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Size = new System.Drawing.Size(45, 20);
            this.TermLabel.TabIndex = 9;
            this.TermLabel.Text = "Term";
            // 
            // TermTxtBox
            // 
            this.TermTxtBox.Location = new System.Drawing.Point(1017, 438);
            this.TermTxtBox.Name = "TermTxtBox";
            this.TermTxtBox.Size = new System.Drawing.Size(160, 20);
            this.TermTxtBox.TabIndex = 10;
            // 
            // ClassTypeLabel
            // 
            this.ClassTypeLabel.AutoSize = true;
            this.ClassTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ClassTypeLabel.Location = new System.Drawing.Point(923, 475);
            this.ClassTypeLabel.Name = "ClassTypeLabel";
            this.ClassTypeLabel.Size = new System.Drawing.Size(43, 20);
            this.ClassTypeLabel.TabIndex = 11;
            this.ClassTypeLabel.Text = "Type";
            // 
            // ClassTypeTxtBox
            // 
            this.ClassTypeTxtBox.Location = new System.Drawing.Point(1017, 475);
            this.ClassTypeTxtBox.Name = "ClassTypeTxtBox";
            this.ClassTypeTxtBox.Size = new System.Drawing.Size(160, 20);
            this.ClassTypeTxtBox.TabIndex = 12;
            // 
            // DaysTxtBox
            // 
            this.DaysTxtBox.Location = new System.Drawing.Point(1017, 508);
            this.DaysTxtBox.Name = "DaysTxtBox";
            this.DaysTxtBox.Size = new System.Drawing.Size(160, 20);
            this.DaysTxtBox.TabIndex = 13;
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DaysLabel.Location = new System.Drawing.Point(923, 508);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(45, 20);
            this.DaysLabel.TabIndex = 14;
            this.DaysLabel.Text = "Days";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TimeLabel.Location = new System.Drawing.Point(923, 539);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(43, 20);
            this.TimeLabel.TabIndex = 15;
            this.TimeLabel.Text = "Time";
            // 
            // TimesTxtBox
            // 
            this.TimesTxtBox.Location = new System.Drawing.Point(1017, 539);
            this.TimesTxtBox.Name = "TimesTxtBox";
            this.TimesTxtBox.Size = new System.Drawing.Size(160, 20);
            this.TimesTxtBox.TabIndex = 16;
            // 
            // NumWaitlistLabel
            // 
            this.NumWaitlistLabel.AutoSize = true;
            this.NumWaitlistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NumWaitlistLabel.Location = new System.Drawing.Point(631, 224);
            this.NumWaitlistLabel.Name = "NumWaitlistLabel";
            this.NumWaitlistLabel.Size = new System.Drawing.Size(95, 20);
            this.NumWaitlistLabel.TabIndex = 17;
            this.NumWaitlistLabel.Text = "# on Waitlist";
            // 
            // NumWaitlistTxtBox
            // 
            this.NumWaitlistTxtBox.Location = new System.Drawing.Point(743, 222);
            this.NumWaitlistTxtBox.Name = "NumWaitlistTxtBox";
            this.NumWaitlistTxtBox.Size = new System.Drawing.Size(144, 20);
            this.NumWaitlistTxtBox.TabIndex = 18;
            // 
            // EnrollBtn
            // 
            this.EnrollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.EnrollBtn.Location = new System.Drawing.Point(435, 14);
            this.EnrollBtn.Name = "EnrollBtn";
            this.EnrollBtn.Size = new System.Drawing.Size(150, 65);
            this.EnrollBtn.TabIndex = 19;
            this.EnrollBtn.Text = "Enroll";
            this.EnrollBtn.UseVisualStyleBackColor = true;
            this.EnrollBtn.Click += new System.EventHandler(this.EnrollBtn_Click);
            // 
            // StudentWaitlistLstBox
            // 
            this.StudentWaitlistLstBox.FormattingEnabled = true;
            this.StudentWaitlistLstBox.Location = new System.Drawing.Point(289, 247);
            this.StudentWaitlistLstBox.Name = "StudentWaitlistLstBox";
            this.StudentWaitlistLstBox.Size = new System.Drawing.Size(252, 147);
            this.StudentWaitlistLstBox.TabIndex = 20;
            this.StudentWaitlistLstBox.SelectedIndexChanged += new System.EventHandler(this.StudentWaitlistLstBox_SelectedIndexChanged);
            // 
            // CourseWaitlistLstBox
            // 
            this.CourseWaitlistLstBox.FormattingEnabled = true;
            this.CourseWaitlistLstBox.Location = new System.Drawing.Point(635, 247);
            this.CourseWaitlistLstBox.Name = "CourseWaitlistLstBox";
            this.CourseWaitlistLstBox.Size = new System.Drawing.Size(252, 147);
            this.CourseWaitlistLstBox.TabIndex = 21;
            // 
            // CoursesLbl
            // 
            this.CoursesLbl.AutoSize = true;
            this.CoursesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CoursesLbl.Location = new System.Drawing.Point(285, 32);
            this.CoursesLbl.Name = "CoursesLbl";
            this.CoursesLbl.Size = new System.Drawing.Size(68, 20);
            this.CoursesLbl.TabIndex = 23;
            this.CoursesLbl.Text = "Courses";
            // 
            // StudentWaitlistLbl
            // 
            this.StudentWaitlistLbl.AutoSize = true;
            this.StudentWaitlistLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StudentWaitlistLbl.Location = new System.Drawing.Point(285, 224);
            this.StudentWaitlistLbl.Name = "StudentWaitlistLbl";
            this.StudentWaitlistLbl.Size = new System.Drawing.Size(60, 20);
            this.StudentWaitlistLbl.TabIndex = 24;
            this.StudentWaitlistLbl.Text = "Waitlist";
            // 
            // ClassSizeLbl
            // 
            this.ClassSizeLbl.AutoSize = true;
            this.ClassSizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ClassSizeLbl.Location = new System.Drawing.Point(926, 572);
            this.ClassSizeLbl.Name = "ClassSizeLbl";
            this.ClassSizeLbl.Size = new System.Drawing.Size(40, 20);
            this.ClassSizeLbl.TabIndex = 25;
            this.ClassSizeLbl.Text = "Size";
            // 
            // ClassSizeTxtBox
            // 
            this.ClassSizeTxtBox.Location = new System.Drawing.Point(1017, 572);
            this.ClassSizeTxtBox.Name = "ClassSizeTxtBox";
            this.ClassSizeTxtBox.Size = new System.Drawing.Size(160, 20);
            this.ClassSizeTxtBox.TabIndex = 26;
            // 
            // DropBtn
            // 
            this.DropBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DropBtn.Location = new System.Drawing.Point(12, 14);
            this.DropBtn.Name = "DropBtn";
            this.DropBtn.Size = new System.Drawing.Size(150, 65);
            this.DropBtn.TabIndex = 22;
            this.DropBtn.Text = "Drop";
            this.DropBtn.UseVisualStyleBackColor = true;
            this.DropBtn.Click += new System.EventHandler(this.DropBtn_Click);
            // 
            // SwapBtn
            // 
            this.SwapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SwapBtn.Location = new System.Drawing.Point(223, 14);
            this.SwapBtn.Name = "SwapBtn";
            this.SwapBtn.Size = new System.Drawing.Size(150, 65);
            this.SwapBtn.TabIndex = 27;
            this.SwapBtn.Text = "Swap";
            this.SwapBtn.UseVisualStyleBackColor = true;
            this.SwapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(631, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Class Roster";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.SwapBtn);
            this.panel1.Controls.Add(this.DropBtn);
            this.panel1.Controls.Add(this.EnrollBtn);
            this.panel1.Location = new System.Drawing.Point(289, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 92);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.txtTimeInMS);
            this.panel2.Controls.Add(this.DelayChkBox);
            this.panel2.Location = new System.Drawing.Point(495, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 62);
            this.panel2.TabIndex = 30;
            // 
            // txtTimeInMS
            // 
            this.txtTimeInMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimeInMS.Location = new System.Drawing.Point(9, 18);
            this.txtTimeInMS.Name = "txtTimeInMS";
            this.txtTimeInMS.Size = new System.Drawing.Size(80, 26);
            this.txtTimeInMS.TabIndex = 1;
            this.txtTimeInMS.Text = "5000";
            // 
            // DelayChkBox
            // 
            this.DelayChkBox.AutoSize = true;
            this.DelayChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DelayChkBox.Location = new System.Drawing.Point(108, 20);
            this.DelayChkBox.Name = "DelayChkBox";
            this.DelayChkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DelayChkBox.Size = new System.Drawing.Size(103, 24);
            this.DelayChkBox.TabIndex = 0;
            this.DelayChkBox.Text = "Delay (ms)";
            this.DelayChkBox.UseVisualStyleBackColor = true;
            this.DelayChkBox.CheckedChanged += new System.EventHandler(this.DelayChkBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1199, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassSizeTxtBox);
            this.Controls.Add(this.ClassSizeLbl);
            this.Controls.Add(this.StudentWaitlistLbl);
            this.Controls.Add(this.CoursesLbl);
            this.Controls.Add(this.CourseWaitlistLstBox);
            this.Controls.Add(this.StudentWaitlistLstBox);
            this.Controls.Add(this.NumWaitlistTxtBox);
            this.Controls.Add(this.NumWaitlistLabel);
            this.Controls.Add(this.TimesTxtBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.DaysTxtBox);
            this.Controls.Add(this.ClassTypeTxtBox);
            this.Controls.Add(this.ClassTypeLabel);
            this.Controls.Add(this.TermTxtBox);
            this.Controls.Add(this.TermLabel);
            this.Controls.Add(this.StudentsEnrolledLstBox);
            this.Controls.Add(this.CoursesLstBox);
            this.Controls.Add(this.StudentCoursesLstBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StudentsLstBox);
            this.Name = "Form1";
            this.Text = "  ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StudentsLstBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
        private System.Windows.Forms.ListBox StudentCoursesLstBox;
        private System.Windows.Forms.ListBox CoursesLstBox;
        private System.Windows.Forms.ListBox StudentsEnrolledLstBox;
        private System.Windows.Forms.Label TermLabel;
        private System.Windows.Forms.TextBox TermTxtBox;
        private System.Windows.Forms.Label ClassTypeLabel;
        private System.Windows.Forms.TextBox ClassTypeTxtBox;
        private System.Windows.Forms.TextBox DaysTxtBox;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox TimesTxtBox;
        private System.Windows.Forms.Label NumWaitlistLabel;
        private System.Windows.Forms.TextBox NumWaitlistTxtBox;
        private System.Windows.Forms.Button EnrollBtn;
        private System.Windows.Forms.ListBox StudentWaitlistLstBox;
        private System.Windows.Forms.ListBox CourseWaitlistLstBox;
        private System.Windows.Forms.Label CoursesLbl;
        private System.Windows.Forms.Label StudentWaitlistLbl;
        private System.Windows.Forms.Label ClassSizeLbl;
        private System.Windows.Forms.TextBox ClassSizeTxtBox;
        private System.Windows.Forms.Button DropBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button SwapBtn;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimeInMS;
        private System.Windows.Forms.CheckBox DelayChkBox;
    }
}

