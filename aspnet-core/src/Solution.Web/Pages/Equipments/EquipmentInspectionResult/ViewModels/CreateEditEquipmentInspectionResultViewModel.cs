using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentInspectionResult.ViewModels
{
    public class CreateEditEquipmentInspectionResultViewModel
    {
        [Display(Name = "EquipmentInspectionResultName")]
        public string Name { get; set; }

        [Display(Name = "EquipmentInspectionResultRemark")]
        public string Remark { get; set; }
    }
}