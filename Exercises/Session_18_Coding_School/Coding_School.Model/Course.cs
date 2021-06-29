using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_School.Model {
    public class Course : EntityBase {

        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }

        public Course() : base() {

        }

    }
}
