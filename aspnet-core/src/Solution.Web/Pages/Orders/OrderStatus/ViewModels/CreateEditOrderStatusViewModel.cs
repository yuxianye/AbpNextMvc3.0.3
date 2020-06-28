using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Orders.OrderStatus.ViewModels
{
    public class CreateEditOrderStatusViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "OrderStatusName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "OrderStatusRemark")]
        public string Remark { get; set; }
    }
}