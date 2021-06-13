using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9_Answers.Impl {
    public class Courses : Entity {

        public string Subject { get; set; }
        public int Hours { get; set; }
        public CoursesCatagoryEnum Category { get; set; }

        public Courses() : base() {
                
        }

    }
}
