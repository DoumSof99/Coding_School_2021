using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {


    public class Virus {



        public bool Infect() {

            return true;
        }

        public virtual string Kill() {
           

            return "kills in 60 days";
        
        }

        public void Mutate() {
        
        }

    }


    public class Covid : Virus {

        // Properties
        public decimal InfectionDistance { get; set; }
        public decimal KillRate { get; set; }
        public decimal MutationDays { get; set; }
        public string RequiredVacine { get; set; }

        // Constructor
        public Covid() {

        }

        // Action -> Method / Function
        public bool Infect(bool wearsMask, bool washesHands, decimal distance) {
            // ?

            // Logical Operator: ! , != , == , && , ||
            // Arithmetic Operator: < , > , <= , >= , <>

            //if (wearsMask == false) {
            //    // infected
            //    return true;
            //}
            //else if (!washesHands) {
            //    return true;
            //}
            //else {
            //    // sage
            //    return false;
            //}

            if (distance < InfectionDistance) {

                if (!wearsMask || !washesHands) {
                    // logic
                    return true;
                }
                else {
                    // logic
                    return false;
                }
            }
            else {
                return false;
            }
            

        }

        //public override string Kill() {
        //    return base.Kill();

        //   //return "kills in 20 days";
        //}

        public new void Mutate() {
            // ?
        }

        public bool Cured(string vacine, DateTime vacinationDate) {

            bool isCured = false;

            if ((DateTime.Now - vacinationDate).Days > MutationDays) {
                isCured = false;

            }
            else {

                switch (vacine) {
                    case "Astra Zeneca":
                    case "Pfeizer":
                    case "Johnson":
                    case "Moderna":
                        isCured = true;
                        break;

                    default:
                        isCured = false;
                        break;
                }
            }

            return isCured;
        }
    }


    public class Session3 {

        int j = 1;

        public int Age { get; set; }

        //public string Name {
        //    get { return "x"; }
        //    set { value = "x"; }
        //}

        //int k { get; set; }

        public void StringFormat() {


            // String Format
            string element1 = "Fotis";

            int element2 = 35;

            decimal element3 = 1.8m;

            string c = string.Format("My name is {0} and my age is {1:0000} and my height is {2:0.00}m", element1, element2, element3);

            Console.WriteLine(element1);
            Console.WriteLine(c);

            Console.ReadLine();
        }

        public void Increment() {


            int i = 100;

            i = i + 10;

            i++;

            i--;

            Console.WriteLine(i);

            Console.ReadLine();
        }

        public void Properties() {

            int i = 0;


            Age = 25;

            Console.WriteLine(Age);

            Console.ReadLine();
        }

        public void HandleCovid() {

            Covid covid = new Covid();
            covid.InfectionDistance = 1.3m;
            covid.KillRate = 0.005m;
            covid.MutationDays = 150;
            covid.RequiredVacine = "Astra Zeneca";

            bool isInfected = covid.Infect(true, true, 1m);

            DateTime dt = new DateTime(2021, 6, 1);
            

            bool isCured = covid.Cured("Astra Zeneca", dt);

            Console.WriteLine(isInfected);

            Console.ReadLine();
        }

        public void Arrays() {

            int[] a = { 1, 2, 3 };

            string[] animals = new string[4];

            animals[0] = "dog";
            animals[1] = "cat";
            animals[2] = "horse";
            animals[3] = "bird";


            Console.WriteLine("-- For".PadRight(20, '-'));
            for (int i = 0; i < animals.Length; i++) {

                string animal = animals[i];
                Console.WriteLine(animal);
            }

            Console.WriteLine("-- For Each ".PadRight(20, '-'));
            foreach (string item in animals) {

                Console.WriteLine(item);
            }

            Console.WriteLine("-- While ".PadRight(20, '-'));

            int j = 0;
            while (j < animals.Length) {

                string animal = animals[j];
                Console.WriteLine(animal);
                j++;
            }

            Console.WriteLine("-- Do While ".PadRight(20, '-'));
            int k = 0;
            do {

                string animal = animals[k];
                Console.WriteLine(animal);
                k++;

            } while (k < animals.Length);

            Console.ReadLine();

        }

    }
}