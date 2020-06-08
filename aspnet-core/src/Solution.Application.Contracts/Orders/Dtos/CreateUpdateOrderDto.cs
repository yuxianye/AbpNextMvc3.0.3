using System;
using System.ComponentModel;
namespace Solution.Orders.Dtos
{
    public class CreateUpdateOrderDto
    {
        public int Code { get; set; }

        public Guid CustomerId { get; set; }

        public Guid ProductId { get; set; }

        public int Count { get; set; }

        public Guid OrderStatusID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string Remark { get; set; }
    }
}