using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Materials.BOM.ViewModels
{
    public class CreateEditBOMViewModel
    {
        [Display(Name = "BOMName")]
        public string Name { get; set; }

        [Display(Name = "BOMProductId")]
        public Guid ProductId { get; set; }

        [Display(Name = "BOMVersion")]
        public string Version { get; set; }

        [Display(Name = "BOMMaterialId")]
        public Guid MaterialId { get; set; }

        [Display(Name = "BOMCount")]
        public int Count { get; set; }

        [Display(Name = "BOMIsEnabled")]
        public bool IsEnabled { get; set; }

        [Display(Name = "BOMRemark")]
        public string Remark { get; set; }
    }
}