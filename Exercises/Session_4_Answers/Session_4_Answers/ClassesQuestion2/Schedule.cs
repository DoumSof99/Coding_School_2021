using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Answers.ClassesQuestion2 {
    class Schedule {

        // Constructor
        public Schedule() { }

        //Attributes
        public Guid _id { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Callendar { get; set; }


    }
}
