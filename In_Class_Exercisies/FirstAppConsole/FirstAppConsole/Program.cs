using ClassLibrary1;
using FirstAppConsole.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppConsole {
    class Program {
        static void Main(string[] args) {

            //Session3 session3 = new Session3();
            //session3.StringFormat();
            //session3.Increment();
            //session3.Properties();

            //session3.HandleCovid();

            //session3.Arrays();

            //Session2 session2 = new Session2();
            //session2.Execute();

            Session4 session = new Session4();

            //session.ByRef_Out();
            //session.Conversion();
            //session.CommonError();
            //session.MethodOverloading();
            //session.Recursion();

            //session.Inheritance();

            Vehicle vehicle = new Vehicle();
            vehicle.Move();
            vehicle.Stop();

            Audi audi = new Audi();
            audi.Move();
            audi.Stop();


            string guid = Guid.NewGuid().ToString();


        }

    }
}



