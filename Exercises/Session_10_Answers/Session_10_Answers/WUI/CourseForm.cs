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
    public partial class CourseForm : Form {

        public Course NewCourse { get; set; }

        public CourseForm() {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e) {

        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (ctrlCode.EditValue.ToString().Length > 0) {

                NewCourse.Code = Convert.ToString(ctrlCode.EditValue);
                NewCourse.Subject = Convert.ToString(ctrlSubject.EditValue);

                DialogResult = DialogResult.OK;
            }
            else {

                MessageBox.Show("Please insert code!");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
