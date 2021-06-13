
namespace Session_9_Answers {
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
            this.ctrlCourseButton = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlProfessorButton = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlStudentButton = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlUniversityList = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlSerialize = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlLoadTxt = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlSaveTxt = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlDeserialize = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUniversityList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(62, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(452, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "University Management App";
            // 
            // ctrlCourseButton
            // 
            this.ctrlCourseButton.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlCourseButton.Appearance.Options.UseForeColor = true;
            this.ctrlCourseButton.Location = new System.Drawing.Point(62, 90);
            this.ctrlCourseButton.Name = "ctrlCourseButton";
            this.ctrlCourseButton.Size = new System.Drawing.Size(105, 98);
            this.ctrlCourseButton.TabIndex = 1;
            this.ctrlCourseButton.Text = "Add Course...";
            this.ctrlCourseButton.Click += new System.EventHandler(this.ctrlCourseButton_Click);
            // 
            // ctrlProfessorButton
            // 
            this.ctrlProfessorButton.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlProfessorButton.Appearance.Options.UseForeColor = true;
            this.ctrlProfessorButton.Location = new System.Drawing.Point(364, 90);
            this.ctrlProfessorButton.Name = "ctrlProfessorButton";
            this.ctrlProfessorButton.Size = new System.Drawing.Size(105, 98);
            this.ctrlProfessorButton.TabIndex = 2;
            this.ctrlProfessorButton.Text = "Add Professor...";
            this.ctrlProfessorButton.Click += new System.EventHandler(this.ctrlProfessorButton_Click);
            // 
            // ctrlStudentButton
            // 
            this.ctrlStudentButton.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrlStudentButton.Appearance.Options.UseForeColor = true;
            this.ctrlStudentButton.Location = new System.Drawing.Point(216, 90);
            this.ctrlStudentButton.Name = "ctrlStudentButton";
            this.ctrlStudentButton.Size = new System.Drawing.Size(105, 98);
            this.ctrlStudentButton.TabIndex = 3;
            this.ctrlStudentButton.Text = "Add Student...";
            this.ctrlStudentButton.Click += new System.EventHandler(this.ctrlStudentButton_Click);
            // 
            // ctrlUniversityList
            // 
            this.ctrlUniversityList.Location = new System.Drawing.Point(62, 214);
            this.ctrlUniversityList.Name = "ctrlUniversityList";
            this.ctrlUniversityList.Size = new System.Drawing.Size(532, 130);
            this.ctrlUniversityList.TabIndex = 4;
            // 
            // ctrlSerialize
            // 
            this.ctrlSerialize.Location = new System.Drawing.Point(32, 390);
            this.ctrlSerialize.Name = "ctrlSerialize";
            this.ctrlSerialize.Size = new System.Drawing.Size(121, 33);
            this.ctrlSerialize.TabIndex = 5;
            this.ctrlSerialize.Text = "Serialize to Json";
            this.ctrlSerialize.Click += new System.EventHandler(this.ctrlSerialize_Click);
            // 
            // ctrlLoadTxt
            // 
            this.ctrlLoadTxt.Location = new System.Drawing.Point(413, 390);
            this.ctrlLoadTxt.Name = "ctrlLoadTxt";
            this.ctrlLoadTxt.Size = new System.Drawing.Size(121, 33);
            this.ctrlLoadTxt.TabIndex = 6;
            this.ctrlLoadTxt.Text = "Load from Txt";
            // 
            // ctrlSaveTxt
            // 
            this.ctrlSaveTxt.Location = new System.Drawing.Point(286, 390);
            this.ctrlSaveTxt.Name = "ctrlSaveTxt";
            this.ctrlSaveTxt.Size = new System.Drawing.Size(121, 33);
            this.ctrlSaveTxt.TabIndex = 7;
            this.ctrlSaveTxt.Text = "Save to Txt";
            this.ctrlSaveTxt.Click += new System.EventHandler(this.ctrlSaveTxt_Click);
            // 
            // ctrlDeserialize
            // 
            this.ctrlDeserialize.Location = new System.Drawing.Point(159, 390);
            this.ctrlDeserialize.Name = "ctrlDeserialize";
            this.ctrlDeserialize.Size = new System.Drawing.Size(121, 33);
            this.ctrlDeserialize.TabIndex = 8;
            this.ctrlDeserialize.Text = "Deserialize from Json";
            this.ctrlDeserialize.Click += new System.EventHandler(this.ctrlDeserialize_Click);
            // 
            // ctrlExit
            // 
            this.ctrlExit.Location = new System.Drawing.Point(540, 390);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(121, 33);
            this.ctrlExit.TabIndex = 9;
            this.ctrlExit.Text = "Exit";
            this.ctrlExit.Click += new System.EventHandler(this.ctrlExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.ctrlExit);
            this.Controls.Add(this.ctrlDeserialize);
            this.Controls.Add(this.ctrlSaveTxt);
            this.Controls.Add(this.ctrlLoadTxt);
            this.Controls.Add(this.ctrlSerialize);
            this.Controls.Add(this.ctrlUniversityList);
            this.Controls.Add(this.ctrlStudentButton);
            this.Controls.Add(this.ctrlProfessorButton);
            this.Controls.Add(this.ctrlCourseButton);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUniversityList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton ctrlCourseButton;
        private DevExpress.XtraEditors.SimpleButton ctrlProfessorButton;
        private DevExpress.XtraEditors.SimpleButton ctrlStudentButton;
        private DevExpress.XtraEditors.ListBoxControl ctrlUniversityList;
        private DevExpress.XtraEditors.SimpleButton ctrlSerialize;
        private DevExpress.XtraEditors.SimpleButton ctrlLoadTxt;
        private DevExpress.XtraEditors.SimpleButton ctrlSaveTxt;
        private DevExpress.XtraEditors.SimpleButton ctrlDeserialize;
        private DevExpress.XtraEditors.SimpleButton ctrlExit;
    }
}

