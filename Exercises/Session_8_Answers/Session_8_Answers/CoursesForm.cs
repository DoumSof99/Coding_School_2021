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
    public partial class CoursesForm : Form {
        public CoursesForm() {
            InitializeComponent();
        }

        private void ButtonSubmitStudent_Click(object sender, EventArgs e) {
            Courses courses = new Courses();

            string name = TextEditName.Text;
            int hours = int.Parse(TextEditHours.Text);

            courses.AddCourse(name, hours);
            Message();
        }

        public void Message() {
            MessageBox.Show("Data Succesfully added!.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
