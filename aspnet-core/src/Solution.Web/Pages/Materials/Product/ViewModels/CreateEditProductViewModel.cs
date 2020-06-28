using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Materials.Product.ViewModels
{
    public class CreateEditProductViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        [Display(Name = "ProductCode")]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "ProductName")]
        public string Name { get; set; }

        [Display(Name = "ProductProductTypeId")]
        public Guid ProductTypeId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "ProductSpecification")]
        public string Specification { get; set; }

        [Display(Name = "ProductUnitId")]
        public Guid UnitId { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "ProductRemark")]
        public string Remark { get; set; }
    }
}