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
    public partial class CoursesForm : Form {

        public Courses NewCourse { get; set; }

        public CoursesForm() {
            InitializeComponent();
        }

        private void ctrlOK_Click(object sender, EventArgs e) {

            if (ctrlSubject.EditValue.ToString().Length == 0 || ctrlHours.EditValue.ToString().Length == 0) {

                MessageBox.Show("Please insert Values", "Error");

            }
            else {
                NewCourse.Subject = Convert.ToString(ctrlSubject.EditValue);
                NewCourse.Hours = Convert.ToInt32(ctrlHours.EditValue);

                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
