using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Suppliers.SupplierLevel.ViewModels
{
    public class CreateEditSupplierLevelViewModel
    {
        [Display(Name = "SupplierLevelName")]
        public string Name { get; set; }

        [Display(Name = "SupplierLevelRemark")]
        public string Remark { get; set; }
    }
}