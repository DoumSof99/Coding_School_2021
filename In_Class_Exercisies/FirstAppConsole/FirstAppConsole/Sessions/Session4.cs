using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppConsole.Sessions {

    public class Person {

        public string Name { get; set; }

        public Person(){
            Name = "Sofia";
        }

    }
    
    public class Session4 {

        // Constructor
        public Session4() {
        
        }

        #region By Ref / Out Implementation
        public void ByRef_Out() {

            string s = "Sofia ";

            int i = 10;

            SetIncrement(s, i);
            //SetPrefixRef(ref s);

            //Person c = new Person();
            //ConcatX(c);

            //s = ConcatFunction(s);

            SetPrefixOut(out s);

            Console.WriteLine("New string=" + s);

            Console.WriteLine("New value=" + i);
            //Console.WriteLine("New string=" + c.Name);

            Console.ReadLine();

        }

        private void SetIncrement(string s, int i) {
            Console.WriteLine("Initial value=" + i);
            Console.WriteLine("Initial string=" + s);

            Increment(i);
        }

        public void Increment(int number) {
            number++;
        }

        // reference influence the method
        public void SetPrefixRef(ref string name) {
            name += " Test ";
        }

        public void SetPrefixOut(out string name) {
            name = "Sofia";
            name = " Mr " + name;
        }

        public void ConcatX(Person c) {
            c.Name += "Test";
        }
        #endregion

        #region Rarse / TryParse
        public void Conversion() {

            string s = Console.ReadLine();
            
            int i = 0;

            int j = 100;

            if (Int32.TryParse(s, out i)) {
                Console.WriteLine(j + i);
            }
            else {
                Console.WriteLine("Not a number");
            }


            Console.ReadLine();
        }
        #endregion

        #region Method Overloading

        public void MethodOverloading() {

            string s = "Sofia";
            string r = "Doumani";
            string f = "Isaak";

            s = AddPrefix(s, r, f);

            Console.WriteLine(s);

            Console.ReadLine();

        }

        private string AddPrefix(string name) {
            // Overloaded call
            return AddPrefix(name, string.Empty);

            //return string.Format("Mr./Ms. {0}", name);
        }

        private string AddPrefix(string name, string surname) {
            // Overloaded call
            return string.Format("Mr./Ms. {0} {1}", name, surname);
        }

        private string AddPrefix(string name, string surname, string fatherName) {
            // Actual Overloaded implemetation
            return string.Format("Mr./Ms. {0} {1} and father's name is {2}", name, surname, fatherName);
        }

        #endregion

        #region recursion

        public void Recursion() {

            //double j =ProductOf(5);
            double j = ProductOfRec(5);

            Console.WriteLine(j);

            Console.ReadLine();
        }


        public double ProductOf(int number) {
            double f = 1;

            for (int i = number; i >=1; i--) {
                f *= i;
                Console.WriteLine(string.Format("i: {0} f: {1}", i, f));
            }
            return f;
        }

        public double ProductOfRec(int number) {

            if (number == 0) {
                return 1;
            }

            Console.WriteLine(string.Format("Number: {0} ", number));

            return number * ProductOfRec(number - 1);

            //double f = 1;

            //for (int i = number; i >= 1; i--) {
            //    f *= i;
            //    Console.WriteLine(string.Format("i: {0} f: {1}", i, f));
            //}
            //return f;
        }

        #endregion

        public void Inheritance() {

            Covid covid = new Covid();

            string s = covid.Kill();

            Console.WriteLine(s);
            Console.ReadLine();

        }


        #region Common Unboxing error
        public void CommonError() {

            int? j = null;

            string s;

            object obj = j;

            //string k = "0";

            s = Convert.ToString(obj);

            s = obj.ToString();

            int i = Convert.ToInt32(obj);


            Console.ReadLine();

        }
        #endregion

    }


    public class People : Moveable {

    }

    public class Moveable {
        public virtual void Move() { }

        public virtual void Stop() { }
    }

    public class Vehicle : Moveable{
        public int NumberOfWeels { get; set; }

    }

    public class Bike : Vehicle {

        public Bike() {
            NumberOfWeels = 2;
        }

    }

    public class Car : Vehicle {

        public Car() {
            NumberOfWeels = 4;
        }

    }

    public class Audi : Car {

    }

}
