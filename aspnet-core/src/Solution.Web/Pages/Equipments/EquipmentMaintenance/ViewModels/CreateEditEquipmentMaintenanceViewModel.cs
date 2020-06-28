using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentMaintenance.ViewModels
{
    public class CreateEditEquipmentMaintenanceViewModel
    {
        [Display(Name = "EquipmentMaintenanceEquipmentId")]
        public Guid EquipmentId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.StringLength256)]
        [Display(Name = "EquipmentMaintenanceProblem")]
        public string Problem { get; set; }

        [Required]
        [StringLength(MySolutionConsts.StringLength256)]
        [Display(Name = "EquipmentMaintenanceCause")]
        public string Cause { get; set; }

        [Required]
        [StringLength(MySolutionConsts.StringLength256)]
        [Display(Name = "EquipmentMaintenanceSolution")]
        public string Solution { get; set; }

        [Display(Name = "EquipmentMaintenanceActualStartTime")]
        public DateTime ActualStartTime { get; set; }

        [Display(Name = "EquipmentMaintenanceActualFinishTime")]
        public DateTime ActualFinishTime { get; set; }

        [Required]
        [StringLength(MySolutionConsts.StringLength256)]
        [Display(Name = "EquipmentMaintenanceConsumable")]
        public string Consumable { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EquipmentMaintenanceResponsiblePerson")]
        public string ResponsiblePerson { get; set; }

        [Display(Name = "EquipmentMaintenanceMaintenanceTime")]
        public DateTime MaintenanceTime { get; set; }

        [Display(Name = "EquipmentMaintenanceEquipmentMaintenanceResultId")]
        public Guid EquipmentMaintenanceResultId { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EquipmentMaintenanceRemark")]
        public string Remark { get; set; }
    }
}