using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Enterprises.EnterpriseSite.ViewModels
{
    public class CreateEditEnterpriseSiteViewModel
    {
        [Display(Name = "EnterpriseSiteEnterpriseId")]
        public Guid EnterpriseId { get; set; }

        [Display(Name = "EnterpriseSiteName")]
        public string Name { get; set; }

        [Display(Name = "EnterpriseSiteAddress")]
        public string Address { get; set; }

        [Display(Name = "EnterpriseSiteManager")]
        public string Manager { get; set; }

        [Display(Name = "EnterpriseSitePhone")]
        public string Phone { get; set; }

        [Display(Name = "EnterpriseSiteRemark")]
        public string Remark { get; set; }
    }
}