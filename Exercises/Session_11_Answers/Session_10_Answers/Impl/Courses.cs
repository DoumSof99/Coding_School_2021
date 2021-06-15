using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10_Answers.Impl {
    public class Course : Person {

        public string Code { get; set; }
        public string Subject { get; set; }
        public int Hours { get; set; }
        public CourseCategoryEnum Category { get; set; }

        public Course() : base() {

        }


    }
}
