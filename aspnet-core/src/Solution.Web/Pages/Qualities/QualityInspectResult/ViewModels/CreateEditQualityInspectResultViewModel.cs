using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Qualities.QualityInspectResult.ViewModels
{
    public class CreateEditQualityInspectResultViewModel
    {

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "QualityInspectResultName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "QualityInspectResultRemark")]
        public string Remark { get; set; }
    }
}