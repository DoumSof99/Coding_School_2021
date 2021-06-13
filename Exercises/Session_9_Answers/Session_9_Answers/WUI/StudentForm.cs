using Session_9_Answers.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_9_Answers.WUI {
    public partial class StudentForm : Form {

        public Student NewStudent { get; set; }

        public StudentForm() {
            InitializeComponent();
        }

        private void ctrlOK_Click(object sender, EventArgs e) {

            if (ctrlName.EditValue.ToString().Length > 0 || ctrlSurname.EditValue.ToString().Length > 0 || ctrlAge.EditValue.ToString().Length > 0) {

                NewStudent.Name = Convert.ToString(ctrlName.EditValue);
                NewStudent.Surname = Convert.ToString(ctrlSurname.EditValue);
                NewStudent.Age = Convert.ToInt32(ctrlAge.EditValue);

                DialogResult = DialogResult.OK;
                Close();
            }
            else {
                MessageBox.Show("Please insert values!");
            }

        }

        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
