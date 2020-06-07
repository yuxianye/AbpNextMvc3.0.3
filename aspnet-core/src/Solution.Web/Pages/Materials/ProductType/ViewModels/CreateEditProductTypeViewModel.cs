using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Materials.ProductType.ViewModels
{
    public class CreateEditProductTypeViewModel
    {
        [Display(Name = "ProductTypeName")]
        public string Name { get; set; }

        [Display(Name = "ProductTypeRemark")]
        public string Remark { get; set; }
    }
}