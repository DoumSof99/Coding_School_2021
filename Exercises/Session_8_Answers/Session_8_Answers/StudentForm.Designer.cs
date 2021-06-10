
namespace Session_8_Answers {
    partial class StudentForm {
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TextEditName = new DevExpress.XtraEditors.TextEdit();
            this.TextEditCourse = new DevExpress.XtraEditors.TextEdit();
            this.ButtonSubmitStudent = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TextEditAge = new DevExpress.XtraEditors.TextEdit();
            this.TextEditYear = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(101, 148);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Student Name: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(112, 309);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Student Year: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(95, 201);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 20);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Student Course: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(115, 255);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 20);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Student Age: ";
            // 
            // TextEditName
            // 
            this.TextEditName.Location = new System.Drawing.Point(249, 150);
            this.TextEditName.Name = "TextEditName";
            this.TextEditName.Size = new System.Drawing.Size(269, 20);
            this.TextEditName.TabIndex = 4;
            this.TextEditName.EditValueChanged += new System.EventHandler(this.TextEditName_EditValueChanged);
            // 
            // TextEditCourse
            // 
            this.TextEditCourse.Location = new System.Drawing.Point(249, 203);
            this.TextEditCourse.Name = "TextEditCourse";
            this.TextEditCourse.Size = new System.Drawing.Size(269, 20);
            this.TextEditCourse.TabIndex = 5;
            // 
            // ButtonSubmitStudent
            // 
            this.ButtonSubmitStudent.Appearance.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmitStudent.Appearance.Options.UseFont = true;
            this.ButtonSubmitStudent.Location = new System.Drawing.Point(288, 403);
            this.ButtonSubmitStudent.Name = "ButtonSubmitStudent";
            this.ButtonSubmitStudent.Size = new System.Drawing.Size(146, 35);
            this.ButtonSubmitStudent.TabIndex = 8;
            this.ButtonSubmitStudent.Text = "Submit Student";
            this.ButtonSubmitStudent.Click += new System.EventHandler(this.ButtonSubmitStudent_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(190, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(232, 53);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Student Data";
            // 
            // TextEditAge
            // 
            this.TextEditAge.Location = new System.Drawing.Point(249, 252);
            this.TextEditAge.Name = "TextEditAge";
            this.TextEditAge.Size = new System.Drawing.Size(269, 20);
            this.TextEditAge.TabIndex = 10;
            // 
            // TextEditYear
            // 
            this.TextEditYear.Location = new System.Drawing.Point(249, 309);
            this.TextEditYear.Name = "TextEditYear";
            this.TextEditYear.Size = new System.Drawing.Size(269, 20);
            this.TextEditYear.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(440, 403);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(146, 35);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Close";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.TextEditYear);
            this.Controls.Add(this.TextEditAge);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.ButtonSubmitStudent);
            this.Controls.Add(this.TextEditCourse);
            this.Controls.Add(this.TextEditName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.TextEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TextEditName;
        private DevExpress.XtraEditors.TextEdit TextEditCourse;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmitStudent;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TextEditAge;
        private DevExpress.XtraEditors.TextEdit TextEditYear;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}