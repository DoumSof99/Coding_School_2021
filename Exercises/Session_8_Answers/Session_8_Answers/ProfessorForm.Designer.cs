
namespace Session_8_Answers {
    partial class ProfessorForm {
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonSubmitStudent = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlCourse = new DevExpress.XtraEditors.TextEdit();
            this.ctrlRank = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRank.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(507, 350);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(146, 35);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Close";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(250, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(258, 53);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Schedule Data";
            // 
            // ButtonSubmitStudent
            // 
            this.ButtonSubmitStudent.Appearance.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmitStudent.Appearance.Options.UseFont = true;
            this.ButtonSubmitStudent.Location = new System.Drawing.Point(355, 350);
            this.ButtonSubmitStudent.Name = "ButtonSubmitStudent";
            this.ButtonSubmitStudent.Size = new System.Drawing.Size(146, 35);
            this.ButtonSubmitStudent.TabIndex = 19;
            this.ButtonSubmitStudent.Text = "Submit Schedule";
            this.ButtonSubmitStudent.Click += new System.EventHandler(this.ButtonSubmitStudent_Click);
            // 
            // ctrlCourse
            // 
            this.ctrlCourse.Location = new System.Drawing.Point(309, 188);
            this.ctrlCourse.Name = "ctrlCourse";
            this.ctrlCourse.Size = new System.Drawing.Size(269, 20);
            this.ctrlCourse.TabIndex = 18;
            // 
            // ctrlRank
            // 
            this.ctrlRank.Location = new System.Drawing.Point(309, 135);
            this.ctrlRank.Name = "ctrlRank";
            this.ctrlRank.Size = new System.Drawing.Size(269, 20);
            this.ctrlRank.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(125, 186);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(127, 20);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Professor Course: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(161, 133);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 20);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Professor Rank";
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(665, 397);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.ButtonSubmitStudent);
            this.Controls.Add(this.ctrlCourse);
            this.Controls.Add(this.ctrlRank);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Name = "ProfessorForm";
            this.Text = "ScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRank.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton ButtonSubmitStudent;
        private DevExpress.XtraEditors.TextEdit ctrlCourse;
        private DevExpress.XtraEditors.TextEdit ctrlRank;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}