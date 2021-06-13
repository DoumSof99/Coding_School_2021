using Nancy.Json;
using Session_9_Answers.Impl;
using Session_9_Answers.WUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_9_Answers {
    public partial class Form1 : Form {

        private const string _TxtFile = "UniversityData.txt";
        private const string _JsonFile = "UniversityData.json";

        University university = new University();

        List<Student> Students = new List<Student>();
        List<Courses> Courses = new List<Courses>();
        List<Professor> Professors = new List<Professor>();

        public Form1() {
            InitializeComponent();
        }

        private void ctrlStudentButton_Click(object sender, EventArgs e) {

            AddStudent();

            RefreshStudentList();

        }

        public void AddStudent() {
            Student student = new Student();

            StudentForm form = new StudentForm();
            form.NewStudent = student;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
    //                university.Students.Add(student);
                    Students.Add(student);
                    break;
                case DialogResult.Cancel:
                    break;               
                default:
                    MessageBox.Show("Wrong Entries", "Error");
                    break;
            }

        }

        public void RefreshStudentList() {
        //    ctrlUniversityList.Items.Clear();

            foreach (Student item in Students) {
                
                ctrlUniversityList.Items.Add(string.Format("Student: {0} {1} {2}", item.Name, item.Surname, item.Age));
            }

        }

        private void ctrlCourseButton_Click(object sender, EventArgs e) {
            AddCourse();

            RefreshCourseList();
        }

        public void AddCourse() {
            Courses courses = new Courses();

            CoursesForm form = new CoursesForm();
            form.NewCourse = courses;


            DialogResult result = form.ShowDialog(); 
            switch (result) {
                case DialogResult.OK:
                    Courses.Add(courses);
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    MessageBox.Show("Wrong Entries", "Error");
                    break;
            }

        }

        public void RefreshCourseList() {
        //    ctrlUniversityList.Items.Clear();

            foreach (Courses item in Courses) {
                // TODO: if item exists clear
                ctrlUniversityList.Items.Add(string.Format("Course: {0} {1}", item.Subject, item.Hours));

            }
        }

        private void ctrlProfessorButton_Click(object sender, EventArgs e) {
            AddProfessor();

            RefreshProfessorList();

        }
        public void AddProfessor() {
            Professor professor = new Professor();

            ProfessorForm form = new ProfessorForm();
            form.NewProfessor = professor;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    Professors.Add(professor);
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }

        }

        public void RefreshProfessorList() {
          //  ctrlUniversityList.Items.Clear();

            foreach (Professor item in Professors) {
                ctrlUniversityList.Items.Add(string.Format("Professor: {0} {1} {2}", item.Name, item.Surname, item.Age));
            }
        }

        private void ctrlExit_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ctrlSaveTxt_Click(object sender, EventArgs e) {
            WriteToTxt();
        }

        public void WriteToTxt() {
            string path = Path.Combine(Environment.CurrentDirectory, _TxtFile);

            string data = string.Empty;
            //foreach (var item in collection) {

            //}

        }

        private void ctrlSerialize_Click(object sender, EventArgs e) {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(Students);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }

        private void ctrlDeserialize_Click(object sender, EventArgs e) {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string data = File.ReadAllText(path);

            Students = serializer.Deserialize<List<Student>>(data);

            RefreshStudentList();
            
        }
    }
}
