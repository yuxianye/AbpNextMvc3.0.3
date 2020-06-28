using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Enterprises.EnterpriseProductionLine.ViewModels
{
    public class CreateEditEnterpriseProductionLineViewModel
    {
        [Display(Name = "EnterpriseProductionLineEnterpriseAreaId")]
        public Guid EnterpriseAreaId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EnterpriseProductionLineName")]
        public string Name { get; set; }

        [Display(Name = "EnterpriseProductionLineManager")]
        [StringLength(MySolutionConsts.NameLength)]
        public string Manager { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        [Display(Name = "EnterpriseProductionLinePhone")]
        public string Phone { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EnterpriseProductionLineRemark")]
        public string Remark { get; set; }
    }
}