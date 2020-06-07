using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Qualities.QualityProblemLib.ViewModels
{
    public class CreateEditQualityProblemLibViewModel
    {
        [Display(Name = "QualityProblemLibCode")]
        public string Code { get; set; }

        [Display(Name = "QualityProblemLibName")]
        public string Name { get; set; }

        [Display(Name = "QualityProblemLibRemark")]
        public string Remark { get; set; }
    }
}