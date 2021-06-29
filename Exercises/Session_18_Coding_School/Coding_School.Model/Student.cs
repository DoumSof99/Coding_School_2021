using System;

namespace Coding_School.Model {
    public class Student : EntityBase {

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }

        public Student() :base () {
            Birthdate = new DateTime(3/15/2000);
        }

    }
}
