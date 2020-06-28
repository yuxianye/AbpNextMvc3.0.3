using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Warehouses.WarehouseLocation.ViewModels
{
    public class CreateEditWarehouseLocationViewModel
    {
        [Display(Name = "WarehouseLocationWareHouseAreaId")]
        public Guid WareHouseAreaId { get; set; }

        [Display(Name = "WarehouseLocationCode")]
        public string Code { get; set; }

        [Display(Name = "WarehouseLocationName")]
        public string Name { get; set; }

        [Display(Name = "WarehouseLocationRemark")]
        public string Remark { get; set; }
    }
}