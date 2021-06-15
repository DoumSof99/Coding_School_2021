using Session_10_Answers.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Session_10_Answers.WUI {
    public partial class StudentForm : Form {

        public Student NewStudent { get; set; }

        public StudentForm() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {

            if (ctrlName.EditValue.ToString().Length > 0 ) {

                NewStudent.Name = Convert.ToString(ctrlName.EditValue);
                NewStudent.Surname = Convert.ToString(ctrlSurname.EditValue);

                DialogResult = DialogResult.OK;
               
            }
            else {
                MessageBox.Show("Please Insert Name");
            }

        }

        private void ctrlName_EditValueChanged(object sender, EventArgs e) {

           
        }
    }
}
