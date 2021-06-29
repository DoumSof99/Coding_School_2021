using Coding_School.Model;
using Coding_SchoolApp.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Session_18_Coding_School {
    public partial class CourseForm : Form {

        private Coding_SchoolAppContext _Coding_SchoolContext; 

        public CourseForm() {
            InitializeComponent();

            bindingSource1.DataSource = typeof(Course);
            gridCourses.AutoGenerateColumns = false;

            gridCourses.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Title", HeaderText = "Title" });
            gridCourses.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Category", HeaderText = "Category" });
            gridCourses.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Date", HeaderText = "Date" });
            gridCourses.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Duration", HeaderText = "Duration" });

            ctrlTitle.DataBindings.Add("Text", bindingSource1, "Title");
            ctrlCategory.DataBindings.Add("Text", bindingSource1, "Category");
           // ctrlDate.DataBindings.Add("Value", bindingSource1, "Birthday");
            ctrlDuration.DataBindings.Add("Text", bindingSource1, "Duration");

            gridCourses.DataSource = bindingSource1;

        }

        private void CourseForm_Load(object sender, EventArgs e) {

            var optionsBuilder = new DbContextOptionsBuilder<Coding_SchoolAppContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbCoding_SchoolApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            _Coding_SchoolContext = new Coding_SchoolAppContext(optionsBuilder.Options);

            Refresh();

        }

        private void CourseForm_FormClosed(object sender, FormClosedEventArgs e) {
            _Coding_SchoolContext.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            _Coding_SchoolContext.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var course = bindingSource1.Current as Course;

            if (course is null) {
                return;
            }

            bindingSource1.RemoveCurrent();
            _Coding_SchoolContext.Courses.Remove(course);
        }

        private void Refresh() {

            bindingSource1.Clear();

            _Coding_SchoolContext.ChangeTracker.Clear();

            foreach (var course in _Coding_SchoolContext.Courses.ToList()) {
                bindingSource1.Add(course);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddCourse();
        }

        private void AddCourse() {

            var newCourse = new Course();
            newCourse.Title = "Insert Title";

            bindingSource1.Insert(0, newCourse);
            _Coding_SchoolContext.Courses.Add(newCourse);

        }
    }
}
