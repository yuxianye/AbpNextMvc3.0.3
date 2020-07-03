using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Warehouses.WarehouseArea.ViewModels
{
    public class CreateEditWarehouseAreaViewModel
    {
        [Display(Name = "WarehouseAreaWarehouseId")]
        public Guid WarehouseId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "WarehouseAreaName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "WarehouseAreaRemark")]
        public string Remark { get; set; }
    }
}