using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Suppliers.Suppliers.ViewModels
{
    public class CreateEditSuppliersViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        [Display(Name = "SuppliersCode")]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "SuppliersName")]
        public string Name { get; set; }

        [Display(Name = "SuppliersSupplierLevelId")]
        public Guid SupplierLevelId { get; set; }

        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "SuppliersContact")]
        public string Contact { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        [Display(Name = "SuppliersPhone")]
        public string Phone { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        [Display(Name = "SuppliersFax")]
        public string Fax { get; set; }

        [StringLength(MySolutionConsts.AddressLength)]
        [Display(Name = "SuppliersAddress")]
        public string Address { get; set; }

        [EmailAddress]
        [StringLength(MySolutionConsts.EmailLength)]
        [Display(Name = "SuppliersEmail")]
        public string Email { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "SuppliersRemark")]
        public string Remark { get; set; }
    }
}