namespace Coursemo {
    partial class CoursemoSwap {
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
            this.StudentsLstBox1 = new System.Windows.Forms.ListBox();
            this.StudentCoursesLstBox1 = new System.Windows.Forms.ListBox();
            this.StudentsLstBox2 = new System.Windows.Forms.ListBox();
            this.StudentCoursesLstBox2 = new System.Windows.Forms.ListBox();
            this.SwapBtn = new System.Windows.Forms.Button();
            this.txtTimeInMS = new System.Windows.Forms.TextBox();
            this.DelayChkBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsLstBox1
            // 
            this.StudentsLstBox1.FormattingEnabled = true;
            this.StudentsLstBox1.Location = new System.Drawing.Point(12, 12);
            this.StudentsLstBox1.Name = "StudentsLstBox1";
            this.StudentsLstBox1.Size = new System.Drawing.Size(256, 381);
            this.StudentsLstBox1.TabIndex = 1;
            this.StudentsLstBox1.SelectedIndexChanged += new System.EventHandler(this.StudentsLstBox1_SelectedIndexChanged);
            // 
            // StudentCoursesLstBox1
            // 
            this.StudentCoursesLstBox1.FormattingEnabled = true;
            this.StudentCoursesLstBox1.Location = new System.Drawing.Point(12, 409);
            this.StudentCoursesLstBox1.Name = "StudentCoursesLstBox1";
            this.StudentCoursesLstBox1.Size = new System.Drawing.Size(252, 147);
            this.StudentCoursesLstBox1.TabIndex = 7;
            // 
            // StudentsLstBox2
            // 
            this.StudentsLstBox2.FormattingEnabled = true;
            this.StudentsLstBox2.Location = new System.Drawing.Point(297, 12);
            this.StudentsLstBox2.Name = "StudentsLstBox2";
            this.StudentsLstBox2.Size = new System.Drawing.Size(256, 381);
            this.StudentsLstBox2.TabIndex = 8;
            this.StudentsLstBox2.SelectedIndexChanged += new System.EventHandler(this.StudentsLstBox2_SelectedIndexChanged);
            // 
            // StudentCoursesLstBox2
            // 
            this.StudentCoursesLstBox2.FormattingEnabled = true;
            this.StudentCoursesLstBox2.Location = new System.Drawing.Point(301, 409);
            this.StudentCoursesLstBox2.Name = "StudentCoursesLstBox2";
            this.StudentCoursesLstBox2.Size = new System.Drawing.Size(252, 147);
            this.StudentCoursesLstBox2.TabIndex = 9;
            // 
            // SwapBtn
            // 
            this.SwapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SwapBtn.Location = new System.Drawing.Point(572, 491);
            this.SwapBtn.Name = "SwapBtn";
            this.SwapBtn.Size = new System.Drawing.Size(150, 65);
            this.SwapBtn.TabIndex = 28;
            this.SwapBtn.Text = "Swap";
            this.SwapBtn.UseVisualStyleBackColor = true;
            this.SwapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.txtTimeInMS);
            this.panel2.Controls.Add(this.DelayChkBox);
            this.panel2.Location = new System.Drawing.Point(572, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 62);
            this.panel2.TabIndex = 31;
            // 
            // CoursemoSwap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(794, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SwapBtn);
            this.Controls.Add(this.StudentCoursesLstBox2);
            this.Controls.Add(this.StudentsLstBox2);
            this.Controls.Add(this.StudentCoursesLstBox1);
            this.Controls.Add(this.StudentsLstBox1);
            this.Name = "CoursemoSwap";
            this.Text = "Swap";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StudentsLstBox1;
        private System.Windows.Forms.ListBox StudentCoursesLstBox1;
        private System.Windows.Forms.ListBox StudentsLstBox2;
        private System.Windows.Forms.ListBox StudentCoursesLstBox2;
        public System.Windows.Forms.Button SwapBtn;
        private System.Windows.Forms.TextBox txtTimeInMS;
        private System.Windows.Forms.CheckBox DelayChkBox;
        private System.Windows.Forms.Panel panel2;
    }
}