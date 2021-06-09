using Session_4_Answers.ClassesQuestion2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Answers {
    class University : Institute {

        //constructor
        public University() { }

        //properties
        public Student[] Students { get; set; }

        public Course[] Courses { get; set; }
         
        public Grade[] Grades { get; set; }

        public Schedule ScheduledCourse { get; set; }

        //operations
        public void GetStudents() { }
        public void GetCourses() { }
        public void GetGrades() { }
        public void SetSchedule(Course courseID, Professor professorID, DateTime dateTime) { }


    }
}
