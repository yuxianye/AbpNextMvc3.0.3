using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentSparePart.ViewModels
{
    public class CreateEditEquipmentSparePartViewModel
    {
        [Display(Name = "EquipmentSparePartEquipmentSparePartTypeId")]
        public Guid EquipmentSparePartTypeId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EquipmentSparePartName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EquipmentSparePartRemark")]
        public string Remark { get; set; }
    }
}