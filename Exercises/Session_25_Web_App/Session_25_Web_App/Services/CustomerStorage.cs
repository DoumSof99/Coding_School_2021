using Customer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session_25_Web_App.Services {

    public class CustomerStorage : ICustomerStorage {
             // or DbCustomerStorage
        public List<ListCustomer> theCustomerList { get; set; }

        public CustomerStorage() {
            theCustomerList = new List<ListCustomer>();
        }

        public void AddCustomer(ListCustomer customer) {
            if (customer.Id == 0) {
                customer.Id = theCustomerList.Count + 1;
                theCustomerList.Add(customer);
                return;
            }

            var selectedCustomer = GetById(customer.Id);
            selectedCustomer.Name = customer.Name;
            selectedCustomer.Surname = customer.Surname;
            selectedCustomer.AFM = customer.AFM;
            selectedCustomer.Active = customer.Active;

        }

        public void DeleteCustomer(int id) {
            var selectedCustomer = GetById(id);

            if (selectedCustomer == null) {
                throw new Exception(string.Format("Customer with id '{0}' was not found.", id));
            }

            theCustomerList.Remove(selectedCustomer);
        }

        public List<ListCustomer> GetAllCustomers() {
            return theCustomerList;
        }

        public ListCustomer GetById(int id) {
            return theCustomerList.FirstOrDefault(cust => cust.Id == id);
        }
    }
}
