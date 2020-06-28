using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentSparePartType.ViewModels
{
    public class CreateEditEquipmentSparePartTypeViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EquipmentSparePartTypeName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EquipmentSparePartTypeRemark")]
        public string Remark { get; set; }
    }
}