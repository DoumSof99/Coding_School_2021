using Customer.Model;
using System.Collections.Generic;

namespace Session_25_Web_App.Services {
    public interface ICustomerStorage {
        public void AddCustomer(ListCustomer customer);
        public void DeleteCustomer(int id);
        public List<ListCustomer> GetAllCustomers();
        public ListCustomer GetById(int id);
    }
}
