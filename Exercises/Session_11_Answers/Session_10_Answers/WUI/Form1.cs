using Nancy.Json;
using Session_10_Answers.Impl;
using Session_10_Answers.WUI;
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

namespace Session_10_Answers {
    public partial class MdiMainForm : Form {

     //   private const string _LogFile = "Log.txt";
        private const string _JsonFile = "UniversityData.json";

        private University CodingSchool = new University();

        public MdiMainForm() {
            InitializeComponent();
        }

        
        private void MdiMainForm_Load(object sender, EventArgs e) {
            
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {

          //  AddStudent();
        }

        //public void AddStudent() {
        //    Student student = new Student();

        //    StudentForm form = new StudentForm();
        //    form.MdiParent = this;
        //    form.NewStudent = student;
        //    form.Show();

        //    DialogResult result = DialogResult.OK;
        //    switch (result) {
        //        case DialogResult.OK:
        //         //   CodingSchool.Students.Add(student);
        //            break;

        //        default:
        //            // messagge  ?
        //            break;
        //    }

        //}
       

        private void viewToolStripMenuItem_Click(object sender, EventArgs e) {
            ViewForm viewForm = new ViewForm {
                MdiParent = this,

                Type = EntityTypeEnum.Student,
                MasterData = CodingSchool,

                ViewData = GetStudentsList()
            };
            viewForm.Show();
        }

        private List<string> GetStudentsList() {

            List<string> studentList = new List<string>();

            if (CodingSchool?.Students != null) {


                foreach (Student item in CodingSchool.Students) {

                    studentList.Add(string.Format("ID={2} \t Name={0} \t Surname={1}", item.Name, item.Surname, item.ID));
                }
            }
            else {
                MessageBox.Show("No student data exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return studentList;
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e) {

           // AddCourse();
        }

        //public void AddCourse() {
        //    Course course = new Course();

        //    CourseForm form = new CourseForm();
        //    form.MdiParent = this;
        //    form.NewCourse = course;
        //    form.Show();

        //    DialogResult result = DialogResult.OK;
        //    switch (result) {
        //        case DialogResult.OK:
        //         //   CodingSchool.Courses.Add(course);
        //            break;

        //        default:
        //            // messagge  ?
        //            break;
        //    }
        //}

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e) {

            ViewForm viewForm = new ViewForm {
                MdiParent = this,

                Type = EntityTypeEnum.Course,
                MasterData = CodingSchool,

                ViewData = GetCoursesList()                
            };

            viewForm.Show();
        }

        private List<string> GetCoursesList() {

            List<string> coursesList = new List<string>();

            if (CodingSchool?.Students != null) { 


                foreach (Course item in CodingSchool.Courses) {

                    coursesList.Add(string.Format("ID={2} \t Code={0} \t Subject={1} ", item.Code, item.Subject, item.ID));
                }
            }
            else {
                MessageBox.Show("No course data exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return coursesList;

        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e) {

           // AddProfessor();
        }

        //public void AddProfessor() {
        //    Professor professor = new Professor();

        //    ProfessorForm form = new ProfessorForm();
        //    form.MdiParent = this;
        //    form.NewProfessor = professor;
        //    form.Show();

        //    DialogResult result = DialogResult.OK;
        //    switch (result) {
        //        case DialogResult.OK:
        //            CodingSchool.Professors.Add(professor);
        //            break;

        //        default:
        //            // messagge  ?
        //            break;
        //    }
        //}

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e) {
            ViewForm viewForm = new ViewForm();
            viewForm.MdiParent = this;

            viewForm.Type = EntityTypeEnum.Professor;
            viewForm.MasterData = CodingSchool;

            viewForm.ViewData = GetProfessorsList();
            viewForm.Show();
        }

        private List<string> GetProfessorsList() {

            List<string> professorsList = new List<string>();

            if (CodingSchool?.Professors != null) {


                foreach (Professor item in CodingSchool.Professors) {

                    professorsList.Add(string.Format("ID={2} \t Name={0} \t Surname={1} ", item.Name, item.Surname, item.ID));
                }
            }
            else {
                MessageBox.Show("No professor data exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return professorsList;

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            DeserializeFromJson();
        }

        private void DeserializeFromJson() {
            try {

                JavaScriptSerializer serializer = new JavaScriptSerializer();

                string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

                if (File.Exists(path)) {
                    string data = File.ReadAllText(path);

                    CodingSchool = serializer.Deserialize<University>(data);
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SerializeToJson();
        }

        private void SerializeToJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(CodingSchool);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            File.WriteAllText(path, data);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e) {
            AddEntity(EntityTypeEnum.Student);
        }

        private void AddEntity(EntityTypeEnum entityType) {
            switch (entityType) {
                case EntityTypeEnum.Course:

                    Course courseEntity = new Course();
                    EditForm courseForm = new EditForm();

                    courseForm.Type = entityType;
                    courseForm.EditObject = courseEntity;

                    if (courseForm.ShowDialog() == DialogResult.OK) {
                        CodingSchool.Courses.Add(courseEntity);
                    }

                    break;
                case EntityTypeEnum.Student:

                    Student studentEntity = new Student();
                    EditForm studentForm = new EditForm();

                    studentForm.Type = entityType;
                    studentForm.EditObject = studentEntity;

                    if (studentForm.ShowDialog() == DialogResult.OK) {
                        CodingSchool.Students.Add(studentEntity);
                    }

                    break;
                case EntityTypeEnum.Professor:

                    Professor professorEntity = new Professor();
                    EditForm professorForm = new EditForm();

                    professorForm.Type = entityType;
                    professorForm.EditObject = professorEntity;

                    if (professorForm.ShowDialog() == DialogResult.OK) {
                        CodingSchool.Professors.Add(professorEntity);
                    }

                    break;
                default:
                    break;
            }
        }

        private void addToolStripMenuItem1_Click_1(object sender, EventArgs e) {
            AddEntity(EntityTypeEnum.Course);
        }

        private void addToolStripMenuItem2_Click_1(object sender, EventArgs e) {
            AddEntity(EntityTypeEnum.Professor);
        }
    }
}
