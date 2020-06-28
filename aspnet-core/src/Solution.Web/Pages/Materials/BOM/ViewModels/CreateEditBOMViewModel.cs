using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Materials.BOM.ViewModels
{
    public class CreateEditBOMViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "BOMName")]
        public string Name { get; set; }

        [Display(Name = "BOMProductId")]
        public Guid ProductId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.StringLength64)]
        [Display(Name = "BOMVersion")]
        public string Version { get; set; }

        [Display(Name = "BOMMaterialId")]
        public Guid MaterialId { get; set; }

        [Display(Name = "BOMCount")]
        public int Count { get; set; }

        [Display(Name = "BOMIsEnabled")]
        public bool IsEnabled { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "BOMRemark")]
        public string Remark { get; set; }
    }
}