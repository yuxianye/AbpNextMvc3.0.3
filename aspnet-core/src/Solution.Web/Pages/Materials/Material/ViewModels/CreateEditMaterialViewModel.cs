using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Materials.Material.ViewModels
{
    public class CreateEditMaterialViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        [Display(Name = "MaterialCode")]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "MaterialName")]
        public string Name { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "MaterialSpecification")]
        public string Specification { get; set; }

        [Display(Name = "MaterialUnitId")]
        public Guid UnitId { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "MaterialRemark")]
        public string Remark { get; set; }
    }
}