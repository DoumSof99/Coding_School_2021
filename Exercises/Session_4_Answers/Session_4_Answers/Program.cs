using Session_4_Answers.ClassesQuestion2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Answers {
    class Program {
        static void Main(string[] args) {

            //--------------Question1-------------------
            Answers1Class answers = new Answers1Class();
            answers.Recursion();

            Console.Write("\n\nEnter to continue...");
            Console.ReadLine();

            //--------------Question2-------------------

            University university = new University();
            university.GetCourses();
            university.GetStudents();

            Professor professor = new Professor();
            professor.GetName();

            Institute institute = new Institute();
            string s = institute.SetName("Sofia");

            Console.Write("\n{0}", s);

            Console.Write("\n\nEnter to exit...");
            Console.ReadLine();

        }
    }
}
