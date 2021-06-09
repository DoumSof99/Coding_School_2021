using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Answers.ClassesQuestion2 {
    class Professor : Person {

        // Construcor
        public Professor() {

        }

        //Properties / Attributes
        public string Rank { get; set; }
        public Course Course { get; set; }

        // Methods / Operations
        public void Teach(Course course, DateTime dateTime) {           
            switch (Rank) {
                default:
                    break;
            }
        }
        public void SetGrade(Student studentID, Course courseID, int grade) {

        }

        public new string GetName() {
            return "Dr. ";
        }

    }
}
