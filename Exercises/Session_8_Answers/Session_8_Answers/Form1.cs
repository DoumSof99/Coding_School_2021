using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Session_8_Answers.University;

namespace Session_8_Answers {
    public partial class Form1 : Form {

        List<Student> Students = new List<Student>();
        List<Course> Courses = new List<Course>();
        List<Professor> Professors = new List<Professor>();

        public Form1() {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {

        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void AddCourse_Click(object sender, EventArgs e) {

            Course course = new Course();

            CoursesForm form = new CoursesForm();
            form.NewCourse = course;

            DialogResult = form.ShowDialog();

            Courses.Add(course);

            RefreshCourseList();

        }

        private void AddStudent_Click(object sender, EventArgs e) {

            Student student = new Student();

            StudentForm form = new StudentForm();
            form.NewStudent = student;
            
            DialogResult = form.ShowDialog();

            Students.Add(student);

            RefreshStudentList();

        }

        private void AddProfessor_Click(object sender, EventArgs e) {

            Professor professor = new Professor();

            ProfessorForm form = new ProfessorForm();
            form.NewProfessor = professor;

            DialogResult = form.ShowDialog();

            Professors.Add(professor);

            RefreshProfessorList();

        }

        public void RefreshStudentList() {
            ctrlStudentsListBox.Items.Clear();

            foreach (Student item in Students) {
                ctrlStudentsListBox.Items.Add(String.Format("{0} {1}", item.Name, item.Surname));
            }
        }

        public void RefreshCourseList() {
            ctrllistBoxCourses.Items.Clear();

            foreach (Course item in Courses) {
                ctrllistBoxCourses.Items.Add(String.Format("{0} {1}", item.Subject, item.Hours));
            }
        }

        public void RefreshProfessorList() {
            ctrlProfessorList.Items.Clear();

            foreach (Professor item in Professors) {
                ctrlProfessorList.Items.Add(String.Format("{0} ", item.Rank));
            }

        }
    }
}
