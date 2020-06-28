using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Qualities.QualityInspect.ViewModels
{
    public class CreateEditQualityInspectViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        [Display(Name = "QualityInspectCode")]
        public string Code { get; set; }
    
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "QualityInspectInspectPerson")]
        public string InspectPerson { get; set; }

        [Display(Name = "QualityInspectQualityInspectTypeId")]
        public Guid QualityInspectTypeId { get; set; }

        [Display(Name = "QualityInspectInspectTime")]
        public DateTime InspectTime { get; set; }
      
        [Display(Name = "QualityInspectQualityProblemLibId")]
        public Guid QualityProblemLibId { get; set; }

        [Display(Name = "QualityInspectQualityInspectResultId")]
        public Guid QualityInspectResultId { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "QualityInspectRemark")]
        public string Remark { get; set; }
    }
}