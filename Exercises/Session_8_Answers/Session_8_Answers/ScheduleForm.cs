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
    public partial class ScheduleForm : Form {
        public ScheduleForm() {
            InitializeComponent();
        }

        private void ButtonSubmitStudent_Click(object sender, EventArgs e) {
            Schedule schedule = new Schedule();

            int num = int.Parse(TextEditNo.Text);
            string course = TextEditCourse.Text;

            schedule.AddSchedule(num, course);
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

