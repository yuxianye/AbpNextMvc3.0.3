using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Enterprises.Enterprise.ViewModels
{
    public class CreateEditEnterpriseViewModel
    {
        [Required]
        [MaxLength(MySolutionConsts.NameLength)]
        [Display(Name = "EnterpriseName")]
        public string Name { get; set; }

        [Display(Name = "EnterpriseAddress")]
        [MaxLength(MySolutionConsts.AddressLength)]
        public string Address { get; set; }

        [StringLength(MySolutionConsts.PhoneLength)]
        [Display(Name = "EnterprisePhone")]
        public string Phone { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EnterpriseRemark")]
        public string Remark { get; set; }
    }
}