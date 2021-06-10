using Session_8_Answers.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Session_8_Answers.Classes.University;

namespace Session_8_Answers {

    public partial class StudentForm : Form {

        public StudentForm() {
            InitializeComponent();
        }

        private void TextEditName_EditValueChanged(object sender, EventArgs e) {
            
        }

        private void ButtonSubmitStudent_Click(object sender, EventArgs e) {
            
            Students student = new Students();

            string name = TextEditName.Text;
            string course = TextEditCourse.Text;
            int age = int.Parse(TextEditAge.Text);
            int year = int.Parse(TextEditYear.Text);
            
            student.AddStudent(name, course, age, year);
            Message();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void Message() {
            MessageBox.Show("Data Succesfully added!.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
