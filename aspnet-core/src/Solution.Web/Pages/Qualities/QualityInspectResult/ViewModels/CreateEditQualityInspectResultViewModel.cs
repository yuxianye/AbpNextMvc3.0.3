using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Qualities.QualityInspectResult.ViewModels
{
    public class CreateEditQualityInspectResultViewModel
    {
        [Display(Name = "QualityInspectResultName")]
        public string Name { get; set; }

        [Display(Name = "QualityInspectResultRemark")]
        public string Remark { get; set; }
    }
}