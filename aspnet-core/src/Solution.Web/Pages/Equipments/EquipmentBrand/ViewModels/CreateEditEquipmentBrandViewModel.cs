using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentBrand.ViewModels
{
    public class CreateEditEquipmentBrandViewModel
    {
        [Display(Name = "EquipmentBrandName")]
        public string Name { get; set; }

        [Display(Name = "EquipmentBrandRemark")]
        public string Remark { get; set; }
    }
}