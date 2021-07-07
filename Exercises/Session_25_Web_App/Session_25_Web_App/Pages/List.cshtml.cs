using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Session_25_Web_App.Services;

namespace Session_25_Web_App.Pages
{
    public class ListModel : PageModel
    {
        // public List<int> MyList { get; set;  }

        public List<ListCustomer> MyCustomer { get; set; }

        private ICustomerStorage _customerStorage { get; set; }

        public ListModel(ICustomerStorage customerStorage) {
            _customerStorage = customerStorage;
        }

        public void OnGet() {
            // Example
            //MyList = new List<int>();
            //for (int i = 0; i < 10; i++) {
            //    MyList.Add(i);
            //}

            MyCustomer = _customerStorage.GetAllCustomers(); // or from Db

        }
    }
}
