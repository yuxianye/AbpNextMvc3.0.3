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
    /// 订单状态
    /// </summary>
    public class OrderStatus : AuditedEntity<Guid>
    {

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; protected set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }



        protected OrderStatus()
        {
        }

        public OrderStatus(Guid id, string name, string remark) : base(id)
        {
            Name = name;
            Remark = remark;
        }
    }

}
