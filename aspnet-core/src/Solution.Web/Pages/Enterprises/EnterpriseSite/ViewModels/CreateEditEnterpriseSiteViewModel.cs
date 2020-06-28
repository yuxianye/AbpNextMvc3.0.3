using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Solution.Web.Pages.Enterprises.EnterpriseSite.ViewModels
{
    public class CreateEditEnterpriseSiteViewModel
    {
        [Display(Name = "EnterpriseSiteEnterpriseId")]
        [SelectItems("EnterpriseList")]
        public Guid EnterpriseId { get; set; }

        [HiddenInput]
        [Display(Name = "EnterpriseSiteEnterpriseId")]
        public string EnterpriseName { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EnterpriseSiteName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.AddressLength)]
        [Display(Name = "EnterpriseSiteAddress")]
        public string Address { get; set; }

        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EnterpriseSiteManager")]
        public string Manager { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        [Display(Name = "EnterpriseSitePhone")]
        public string Phone { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EnterpriseSiteRemark")]
        public string Remark { get; set; }
    }
}