using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Answers.ClassesQuestion2 {
    class Institute {

        //Constructor
        public Institute() { }

        //Properties
        public Guid _id { get; set; }
        public string Name { get; set; }
        public int YearInService { get; set; }

        //operations
        public void GetName() { }
        public string SetName(string name) {
            return name;
        }

    }
}
