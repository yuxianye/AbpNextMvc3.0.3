using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Customers.Customer.ViewModels
{
    public class CreateEditCustomerViewModel
    {
        [Display(Name = "CustomerName")]
        public string Name { get; set; }

        [Display(Name = "CustomerAddress")]
        public string Address { get; set; }

        [Display(Name = "CustomerContact")]
        public string Contact { get; set; }

        [Display(Name = "CustomerPhone")]
        public string Phone { get; set; }

        [Display(Name = "CustomerRemark")]
        public string Remark { get; set; }
    }
}