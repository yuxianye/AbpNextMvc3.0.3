using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentInspection.ViewModels
{
    public class CreateEditEquipmentInspectionViewModel
    {
        [Display(Name = "EquipmentInspectionEquipmentId")]
        public Guid EquipmentId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EquipmentInspectionInspectPerson")]
        public string InspectPerson { get; set; }

        [Display(Name = "EquipmentInspectionInspectionTime")]
        public DateTime InspectionTime { get; set; }

        [Display(Name = "EquipmentInspectionEquipmentInspectionResultId")]
        public Guid EquipmentInspectionResultId { get; set; }

        [StringLength(MySolutionConsts.StringLength256)]
        [Display(Name = "EquipmentInspectionProblem")]
        public string Problem { get; set; }

        [StringLength(MySolutionConsts.StringLength256)]
        [Display(Name = "EquipmentInspectionCause")]
        public string Cause { get; set; }

        [StringLength(MySolutionConsts.StringLength256)]
        [Display(Name = "EquipmentInspectionSolution")]
        public string Solution { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EquipmentInspectionRemark")]
        public string Remark { get; set; }
    }
}