using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Warehouses.Warehouse.ViewModels
{
    public class CreateEditWarehouseViewModel
    {
        [Display(Name = "WarehouseEnterpriseAreaId")]
        public Guid EnterpriseAreaId { get; set; }

        [Display(Name = "WarehouseName")]
        public string Name { get; set; }

        [Display(Name = "WarehouseManager")]
        public string Manager { get; set; }

        [Display(Name = "WarehousePhone")]
        public string Phone { get; set; }

        [Display(Name = "WarehouseRemark")]
        public string Remark { get; set; }
    }
}