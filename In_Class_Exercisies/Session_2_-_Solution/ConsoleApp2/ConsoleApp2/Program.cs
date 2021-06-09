using ClassLibrary1;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {

    class Program {

        static void Main(string[] args) {

            ClassLibrary1.Cat cat1 = new ClassLibrary1.Cat();

            Cat cat2 = new Cat();


            Dog oDog = new Dog();

            // Hungarian Notation
            Dog objDog = new Dog();



            // Pascal Casing
            // eg: BlackDog, WhiteCat

            // camel Casing
            // eg: blackDog, whiteCat

            // 1. Namespace, Class, Object, Methods, Properties -> Pascal Casing

            // 2. Types, local visibility -> camel Casing


            // Primitive Types:

            #region Value Types

            bool isDog;
            int? legsCount = null;

            const int constantValue = 0;

            Int32 legsCount1 = 4;
            uint tailCount = 1;
            short headCount = 1;

            decimal height = 0.3m;
            float length = 1.4f;

            #endregion

            #region Reference Types
            string name = "Rex";

            object obj = new Dog();

            object surname = "Chris";

            object h1 = 1;
            #endregion

            // --> null reference
            //decimal legsAlien = (decimal)legsCount;

            decimal legsX = Convert.ToDecimal(legsCount);

            string a = "epsilon net";
            string b = "coding";
            string c = "school";
            string space = " ";
            int year = 2021;

            string title = a + space + b + space + c + year;

            DisplayResult(title);

            //int n = Convert.ToInt32(title);

            string readLine = Console.ReadLine();

            DisplayEntry(readLine);

            double p = RaiseToPower(2, Convert.ToDouble(readLine));

            DisplayResult(p);

            Console.ReadLine();


            #region Question #1
            readLine = Console.ReadLine();
            Question1(5, 4);
            #endregion

            //Question #2

        }

        // method
        static void DisplayEntry(object obj) {

            string s = "You have entered: " + obj;

            Console.WriteLine(s);
        }

        static void DisplayResult(object obj) {

            string s = "The Result is: " + obj;

            Console.WriteLine(s);
        }

        // function
        static double RaiseToPower(double i, double j) {

            return Math.Pow(i, j);
        }



        // function
        static double Question1(double i, double j) {

            return Math.Pow(i, j);
        }
    }
}







