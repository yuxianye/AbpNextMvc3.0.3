using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Orders.Order.ViewModels
{
    public class CreateEditOrderViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        [Display(Name = "OrderCode")]
        public int Code { get; set; }

        [Display(Name = "OrderCustomerId")]
        public Guid CustomerId { get; set; }

        [Display(Name = "OrderProductId")]
        public Guid ProductId { get; set; }

        [Display(Name = "OrderCount")]
        public int Count { get; set; }

        [Display(Name = "OrderOrderStatusID")]
        public Guid OrderStatusID { get; set; }

        [Display(Name = "OrderOrderDate")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "OrderDeliveryDate")]
        public DateTime DeliveryDate { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "OrderRemark")]
        public string Remark { get; set; }
    }
}