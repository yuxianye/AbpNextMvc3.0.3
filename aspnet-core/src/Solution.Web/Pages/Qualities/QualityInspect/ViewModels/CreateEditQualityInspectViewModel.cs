using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Qualities.QualityInspect.ViewModels
{
    public class CreateEditQualityInspectViewModel
    {
        [Display(Name = "QualityInspectInspectPerson")]
        public string InspectPerson { get; set; }

        [Display(Name = "QualityInspectQualityInspectTypeId")]
        public Guid QualityInspectTypeId { get; set; }

        [Display(Name = "QualityInspectInspectTime")]
        public DateTime InspectTime { get; set; }

        [Display(Name = "QualityInspectName")]
        public string Name { get; set; }

        [Display(Name = "QualityInspectQualityProblemLibId")]
        public Guid QualityProblemLibId { get; set; }

        [Display(Name = "QualityInspectQualityInspectResultId")]
        public Guid QualityInspectResultId { get; set; }

        [Display(Name = "QualityInspectRemark")]
        public string Remark { get; set; }
    }
}