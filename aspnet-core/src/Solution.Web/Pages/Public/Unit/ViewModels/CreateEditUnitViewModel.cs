using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Public.Unit.ViewModels
{
    public class CreateEditUnitViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "UnitName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "UnitRemark")]
        public string Remark { get; set; }
    }
}