using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Materials.Material.ViewModels
{
    public class CreateEditMaterialViewModel
    {
        [Display(Name = "MaterialCode")]
        public string Code { get; set; }

        [Display(Name = "MaterialName")]
        public string Name { get; set; }

        [Display(Name = "MaterialSpecification")]
        public string Specification { get; set; }

        [Display(Name = "MaterialUnitId")]
        public Guid UnitId { get; set; }

        [Display(Name = "MaterialRemark")]
        public string Remark { get; set; }
    }
}