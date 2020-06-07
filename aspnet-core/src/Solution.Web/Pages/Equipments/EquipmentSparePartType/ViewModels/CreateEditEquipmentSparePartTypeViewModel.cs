using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentSparePartType.ViewModels
{
    public class CreateEditEquipmentSparePartTypeViewModel
    {
        [Display(Name = "EquipmentSparePartTypeName")]
        public string Name { get; set; }

        [Display(Name = "EquipmentSparePartTypeRemark")]
        public string Remark { get; set; }
    }
}