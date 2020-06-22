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
        [Display(Name = "EnterpriseAreaName")]
        public string Name { get; set; }

        [Display(Name = "EnterpriseAreaManager")]
        public string Manager { get; set; }

        [Display(Name = "EnterpriseAreaPhone")]
        public string Phone { get; set; }

        [Display(Name = "EnterpriseAreaRemark")]
        public string Remark { get; set; }
    }
}