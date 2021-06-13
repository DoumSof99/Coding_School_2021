
namespace Session_9_Answers.WUI {
    partial class CoursesForm {
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
            this.ctrlHours = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSubject = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlHours
            // 
            this.ctrlHours.Location = new System.Drawing.Point(130, 169);
            this.ctrlHours.Name = "ctrlHours";
            this.ctrlHours.Size = new System.Drawing.Size(249, 20);
            this.ctrlHours.TabIndex = 15;
            // 
            // ctrlSubject
            // 
            this.ctrlSubject.Location = new System.Drawing.Point(130, 129);
            this.ctrlSubject.Name = "ctrlSubject";
            this.ctrlSubject.Size = new System.Drawing.Size(249, 20);
            this.ctrlSubject.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(64, 176);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Hours:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(64, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Subject:";
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Location = new System.Drawing.Point(512, 387);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(75, 23);
            this.ctrlCancel.TabIndex = 11;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // ctrlOK
            // 
            this.ctrlOK.Location = new System.Drawing.Point(412, 387);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(75, 23);
            this.ctrlOK.TabIndex = 10;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(49, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(237, 35);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Add New Course...";
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.ctrlHours);
            this.Controls.Add(this.ctrlSubject);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOK);
            this.Controls.Add(this.labelControl1);
            this.Name = "CoursesForm";
            this.Text = "CoursesForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit ctrlHours;
        private DevExpress.XtraEditors.TextEdit ctrlSubject;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton ctrlCancel;
        private DevExpress.XtraEditors.SimpleButton ctrlOK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}