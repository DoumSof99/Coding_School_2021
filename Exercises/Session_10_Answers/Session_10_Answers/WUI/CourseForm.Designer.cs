
namespace Session_10_Answers.WUI {
    partial class CourseForm {
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSubject = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCode = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(81, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(156, 25);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Add New Course";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 176);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Subject :";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(41, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Code :";
            // 
            // ctrlSubject
            // 
            this.ctrlSubject.Location = new System.Drawing.Point(81, 173);
            this.ctrlSubject.Name = "ctrlSubject";
            this.ctrlSubject.Size = new System.Drawing.Size(406, 20);
            this.ctrlSubject.TabIndex = 18;
            // 
            // ctrlCode
            // 
            this.ctrlCode.EditValue = "";
            this.ctrlCode.Location = new System.Drawing.Point(81, 116);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(100, 20);
            this.ctrlCode.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(408, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(293, 364);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 32);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 408);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ctrlSubject);
            this.Controls.Add(this.ctrlCode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOK);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit ctrlSubject;
        private DevExpress.XtraEditors.TextEdit ctrlCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOK;
    }
}