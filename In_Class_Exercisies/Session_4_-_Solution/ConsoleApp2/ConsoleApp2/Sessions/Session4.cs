using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Sessions {

    public class Person : Movable {

        public string Name { get; set; }

        public Person() {
            Name = "Fotis";
        }

    }



    public class Movable {

        public virtual void Move() { }

        public virtual void Stop() { }
    }
    
    public class Vehicle : Movable {

        public int NumberOfWheels { get; set; }

    }

    public class Bicycle : Vehicle {

        public Bicycle() {
            NumberOfWheels = 2;
        }
    }

    public class Car : Vehicle {

        public Car() {
            NumberOfWheels = 4;
        }

    }

    public class Audi : Car {

        public void AutomateParking() { 
        }
    }


    public class Session4 {

        // Constructor
        public Session4() {

        }

        #region By Ref / Out Implementation
        public void ByRef_Out() {

            string s = "Fotis";

            int i = 10;

            DisplayIncrement(i);

            Console.WriteLine("Initial string =" + s);

            SetPrefixOut(out s);

            Console.WriteLine("Final String=" + s);


            //Person c = new Person();
            //ConcatX(c);

            Console.WriteLine("Final String=" + s);

            Console.ReadLine();

        }

        private void DisplayIncrement(int i) {
            Console.WriteLine("Initial value =" + i);
            
            Increment(i);

            Console.WriteLine("Value=" + i);
        }

        public void Increment(int number) {
            number++;
        }

        public void SetPrefixRef(ref string name) {
            name = " Mr/Mrs. " + name;
        }

        public void SetPrefixOut(out string name) {
            name = "Giannis";
            name = " Mr/Mrs. " + name;
        }

        public void SetPrefixObject(Person c) {

            c.Name = " Mr/Mrs. " + c.Name;
        }
        #endregion

        #region Parse / TryParse
        public void Conversion() {

            string s = Console.ReadLine();

            int i = 0;

            int j = 100;

            if (Int32.TryParse(s, out i)) {

                Console.WriteLine(j + i);

            }
            else {
                Console.WriteLine("not a number!");
            }
            

            Console.ReadLine();
        }
        #endregion

        public void CommonUnboxingError() {

            int? j = null;

            string s;

            object obj = j;

            // ok
            s = Convert.ToString(obj);

            // error!
            s = obj.ToString();





            Console.ReadLine();

        }

        #region Method Overloading

        public void  MethodOverloading() {

            string s = "Fotis";
            string r = "Chrysoulas";

            s = AddPrefix(s, r);

            Console.WriteLine(s);

            Console.ReadLine();
        }

        private string AddPrefix(string name) {

            // overloaded call
            return AddPrefix(name, string.Empty);
        }

        private string AddPrefix(string name, string surname) {

            // overloaded call
            return AddPrefix(name, surname, string.Empty);
        }

        private string AddPrefix(string name, string surname, string fatherName) {

            // actual implementation
            return string.Format("Mr/Mrs {0} {1} {2}", name, surname, fatherName);
        }
        #endregion

        #region Recursion

        public void Recursions() {


            double j = ProductOfRec(5);

            Console.WriteLine(j);

            Console.ReadLine();
        }


        public double ProductOf(int number) {

            double f = 1;
            for (int i = number; i > 0; i--) {
                f *= i;
                Console.WriteLine(string.Format("i: {0} f: {1}", i, f));
            }
            return f;
        }

        public double ProductOfRec(int number) {

            if (number == 0) {
                return 1;
            }

            Console.WriteLine(string.Format("number: {0}", number));

            return number * ProductOfRec(number - 1);

        }
        #endregion

        public void Inheritance() {


            Covid covid = new Covid();
            
            string s = covid.Kill();
        
        
           
        }

    }
}
