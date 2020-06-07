using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.ProcessRoutes
{
    /// <summary>
    /// 工艺路线明细-物料
    /// </summary>
    public class ProcessRouteItemMaterial : AuditedEntity<Guid>
    {

        /// <summary>
        /// 工艺路线明细编号
        /// </summary>
        public Guid ProcessRouteItemId { get; set; }

        /// <summary>
        /// 物料编号
        /// </summary>
        public Guid MaterialId { get; set; }

        /// <summary>
        /// 计量单位编号
        /// </summary>
        public Guid UnitId { get; set; }

        /// <summary>
        /// 标准用量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
