using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Answers.ClassesQuestion2 {
    class Student : Person {

        // Constructor
        public Student() { }

        //properties
        public int RegistrationNumber { get; set; }
        public Course[] Course { get; set; }

        //operations
        public void Attend(Course course, DateTime dateTime) { }

        public void WriteExam(Course course, DateTime dateTime) { }

    }
}
