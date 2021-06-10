
namespace Session_8_Answers {
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.AddCourse = new DevExpress.XtraEditors.SimpleButton();
            this.AddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.AddProfessor = new DevExpress.XtraEditors.SimpleButton();
            this.ExitButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(539, 53);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "University Management System";
            // 
            // AddCourse
            // 
            this.AddCourse.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddCourse.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.AddCourse.Appearance.Options.UseFont = true;
            this.AddCourse.Appearance.Options.UseForeColor = true;
            this.AddCourse.Location = new System.Drawing.Point(69, 175);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(136, 54);
            this.AddCourse.TabIndex = 1;
            this.AddCourse.Text = "Add Course...";
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddStudent.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.AddStudent.Appearance.Options.UseFont = true;
            this.AddStudent.Appearance.Options.UseForeColor = true;
            this.AddStudent.Location = new System.Drawing.Point(261, 175);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(136, 54);
            this.AddStudent.TabIndex = 2;
            this.AddStudent.Text = "Add Student...";
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // AddProfessor
            // 
            this.AddProfessor.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddProfessor.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.AddProfessor.Appearance.Options.UseFont = true;
            this.AddProfessor.Appearance.Options.UseForeColor = true;
            this.AddProfessor.Location = new System.Drawing.Point(448, 175);
            this.AddProfessor.Name = "AddProfessor";
            this.AddProfessor.Size = new System.Drawing.Size(136, 54);
            this.AddProfessor.TabIndex = 3;
            this.AddProfessor.Text = "Add Schedule...";
            this.AddProfessor.Click += new System.EventHandler(this.AddSchedule_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ExitButton.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.ExitButton.Appearance.Options.UseFont = true;
            this.ExitButton.Appearance.Options.UseForeColor = true;
            this.ExitButton.Location = new System.Drawing.Point(561, 275);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 27);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(198, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(280, 34);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Please make a selection: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(648, 305);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddProfessor);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton AddCourse;
        private DevExpress.XtraEditors.SimpleButton AddStudent;
        private DevExpress.XtraEditors.SimpleButton AddProfessor;
        private DevExpress.XtraEditors.SimpleButton ExitButton;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}