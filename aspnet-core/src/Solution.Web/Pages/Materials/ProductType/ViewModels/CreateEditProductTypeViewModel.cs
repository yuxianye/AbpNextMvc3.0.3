using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Materials.ProductType.ViewModels
{
    public class CreateEditProductTypeViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "ProductTypeName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "ProductTypeRemark")]
        public string Remark { get; set; }
    }
}