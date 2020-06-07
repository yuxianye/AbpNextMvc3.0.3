using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Enterprises.EnterpriseProductionLine.ViewModels
{
    public class CreateEditEnterpriseProductionLineViewModel
    {
        [Display(Name = "EnterpriseProductionLineEnterpriseAreaId")]
        public Guid EnterpriseAreaId { get; set; }

        [Display(Name = "EnterpriseProductionLineName")]
        public string Name { get; set; }

        [Display(Name = "EnterpriseProductionLineManager")]
        public string Manager { get; set; }

        [Display(Name = "EnterpriseProductionLinePhone")]
        public string Phone { get; set; }

        [Display(Name = "EnterpriseProductionLineRemark")]
        public string Remark { get; set; }
    }
}