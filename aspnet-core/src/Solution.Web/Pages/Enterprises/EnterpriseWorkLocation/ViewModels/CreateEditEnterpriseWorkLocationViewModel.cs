using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Enterprises.EnterpriseWorkLocation.ViewModels
{
    public class CreateEditEnterpriseWorkLocationViewModel
    {
        [Display(Name = "EnterpriseWorkLocationEnterpriseWorkCenterId")]
        public Guid EnterpriseWorkCenterId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EnterpriseWorkLocationName")]
        public string Name { get; set; }

        [Display(Name = "EnterpriseWorkLocationEquipmentId")]
        public Guid EquipmentId { get; set; }

        [Display(Name = "EnterpriseWorkLocationProcessId")]
        public Guid ProcessId { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EnterpriseWorkLocationRemark")]
        public string Remark { get; set; }
    }
}