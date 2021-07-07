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
    public class DetailsModel : PageModel {

        [BindProperty]
        public ListCustomer SelectedListCustomer { get; set; }
        public ICustomerStorage _storage { get; set; }

        public DetailsModel(ICustomerStorage storage) {
            _storage = storage;
        }

        public void OnGet(int id) {
            if (id == 0) {
                SelectedListCustomer = new ListCustomer();
                return;
            }
            SelectedListCustomer = _storage.GetById(id);
        }

        public IActionResult OnPost() {
            _storage.AddCustomer(SelectedListCustomer);
            return RedirectToPage("List");
        }

        public IActionResult OnPostCancel() {
            return RedirectToPage("List");
        }

        public IActionResult OnPostDelete() {
            _storage.DeleteCustomer(SelectedListCustomer.Id);
            return RedirectToPage("List");
        }
    }
}
