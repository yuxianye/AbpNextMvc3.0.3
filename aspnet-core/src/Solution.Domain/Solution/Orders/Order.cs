using System;
using System.Collections.Generic;
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
        /// 产品编号
        /// </summary>
        public Guid ProductId { get;  set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get;  set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public Guid OrderStatusID { get;  set; }
        
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

    }

}
