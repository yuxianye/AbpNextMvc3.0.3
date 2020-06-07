using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Warehouses.WareHouseLocation.ViewModels
{
    public class CreateEditWareHouseLocationViewModel
    {
        [Display(Name = "WareHouseLocationWareHouseAreaId")]
        public Guid WareHouseAreaId { get; set; }

        [Display(Name = "WareHouseLocationCode")]
        public string Code { get; set; }

        [Display(Name = "WareHouseLocationName")]
        public string Name { get; set; }

        [Display(Name = "WareHouseLocationRemark")]
        public string Remark { get; set; }
    }
}