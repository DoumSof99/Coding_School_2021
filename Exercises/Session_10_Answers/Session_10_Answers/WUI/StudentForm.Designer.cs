
namespace Session_10_Answers.WUI {
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(79, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(183, 25);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Add New Student...";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Surname :";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(39, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name :";
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(79, 133);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(295, 20);
            this.ctrlSurname.TabIndex = 13;
            // 
            // ctrlName
            // 
            this.ctrlName.EditValue = "";
            this.ctrlName.Location = new System.Drawing.Point(79, 91);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(100, 20);
            this.ctrlName.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(423, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(298, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 32);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 394);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}