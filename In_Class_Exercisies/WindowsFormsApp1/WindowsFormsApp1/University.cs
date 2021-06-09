using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    public class Course {

        //properties
        public string Subject { get; set; }
        public CourseCategoryEnum Category { get; set; }

        //Constructor
        public Course() {

        }

        //Methods

    }

    public class University{

        //Properties
        public int MyProperty { get; set; }

        //Constructor
        public University() {

        }

        //Methods
        public void Init() {
            List<Course> courses = new List<Course>();

            Course physics1 = new Course() {
                Subject = "Quantum Physics",
                Category = CourseCategoryEnum.Physics
            };

            courses.Add(physics1);

            Course physics2 = new Course() {
                Subject = "Electro-Physics",
                Category = CourseCategoryEnum.Physics
            };

            courses.Add(physics2);

            Course static1 = new Course() {
                Subject = "Static",
                Category = CourseCategoryEnum.CivilEngineering
            };

            courses.Add(static1);

            List<Course> physicsCourses = courses.FindAll(x => x.Category == CourseCategoryEnum.Physics);

        }

    }
}
