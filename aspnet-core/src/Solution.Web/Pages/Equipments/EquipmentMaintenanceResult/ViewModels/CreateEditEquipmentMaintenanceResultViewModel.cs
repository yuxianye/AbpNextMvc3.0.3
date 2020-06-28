using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentMaintenanceResult.ViewModels
{
    public class CreateEditEquipmentMaintenanceResultViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EquipmentMaintenanceResultName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EquipmentMaintenanceResultRemark")]
        public string Remark { get; set; }
    }
}