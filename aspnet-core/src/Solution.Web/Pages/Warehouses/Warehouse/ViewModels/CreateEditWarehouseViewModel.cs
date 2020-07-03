using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Warehouses.Warehouse.ViewModels
{
    public class CreateEditWarehouseViewModel
    {
        [Display(Name = "WarehouseEnterpriseAreaId")]
        public Guid EnterpriseAreaId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "WarehouseName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "WarehouseManager")]
        public string Manager { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        [Display(Name = "WarehousePhone")]
        public string Phone { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "WarehouseRemark")]
        public string Remark { get; set; }
    }
}