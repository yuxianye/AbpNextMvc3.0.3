using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Suppliers.Suppliers.ViewModels
{
    public class CreateEditSuppliersViewModel
    {
        [Display(Name = "SuppliersCode")]
        public string Code { get; set; }

        [Display(Name = "SuppliersName")]
        public string Name { get; set; }

        [Display(Name = "SuppliersSupplierLevelId")]
        public Guid SupplierLevelId { get; set; }

        [Display(Name = "SuppliersContact")]
        public string Contact { get; set; }

        [Display(Name = "SuppliersPhone")]
        public string Phone { get; set; }

        [Display(Name = "SuppliersFax")]
        public string Fax { get; set; }

        [Display(Name = "SuppliersAddress")]
        public string Address { get; set; }

        [Display(Name = "SuppliersEmail")]
        public string Email { get; set; }

        [Display(Name = "SuppliersRemark")]
        public string Remark { get; set; }
    }
}