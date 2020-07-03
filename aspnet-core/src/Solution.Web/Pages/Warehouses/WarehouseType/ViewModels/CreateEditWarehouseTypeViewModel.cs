using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Warehouses.WarehouseType.ViewModels
{
    public class CreateEditWarehouseTypeViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "WarehouseTypeName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "WarehouseTypeRemark")]
        public string Remark { get; set; }
    }
}