using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentType.ViewModels
{
    public class CreateEditEquipmentTypeViewModel
    {
        [Display(Name = "EquipmentTypeName")]
        public string Name { get; set; }

        [Display(Name = "EquipmentTypeRemark")]
        public string Remark { get; set; }
    }
}