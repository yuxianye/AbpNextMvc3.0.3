using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Suppliers.SupplierLevel.ViewModels
{
    public class CreateEditSupplierLevelViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "SupplierLevelName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "SupplierLevelRemark")]
        public string Remark { get; set; }
    }
}