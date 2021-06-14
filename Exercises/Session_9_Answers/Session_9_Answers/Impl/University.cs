﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9_Answers.Impl {
    public class University : Institute {

        //prop
        public List<Student> Students { get; set; }
        public List<Courses> Courses { get; set; }
        public List<Professor> Professors { get; set; }

        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduleCourses { get; set; }

        //ctor
        public University() {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Courses>();
        }

    }
}
