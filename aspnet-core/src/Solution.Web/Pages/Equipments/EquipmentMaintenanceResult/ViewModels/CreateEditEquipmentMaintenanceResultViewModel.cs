using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentMaintenanceResult.ViewModels
{
    public class CreateEditEquipmentMaintenanceResultViewModel
    {
        [Display(Name = "EquipmentMaintenanceResultName")]
        public string Name { get; set; }

        [Display(Name = "EquipmentMaintenanceResultRemark")]
        public string Remark { get; set; }
    }
}