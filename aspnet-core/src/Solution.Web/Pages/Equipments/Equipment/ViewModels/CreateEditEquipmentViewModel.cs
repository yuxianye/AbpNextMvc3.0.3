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

        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        [Display(Name = "EquipmentCode")]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EquipmentName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.StringLength64)]
        [Display(Name = "EquipmentSpecification")]
        public string Specification { get; set; }

        [Display(Name = "EquipmentManufactureDate")]
        public DateTime ManufactureDate { get; set; }

        [Display(Name = "EquipmentEquipmentStatusId")]
        public Guid EquipmentStatusId { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EquipmentRemark")]
        public string Remark { get; set; }
    }
}