using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentSparePart.ViewModels
{
    public class CreateEditEquipmentSparePartViewModel
    {
        [Display(Name = "EquipmentSparePartEquipmentSparePartTypeId")]
        public Guid? EquipmentSparePartTypeId { get; set; }

        [Display(Name = "EquipmentSparePartName")]
        public string Name { get; set; }

        [Display(Name = "EquipmentSparePartRemark")]
        public string Remark { get; set; }
    }
}