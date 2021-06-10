using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_8_Answers {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {

        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void AddCourse_Click(object sender, EventArgs e) {

            CoursesForm coursesForm = new CoursesForm();
            coursesForm.ShowDialog();
        }

        private void AddStudent_Click(object sender, EventArgs e) {
            
            StudentForm form = new StudentForm();
            form.ShowDialog();
        }

        private void AddSchedule_Click(object sender, EventArgs e) {

            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.ShowDialog();
        }
    }
}
