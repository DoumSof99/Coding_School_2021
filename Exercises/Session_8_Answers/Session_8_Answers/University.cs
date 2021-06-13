using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_8_Answers {
    public class University {

        public class Student : Person {
            public Guid ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }

        }

        public class Course : Person {
            public Guid ID { get; set; }
            public string Subject { get; set; }
            public int Hours { get; set; }
            //public CourseCategoryEnum Category { get; set; }

        }

        public class Professor {
            public string Rank { get; set; }

            public Course course { get; set; }

        }

        public class Person {

        }

    }
}
