using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentBrand.ViewModels
{
    public class CreateEditEquipmentBrandViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EquipmentBrandName")]
        public string Name { get; set; }
      
        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EquipmentBrandRemark")]
        public string Remark { get; set; }
    }
}