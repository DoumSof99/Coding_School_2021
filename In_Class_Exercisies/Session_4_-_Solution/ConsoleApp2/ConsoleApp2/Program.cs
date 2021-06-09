using ClassLibrary1;
using ConsoleApp2.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {

    class Program {

        static void Main(string[] args) {


            //Session3 session3 = new Session3();
            //session3.StringFormat();
            //session3.Increment();
            //session3.Properties();
            //session3.HandleCovid();


            Session4 session = new Session4();
            //session.ByRef_Out();
            //session.CommonUnboxingError();
            //session.MethodOverloading();
            //session.Recursions();

            //session.Inheritance();


            Vehicle monoCycle = new Vehicle();
            monoCycle.Stop();
            monoCycle.Move();
            monoCycle.NumberOfWheels = 1;

            Audi audi = new Audi();
            audi.Move();
            audi.Stop();


            string guid = Guid.NewGuid().ToString();


        }
    }

}







