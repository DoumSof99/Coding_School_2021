using Session_9_Answers.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_9_Answers.WUI {
    public partial class ProfessorForm : Form {

        public Professor NewProfessor { get; set; }

        public ProfessorForm() {
            InitializeComponent();
        }

        private void ctrlOK_Click(object sender, EventArgs e) {

            if (ctrlName.EditValue.ToString().Length == 0 || ctrlSurname.EditValue.ToString().Length == 0 || ctrlAge.EditValue.ToString().Length == 0) {
                MessageBox.Show("Please insert Values", "Error");
            }
            else {
                NewProfessor.Name = Convert.ToString(ctrlName.EditValue);
                NewProfessor.Surname = Convert.ToString(ctrlSurname.EditValue);
                NewProfessor.Age = Convert.ToInt32(ctrlAge.EditValue);

                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
