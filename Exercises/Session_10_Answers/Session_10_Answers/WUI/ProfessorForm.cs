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

namespace Session_10_Answers.WUI {
    public partial class ProfessorForm : Form {

        public Professor NewProfessor { get; set; }

        public ProfessorForm() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (ctrlName.EditValue.ToString().Length > 0) {

                // 1. MODIFY THE OBJECT STUDENT
                NewProfessor.Name = Convert.ToString(ctrlName.EditValue);

                NewProfessor.Surname = Convert.ToString(ctrlSurname.EditValue);

                // 2. CLOSE THE FORM!

                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                MessageBox.Show("Please insert Name!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
