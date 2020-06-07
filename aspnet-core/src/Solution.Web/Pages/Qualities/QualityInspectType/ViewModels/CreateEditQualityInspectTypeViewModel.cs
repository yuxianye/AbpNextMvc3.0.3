using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Qualities.QualityInspectType.ViewModels
{
    public class CreateEditQualityInspectTypeViewModel
    {
        [Display(Name = "QualityInspectTypeCode")]
        public string Code { get; set; }

        [Display(Name = "QualityInspectTypeName")]
        public string Name { get; set; }

        [Display(Name = "QualityInspectTypeRemark")]
        public string Remark { get; set; }
    }
}