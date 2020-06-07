using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.Equipment.ViewModels
{
    public class CreateEditEquipmentViewModel
    {
        [Display(Name = "EquipmentEquipmentTypeId")]
        public Guid EquipmentTypeId { get; set; }

        [Display(Name = "EquipmentEquipmentBrandId")]
        public Guid EquipmentBrandId { get; set; }

        [Display(Name = "EquipmentCode")]
        public string Code { get; set; }

        [Display(Name = "EquipmentName")]
        public string Name { get; set; }

        [Display(Name = "EquipmentSpecification")]
        public string Specification { get; set; }

        [Display(Name = "EquipmentManufactureDate")]
        public DateTime ManufactureDate { get; set; }

        [Display(Name = "EquipmentEquipmentStatusId")]
        public Guid? EquipmentStatusId { get; set; }

        [Display(Name = "EquipmentRemark")]
        public string Remark { get; set; }
    }
}