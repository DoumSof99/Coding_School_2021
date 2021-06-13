using DevExpress.Utils.Menu;
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
    public partial class CoursesForm : Form {

        public Course NewCourse { get; set; }

        public CoursesForm() {
            InitializeComponent();
        }

        private void ButtonSubmitStudent_Click(object sender, EventArgs e) {

            NewCourse.Subject = Convert.ToString(ctrlSubject.EditValue);
            NewCourse.Hours = Convert.ToInt32(ctrlHours.EditValue);
            //IDXDropDownControl dropDownControl = ctrlCategory.DropDownControl;
            //NewCourse.Category = dropDownControl;

            DialogResult = DialogResult.OK;

            Close();

        }

        //public void Message() {
        //    MessageBox.Show("Data Succesfully added!.", "Success",
        //            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //}

        private void simpleButton1_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void ctrlCategory_Click(object sender, EventArgs e) {
           
        }
    }
}
