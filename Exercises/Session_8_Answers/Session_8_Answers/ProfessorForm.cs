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
    public partial class ProfessorForm : Form {

        public Professor NewProfessor { get; set; }

        public ProfessorForm() {
            InitializeComponent();
        }

        private void ButtonSubmitStudent_Click(object sender, EventArgs e) {

            NewProfessor.Rank = Convert.ToString(ctrlRank.EditValue);
            //NewProfessor.course = Convert.ToString(ctrlCourse.EditValue);

            DialogResult = DialogResult.OK;
            Close();

        }
    
        private void simpleButton1_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

