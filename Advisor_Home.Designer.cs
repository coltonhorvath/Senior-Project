namespace DARS
{
    partial class Advisor_Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advisor_Home));
            this.dgvAdvisor = new System.Windows.Forms.DataGridView();
            this.lblAdvisorTitle = new System.Windows.Forms.Label();
            this.lblAdvisorName = new System.Windows.Forms.Label();
            this.lblCollegeName = new System.Windows.Forms.Label();
            this.gboxStudent = new System.Windows.Forms.GroupBox();
            this.btnStudentLookup = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDegreeType = new System.Windows.Forms.TextBox();
            this.txtStanding = new System.Windows.Forms.TextBox();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDegreeType = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblStanding = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.gboxCourses = new System.Windows.Forms.GroupBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUsername2 = new System.Windows.Forms.TextBox();
            this.btnCourseLookup = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblUsername_2 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvisor)).BeginInit();
            this.gboxStudent.SuspendLayout();
            this.gboxCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdvisor
            // 
            this.dgvAdvisor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.dgvAdvisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdvisor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdvisor.Location = new System.Drawing.Point(476, 12);
            this.dgvAdvisor.Name = "dgvAdvisor";
            this.dgvAdvisor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdvisor.Size = new System.Drawing.Size(749, 956);
            this.dgvAdvisor.TabIndex = 0;
            // 
            // lblAdvisorTitle
            // 
            this.lblAdvisorTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblAdvisorTitle.Location = new System.Drawing.Point(12, 9);
            this.lblAdvisorTitle.Name = "lblAdvisorTitle";
            this.lblAdvisorTitle.Size = new System.Drawing.Size(458, 26);
            this.lblAdvisorTitle.TabIndex = 1;
            this.lblAdvisorTitle.Text = "Advisor";
            this.lblAdvisorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdvisorName
            // 
            this.lblAdvisorName.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblAdvisorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblAdvisorName.Location = new System.Drawing.Point(12, 35);
            this.lblAdvisorName.Name = "lblAdvisorName";
            this.lblAdvisorName.Size = new System.Drawing.Size(458, 26);
            this.lblAdvisorName.TabIndex = 2;
            this.lblAdvisorName.Text = "Advisor_name";
            this.lblAdvisorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCollegeName
            // 
            this.lblCollegeName.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblCollegeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblCollegeName.Location = new System.Drawing.Point(12, 61);
            this.lblCollegeName.Name = "lblCollegeName";
            this.lblCollegeName.Size = new System.Drawing.Size(458, 26);
            this.lblCollegeName.TabIndex = 3;
            this.lblCollegeName.Text = "College_name";
            this.lblCollegeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboxStudent
            // 
            this.gboxStudent.Controls.Add(this.btnStudentLookup);
            this.gboxStudent.Controls.Add(this.txtUsername);
            this.gboxStudent.Controls.Add(this.txtDegreeType);
            this.gboxStudent.Controls.Add(this.txtStanding);
            this.gboxStudent.Controls.Add(this.txtDegree);
            this.gboxStudent.Controls.Add(this.txtLastName);
            this.gboxStudent.Controls.Add(this.txtFirstName);
            this.gboxStudent.Controls.Add(this.lblUsername);
            this.gboxStudent.Controls.Add(this.lblDegreeType);
            this.gboxStudent.Controls.Add(this.lblDegree);
            this.gboxStudent.Controls.Add(this.lblStanding);
            this.gboxStudent.Controls.Add(this.lblLastName);
            this.gboxStudent.Controls.Add(this.lblFirstName);
            this.gboxStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.gboxStudent.Location = new System.Drawing.Point(12, 100);
            this.gboxStudent.Name = "gboxStudent";
            this.gboxStudent.Size = new System.Drawing.Size(458, 317);
            this.gboxStudent.TabIndex = 4;
            this.gboxStudent.TabStop = false;
            this.gboxStudent.Text = "Student Lookup";
            // 
            // btnStudentLookup
            // 
            this.btnStudentLookup.Location = new System.Drawing.Point(179, 272);
            this.btnStudentLookup.Name = "btnStudentLookup";
            this.btnStudentLookup.Size = new System.Drawing.Size(100, 27);
            this.btnStudentLookup.TabIndex = 12;
            this.btnStudentLookup.Text = "Submit";
            this.btnStudentLookup.UseVisualStyleBackColor = true;
            this.btnStudentLookup.Click += new System.EventHandler(this.btnStudentLookup_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(315, 54);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 27);
            this.txtUsername.TabIndex = 11;
            // 
            // txtDegreeType
            // 
            this.txtDegreeType.Location = new System.Drawing.Point(315, 212);
            this.txtDegreeType.Name = "txtDegreeType";
            this.txtDegreeType.Size = new System.Drawing.Size(100, 27);
            this.txtDegreeType.TabIndex = 10;
            // 
            // txtStanding
            // 
            this.txtStanding.Location = new System.Drawing.Point(315, 126);
            this.txtStanding.Name = "txtStanding";
            this.txtStanding.Size = new System.Drawing.Size(100, 27);
            this.txtStanding.TabIndex = 9;
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point(100, 212);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(100, 27);
            this.txtDegree.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(100, 126);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 27);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(100, 54);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 27);
            this.txtFirstName.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblUsername.Location = new System.Drawing.Point(221, 57);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 19);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblDegreeType
            // 
            this.lblDegreeType.AutoSize = true;
            this.lblDegreeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblDegreeType.Location = new System.Drawing.Point(221, 215);
            this.lblDegreeType.Name = "lblDegreeType";
            this.lblDegreeType.Size = new System.Drawing.Size(88, 19);
            this.lblDegreeType.TabIndex = 4;
            this.lblDegreeType.Text = "Degree type";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblDegree.Location = new System.Drawing.Point(6, 215);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(56, 19);
            this.lblDegree.TabIndex = 3;
            this.lblDegree.Text = "Degree";
            // 
            // lblStanding
            // 
            this.lblStanding.AutoSize = true;
            this.lblStanding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblStanding.Location = new System.Drawing.Point(221, 129);
            this.lblStanding.Name = "lblStanding";
            this.lblStanding.Size = new System.Drawing.Size(65, 19);
            this.lblStanding.TabIndex = 2;
            this.lblStanding.Text = "Standing";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblLastName.Location = new System.Drawing.Point(7, 129);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 19);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblFirstName.Location = new System.Drawing.Point(6, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 19);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First name";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblOr.Location = new System.Drawing.Point(218, 445);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(43, 29);
            this.lblOr.TabIndex = 5;
            this.lblOr.Text = "OR";
            // 
            // gboxCourses
            // 
            this.gboxCourses.Controls.Add(this.txtGrade);
            this.gboxCourses.Controls.Add(this.txtCourse);
            this.gboxCourses.Controls.Add(this.txtDescription);
            this.gboxCourses.Controls.Add(this.txtUsername2);
            this.gboxCourses.Controls.Add(this.btnCourseLookup);
            this.gboxCourses.Controls.Add(this.lblGrade);
            this.gboxCourses.Controls.Add(this.lblDescription);
            this.gboxCourses.Controls.Add(this.lblCourse);
            this.gboxCourses.Controls.Add(this.lblUsername_2);
            this.gboxCourses.Font = new System.Drawing.Font("Calibri", 12F);
            this.gboxCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.gboxCourses.Location = new System.Drawing.Point(12, 498);
            this.gboxCourses.Name = "gboxCourses";
            this.gboxCourses.Size = new System.Drawing.Size(458, 240);
            this.gboxCourses.TabIndex = 6;
            this.gboxCourses.TabStop = false;
            this.gboxCourses.Text = "Course Lookup";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(315, 120);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 27);
            this.txtGrade.TabIndex = 8;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(315, 41);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 27);
            this.txtCourse.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(100, 120);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 27);
            this.txtDescription.TabIndex = 6;
            // 
            // txtUsername2
            // 
            this.txtUsername2.Location = new System.Drawing.Point(100, 41);
            this.txtUsername2.Name = "txtUsername2";
            this.txtUsername2.Size = new System.Drawing.Size(100, 27);
            this.txtUsername2.TabIndex = 5;
            // 
            // btnCourseLookup
            // 
            this.btnCourseLookup.Location = new System.Drawing.Point(179, 193);
            this.btnCourseLookup.Name = "btnCourseLookup";
            this.btnCourseLookup.Size = new System.Drawing.Size(100, 27);
            this.btnCourseLookup.TabIndex = 4;
            this.btnCourseLookup.Text = "Submit";
            this.btnCourseLookup.UseVisualStyleBackColor = true;
            this.btnCourseLookup.Click += new System.EventHandler(this.btnSubmit_2_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblGrade.Location = new System.Drawing.Point(221, 123);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(48, 19);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "Grade";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblDescription.Location = new System.Drawing.Point(7, 123);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 19);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblCourse.Location = new System.Drawing.Point(221, 44);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(66, 19);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "Course #";
            // 
            // lblUsername_2
            // 
            this.lblUsername_2.AutoSize = true;
            this.lblUsername_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.lblUsername_2.Location = new System.Drawing.Point(6, 44);
            this.lblUsername_2.Name = "lblUsername_2";
            this.lblUsername_2.Size = new System.Drawing.Size(75, 19);
            this.lblUsername_2.TabIndex = 0;
            this.lblUsername_2.Text = "Username";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(8)))));
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(12, 744);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(458, 224);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            // 
            // Advisor_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1231, 980);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.gboxCourses);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.gboxStudent);
            this.Controls.Add(this.lblCollegeName);
            this.Controls.Add(this.lblAdvisorName);
            this.Controls.Add(this.lblAdvisorTitle);
            this.Controls.Add(this.dgvAdvisor);
            this.Name = "Advisor_Home";
            this.Text = "Advisor_Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Advisor_Home_FormClosing);
            this.Load += new System.EventHandler(this.Advisor_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvisor)).EndInit();
            this.gboxStudent.ResumeLayout(false);
            this.gboxStudent.PerformLayout();
            this.gboxCourses.ResumeLayout(false);
            this.gboxCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdvisor;
        private System.Windows.Forms.Label lblAdvisorTitle;
        private System.Windows.Forms.Label lblAdvisorName;
        private System.Windows.Forms.Label lblCollegeName;
        private System.Windows.Forms.GroupBox gboxStudent;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDegreeType;
        private System.Windows.Forms.TextBox txtStanding;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDegreeType;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblStanding;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnStudentLookup;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.GroupBox gboxCourses;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUsername2;
        private System.Windows.Forms.Button btnCourseLookup;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblUsername_2;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}