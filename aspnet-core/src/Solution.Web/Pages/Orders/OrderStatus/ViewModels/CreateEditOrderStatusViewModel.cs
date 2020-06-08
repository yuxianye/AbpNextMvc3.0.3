using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Orders.OrderStatus.ViewModels
{
    public class CreateEditOrderStatusViewModel
    {
        [Display(Name = "OrderStatusName")]
        public string Name { get; set; }

        [Display(Name = "OrderStatusRemark")]
        public string Remark { get; set; }
    }
}