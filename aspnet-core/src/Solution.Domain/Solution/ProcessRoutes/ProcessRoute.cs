using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.ProcessRoutes
{
    /// <summary>
    /// 工艺路线
    /// </summary>
    public class ProcessRoute : AuditedEntity<Guid>
    {

        /// <summary>
        /// 产品编号
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// 工艺路线编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 工艺路线名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
