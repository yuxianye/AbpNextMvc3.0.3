using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Customers.Customer.ViewModels
{
    public class CreateEditCustomerViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "CustomerName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.AddressLength)]
        [Display(Name = "CustomerAddress")]
        public string Address { get; set; }

        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "CustomerContact")]
        public string Contact { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        [Display(Name = "CustomerPhone")]
        public string Phone { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "CustomerRemark")]
        public string Remark { get; set; }
    }
}