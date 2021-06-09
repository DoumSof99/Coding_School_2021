using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppConsole {
    class Session2 {

        public void Execute(){
         
            
        Console.WriteLine("");
           

        Cat TheCat = new Cat();

        Dog TheDog = new Dog();

        //Pascal Casing : Namespace, Class, Methods, 
        //Poperties, Objects

        //camel Casing : type, local Visibility, 


        //Primative types:

        // Value types


        //#region Value Types

        bool isDog = true;

        int legsCount = 4;
        Int32 legsCount1 = 4;

        const int constantValue = 0;

        uint tailCount = 1;
        short headCount = 1;

        decimal height = 3.1m;

        float length = 1.4f;

        //#endregion

        // Reference types

        string name = "Rex";

        object obj = new Dog();

        decimal lengsAlien = (decimal)legsCount;
        decimal legsX = Convert.ToDecimal(legsCount);

        // Casting example
        string number = "1";

        int n = Convert.ToInt32(number);

        string a = "Sofia ";
        string b = "Doumani ";
        string c = "is coding";

        string title = a + b + c;

        DisplayResult(title);

        int i = 5;
        int j = 6;

        int sum = (i * j) + i;

        decimal devide = (decimal)i / j;


        double p = RaiseToPower(2, 2);

        DisplayResult(p);

        Console.WriteLine(sum);

        Console.WriteLine(devide);

        string readLine = Console.ReadLine();

        DisplayEntry(readLine);
        Console.ReadLine();

        }


    //Property
    public int TestProperty { get; set; }


    //Method
    static void DisplayEntry(object obj) {

        string s = "You have entered: " + obj;

        Console.WriteLine(s);
    }

    //Method
    public static void DisplayResult(object obj) {

        string s = "The result is " + obj;

        Console.WriteLine(s);
    }


    //Function

    static double RaiseToPower(double x, double y) {

        return Math.Pow(x, y);
    
        }
    }
}

