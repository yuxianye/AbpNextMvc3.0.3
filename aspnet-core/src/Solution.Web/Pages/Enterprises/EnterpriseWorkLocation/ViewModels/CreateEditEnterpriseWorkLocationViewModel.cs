using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Enterprises.EnterpriseWorkLocation.ViewModels
{
    public class CreateEditEnterpriseWorkLocationViewModel
    {
        [Display(Name = "EnterpriseWorkLocationEnterpriseWorkCenterId")]
        public Guid EnterpriseWorkCenterId { get; set; }

        [Display(Name = "EnterpriseWorkLocationName")]
        public string Name { get; set; }

        [Display(Name = "EnterpriseWorkLocationEquipmentId")]
        public Guid EquipmentId { get; set; }

        [Display(Name = "EnterpriseWorkLocationProcessId")]
        public Guid ProcessId { get; set; }

        [Display(Name = "EnterpriseWorkLocationRemark")]
        public string Remark { get; set; }
    }
}