using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_8_Answers.Classes {
    public class University : StudentForm{

        public class Students {

            //Properties
            public Guid ID { get; set; }
            public string StudentName { get; set; }
            public string StudentCourse { get; set; }
            public int StudentAge { get; set; }
            public int StudentYear { get; set; }


            //Constructor
            public Students() {

            }

            //Methods
            public void AddStudent(string name, string course, int age, int year) {

            }
        }

        public class Courses {

            //Properties
            public Guid ID { get; set; }
            public string Course { get; set; }
            public int Hours { get; set; }


            //Constructor
            public Courses() {

            }

            //Methods
            public void AddCourse(string course, int hours) {

            }

        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Name = "University";
            this.Load += new System.EventHandler(this.University_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void University_Load(object sender, EventArgs e) {

        }

        public class Schedule {

            //Properties
            public Guid ID { get; set; }
            public int ScheduleID { get; set; }
            public string Course { get; set; }


            //Constructor
            public Schedule() {

            }

            //Methods
            public void AddSchedule (int id, string course) {

            }

        }


    }
}
