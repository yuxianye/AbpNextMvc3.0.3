using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Public.Unit.ViewModels
{
    public class CreateEditUnitViewModel
    {
        [Display(Name = "UnitName")]
        public string Name { get; set; }

        [Display(Name = "UnitRemark")]
        public string Remark { get; set; }
    }
}