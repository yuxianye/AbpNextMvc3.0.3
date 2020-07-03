using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Warehouses.WarehouseLocation.ViewModels
{
    public class CreateEditWarehouseLocationViewModel
    {
        [Display(Name = "WarehouseLocationWareHouseAreaId")]
        public Guid WareHouseAreaId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        [Display(Name = "WarehouseLocationCode")]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "WarehouseLocationName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "WarehouseLocationRemark")]
        public string Remark { get; set; }
    }
}