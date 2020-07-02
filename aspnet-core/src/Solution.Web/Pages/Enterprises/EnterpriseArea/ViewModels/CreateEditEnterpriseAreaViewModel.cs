using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Solution.Web.Pages.Enterprises.EnterpriseArea.ViewModels
{
    public class CreateEditEnterpriseAreaViewModel
    {
        [Display(Name = "EnterpriseAreaEnterpriseSiteId")]
        [SelectItems("EnterpriseSiteList")]
        public Guid EnterpriseSiteId { get; set; }
      
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EnterpriseAreaName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EnterpriseAreaManager")]
        public string Manager { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        [Display(Name = "EnterpriseAreaPhone")]
        public string Phone { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EnterpriseAreaRemark")]
        public string Remark { get; set; }
    }
}