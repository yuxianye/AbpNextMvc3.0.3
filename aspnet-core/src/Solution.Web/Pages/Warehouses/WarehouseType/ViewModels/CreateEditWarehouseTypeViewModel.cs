using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Warehouses.WarehouseType.ViewModels
{
    public class CreateEditWarehouseTypeViewModel
    {
        [Required]
        [Display(Name = "WarehouseTypeName")]
        public string Name { get; set; }

        [Display(Name = "WarehouseTypeRemark")]
        public string Remark { get; set; }
    }
}