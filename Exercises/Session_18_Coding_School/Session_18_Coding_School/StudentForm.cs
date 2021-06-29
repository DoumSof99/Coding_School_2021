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
    public partial class StudentForm : Form {

        private Coding_SchoolAppContext _Coding_SchoolContext; //context (model + config)

        public StudentForm() {
            
            InitializeComponent();
            
            bindingSource1.DataSource = typeof(Student);
            gridStudents.AutoGenerateColumns = false;

            gridStudents.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" });
            gridStudents.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Surname", HeaderText = "Surname" });
            gridStudents.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Birthday", HeaderText = "Birthday" });
            gridStudents.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Address", HeaderText = "Address" });

            ctrlName.DataBindings.Add("Text", bindingSource1, "Name");
            ctrlSurname.DataBindings.Add("Text", bindingSource1, "Surname");
           // ctrlBirthday.DataBindings.Add("Value", bindingSource1, "Birthday");
            ctrlAddress.DataBindings.Add("Text", bindingSource1, "Address");

            gridStudents.DataSource = bindingSource1;
        }

        private void StudentForm_Load(object sender, EventArgs e) {

            var optionsBuilder = new DbContextOptionsBuilder<Coding_SchoolAppContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbCoding_SchoolApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            _Coding_SchoolContext = new Coding_SchoolAppContext(optionsBuilder.Options);

            Refresh();

        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e) {
            _Coding_SchoolContext.Dispose(); // to close
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            _Coding_SchoolContext.SaveChanges(); // save chages to database
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var student = bindingSource1.Current as Student;

            if (student is null) {
                return;
            }

            bindingSource1.RemoveCurrent(); 
            _Coding_SchoolContext.Students.Remove(student); // delete from database record / in the back

        }
        private void btnRefresh_Click(object sender, EventArgs e) {
            Refresh();
        }

        private void Refresh() {

            bindingSource1.Clear();

            _Coding_SchoolContext.ChangeTracker.Clear();

            foreach (var student in _Coding_SchoolContext.Students.ToList()) {
                bindingSource1.Add(student);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddStudent();
        }

        private void AddStudent() {

            var newStudent = new Student();
            newStudent.Name = "Insert Value";

            bindingSource1.Insert(0, newStudent);
            _Coding_SchoolContext.Students.Add(newStudent);

        }

    }
}
