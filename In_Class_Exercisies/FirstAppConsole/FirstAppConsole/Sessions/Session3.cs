using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppConsole {

    public class Virus {
         
        public void Infect() {

        }

        public virtual string Kill() {

            //if(age < 13) {
            //    return "Safe";
            //}
            //if (age > 15) {
            //    return "Cautious";  
            //}
            //else if (age > 35) {
            //    return "Alert";
            //}

            return "Kills in 60 days";
        }

        public void Mutate() {

        }
        
    }

    public class Covid : Virus{
        //Properties
        public decimal InfectionDistance { get; set; }
        public decimal  KillRate { get; set; }
        public decimal MutationDays { get; set; }
        public string RequiredVacine { get; set; }


        //ctor + tab tab
        //constructor
        public Covid() {

        }
        //Action --> Method or Function


        //parameters in parenthesis
        //function
        public bool Infect(bool wearMask, bool washHands, decimal distance) {
            //variables


            //conditional --> bool: true or false
            //if + tab tab
            //if (wearMask == false) {
            //    return true;
            //}
            //else if(!washHands) {
            //    return true;
            //}
            //else {
            //    return false;
            //}


            //arithmetic operator
            if (distance < InfectionDistance) {

                //logical operators, 
                // && ampersnt
                // || pipeline
                if (!wearMask || !washHands) {
                    return true;
                }
                else {
                    return false;
                }

                //return !wearMask || washHands;
            }
            else {
                return false;
            }


        }

        public override string Kill() {
            //if(age < 13) {
            //    return "Safe";
            //}
            //if (age > 15) {
            //    return "Cautious";  
            //}
            //else if (age > 35) {
            //    return "Alert";
            //}


            //return base.Kill();
            return "kills in 20 days";
        }

        public new void Mutate() {

        }

        public bool Cured(string vacine, DateTime vacinationDate) {

            bool isCured = false;

            if ((DateTime.Now - vacinationDate).Days > MutationDays) {
                isCured = false;
            }
            else {
                // Astra Zeneca
                // Pfeiser
                // Johnson
                // Moderna

                switch (vacine) {
                    case "Astra Zeneca":
                    case "Pfeiser":
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

        //class variable
        int j = 1;


        // enter : prop + tab twice
        public int Age { get; set; }

        //public string Name {
        //    get {
        //        return "x";
        //    }
        //    set {
        //        value = "x";
        //    } 
        //}

        public void StrinFormat() {

            string s = "Sofia";

            int i = 34;

            decimal h = 1.8m;

            string c = string.Format("My name is {0} and i am {1}", s, i);

            string a = string.Format("My name is {0} and my age is {1:0000} and the data is {2:MM}", s, i, DateTime.Now);

            string b = string.Format("My name is {0} and i am {1}", s, h);

            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.ReadLine();



        }

        public void Increment() {

            int i = 100;

            i = i + i;

            i++;

            Console.WriteLine(i);
            Console.ReadLine();
        }

        public void Properties() {

            //method variable
            int i = 0;

            Age = 25;

            Console.WriteLine(Age);

            Console.ReadLine();
        }

        public void HandleCovid() {
            // propertiescan be use in every class
            //Age++;

            //visible calls vaiable
            //j++;


            Covid covid = new Covid();

            covid.InfectionDistance = 1.3m;
            covid.KillRate = 0.005m;
            covid.MutationDays = 150m;
            covid.RequiredVacine = "Astra Zenaca";

            bool isInfected = covid.Infect(true, true, 2m);

            DateTime dt = new DateTime(2021, 6, 1);

            bool isCured = covid.Cured("Astra Zeneca", dt);

            Console.WriteLine(isInfected);
            Console.ReadLine();

        }
    
        public void Arrays() {

            int[] a = { 1, 2, 3 };
            
            string[] animals = { "dog", "cat" , "horse", "bird"};

            Console.WriteLine("For".PadRight(20, '-'));

            for (int i = 0; i < animals.Length; i++) {

                string animal = animals[i];
                Console.WriteLine(animal);
            }

            Console.WriteLine("Foreach".PadRight(20, '-'));

            foreach (string item in animals) {
                Console.WriteLine(item);
            }

            Console.WriteLine("while".PadRight(20, '-'));

            int j = 0;
            while (j < animals.Length) {

                string animal = animals[j];
                Console.WriteLine(animal);
                j++;
            }

            Console.WriteLine("do-while".PadRight(20, '-'));
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
