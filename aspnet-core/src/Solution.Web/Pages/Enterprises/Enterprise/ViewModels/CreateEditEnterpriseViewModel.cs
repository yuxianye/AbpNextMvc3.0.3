using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Enterprises.Enterprise.ViewModels
{
    public class CreateEditEnterpriseViewModel
    {
        [Display(Name = "EnterpriseName")]
        public string Name { get; set; }

        [Display(Name = "EnterpriseAddress")]
        public string Address { get; set; }

        [Display(Name = "EnterprisePhone")]
        public string Phone { get; set; }

        [Display(Name = "EnterpriseRemark")]
        public string Remark { get; set; }
    }
}