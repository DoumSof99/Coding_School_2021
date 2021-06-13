using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9_Answers.Impl {
    public class Student : Person {

        //Properties
        public int RegistrationNumber { get; set; }
        public List<Courses> Courses { get; set; }

        //Constructor
        public Student() {
            Courses = new List<Courses>();
        }

    }
}
