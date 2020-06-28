using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Enterprises.EnterpriseWorkCenter.ViewModels
{
    public class CreateEditEnterpriseWorkCenterViewModel
    {
        [Display(Name = "EnterpriseWorkCenterEnterpriseProductionLineId")]
        public Guid EnterpriseProductionLineId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EnterpriseWorkCenterName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EnterpriseWorkCenterManager")]
        public string Manager { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EnterpriseWorkCenterRemark")]
        public string Remark { get; set; }
    }
}