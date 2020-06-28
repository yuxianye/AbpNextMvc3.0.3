using Solution.Customers;
using Solution.Materials;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Solution.Orders
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Order : AuditedEntity<Guid>
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public int Code { get;  set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        public Guid CustomerId { get;  set; }

        /// <summary>
        /// 单位
        /// </summary>
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public Guid ProductId { get;  set; }

        /// <summary>
        /// 产品
        /// </summary>
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get;  set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public Guid OrderStatusId { get;  set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [ForeignKey(nameof(OrderStatusId))]
        public virtual OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// 订货货日期
        /// </summary>
        public DateTime OrderDate  { get;  set; }

        /// <summary>
        /// 交货日期
        /// </summary>
        public DateTime DeliveryDate { get;  set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected Order()
        {
        }

        public Order(Guid id, int code, Guid customerId, Guid productId, int count, Guid orderStatusId, DateTime orderDate, DateTime deliveryDate, string remark) : base(id)
        {
            Code = code;
            CustomerId = customerId;
            ProductId = productId;
            Count = count;
            OrderStatusId = orderStatusId;
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
            Remark = remark;
        }
    }

}
