using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Qualities.QualityInspectType.ViewModels
{
    public class CreateEditQualityInspectTypeViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        [Display(Name = "QualityInspectTypeCode")]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "QualityInspectTypeName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "QualityInspectTypeRemark")]
        public string Remark { get; set; }
    }
}