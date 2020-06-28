using Solution.Enterprises;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.ProcessRoutes
{
    /// <summary>
    /// 工艺路线明细
    /// </summary>
    public class ProcessRouteItem : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 工艺路线编号
        /// </summary>
        public Guid ProcessRouteId { get; set; }

        /// <summary>
        /// 工艺路线
        /// </summary>
        [ForeignKey(nameof(ProcessRouteId))]
        public virtual ProcessRoute ProcessRoute { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 工序编号
        /// </summary>
        public Guid ProcessId { get; set; }

        /// <summary>
        /// 工序编号
        /// </summary>
        [ForeignKey(nameof(ProcessId))]
        public virtual Process Process { get; set; }

        /// <summary>
        /// 工作中心编号
        /// </summary>
        public Guid EnterpriseWorkCenterId { get; set; }

        /// <summary>
        /// 工作中心
        /// </summary>
        [ForeignKey(nameof(EnterpriseWorkCenterId))]
        public virtual EnterpriseWorkCenter EnterpriseWorkCenter { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
