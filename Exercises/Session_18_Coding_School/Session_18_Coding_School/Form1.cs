using Coding_School.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_18_Coding_School {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e) {
            ShowStudentForm();
        }
        
        private void btnCourse_Click(object sender, EventArgs e) {
            ShowCourseForm();
        }

        private void ShowStudentForm() {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
        }

        private void ShowCourseForm() {
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();
        }
    }
}
