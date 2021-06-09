using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {

    public class Course {

        // PROPERTIES
        public string Subject { get; set; }
        public CoursesCategoryEnum Category { get; set; }

        // CONSTRUCTOR
        public Course() {

        }

        // METHODS
    }

    public class University {

        // PROPERTIES
        public int MyProperty { get; set; }


        // CONSTRUCTOR
        public University() {

        }

        //  METHODS
        public void Init() {

            List<Course> courses = new List<Course>();

            Course physics1 = new Course() {
                Subject = "Quantum Physics",
                Category = CoursesCategoryEnum.Physics
            };
            courses.Add(physics1);


            Course physics2 = new Course() {
                Subject = "Electo-Dynamics",
                Category = CoursesCategoryEnum.Physics
            };
            courses.Add(physics2);

            Course static1 = new Course();
            static1.Subject = "Static";
            static1.Category = CoursesCategoryEnum.CivilEngineering;
            
            courses.Add(static1);


            List<Course> physicsCourses = courses.FindAll(x => x.Category == CoursesCategoryEnum.Physics);

            List<Course> physicsCourses2 = new List<Course>(); 
            foreach  (Course x in courses) {

                if (x.Category == CoursesCategoryEnum.Physics) {
                    physicsCourses2.Add(x);
                }
            }



        }

        public void SetCourse() {


            //Courses physics1 = new Courses();
            //physics1.Category = CoursesCategoryEnum.Physics;

           


        }

        public void SetGrade(CoursesCategoryEnum coursesCategory) {

            decimal modifier = 0;

            switch (coursesCategory) {
                case CoursesCategoryEnum.Physics:
                    modifier = 0.8m;
                    break;
                case CoursesCategoryEnum.Mathematics:
                    modifier = 0.9m;
                    break;
                case CoursesCategoryEnum.Sociology:
                    modifier = 0.5m;
                    break;
                case CoursesCategoryEnum.Chemistry:
                    modifier = 0.66m;
                    break;
                case CoursesCategoryEnum.Financial:
                    modifier = 0.8m;
                    break;
                default:
                    break;
            }


            if (coursesCategory == CoursesCategoryEnum.Physics) { 
            
            
            }

            


        }

    }


    




  

}
