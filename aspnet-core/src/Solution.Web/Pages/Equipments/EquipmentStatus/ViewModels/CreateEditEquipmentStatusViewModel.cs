using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentStatus.ViewModels
{
    public class CreateEditEquipmentStatusViewModel
    {
        [Display(Name = "EquipmentStatusName")]
        public string Name { get; set; }

        [Display(Name = "EquipmentStatusRemark")]
        public string Remark { get; set; }
    }
}