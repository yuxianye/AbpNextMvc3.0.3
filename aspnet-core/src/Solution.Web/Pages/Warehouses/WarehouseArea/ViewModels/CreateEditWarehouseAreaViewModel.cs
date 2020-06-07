using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Warehouses.WarehouseArea.ViewModels
{
    public class CreateEditWarehouseAreaViewModel
    {
        [Display(Name = "WarehouseAreaWarehouseId")]
        public Guid WarehouseId { get; set; }

        [Display(Name = "WarehouseAreaName")]
        public string Name { get; set; }

        [Display(Name = "WarehouseAreaRemark")]
        public string Remark { get; set; }
    }
}