using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Answers.ClassesQuestion2 {
    class Grade {

        //Constructor
        public Grade() { }

        // Attributes
        public Guid _id { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }

        // It can not have the same name as the enclosing type
        public int DoGrade { get; set; }

    }
}
