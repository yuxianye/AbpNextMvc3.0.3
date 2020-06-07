using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Enterprises.EnterpriseWorkCenter.ViewModels
{
    public class CreateEditEnterpriseWorkCenterViewModel
    {
        [Display(Name = "EnterpriseWorkCenterEnterpriseProductionLineId")]
        public Guid EnterpriseProductionLineId { get; set; }

        [Display(Name = "EnterpriseWorkCenterName")]
        public string Name { get; set; }

        [Display(Name = "EnterpriseWorkCenterManager")]
        public string Manager { get; set; }

        [Display(Name = "EnterpriseWorkCenterRemark")]
        public string Remark { get; set; }
    }
}