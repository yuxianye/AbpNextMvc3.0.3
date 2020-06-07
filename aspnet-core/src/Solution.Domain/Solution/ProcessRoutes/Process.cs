using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.ProcessRoutes
{
    /// <summary>
    /// 工序模板
    /// </summary>
    public class Process : AuditedEntity<Guid>
    {

        /// <summary>
        /// 工序编码
        /// </summary>
        public string Code { get; set; }


        /// <summary>
        /// 工序名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 控制码，开报工，上线，下线，普通
        /// </summary>
        public Guid ControlCode { get; set; }

        /// <summary>
        /// 检验类型，免检，自检，成品检
        /// </summary>
        public Guid CheckTypeId { get; set; }

        /// <summary>
        /// 是否自动转移
        /// </summary>
        public bool IsAutotransfer { get; set; }

        /// <summary>
        /// 准备时间
        /// </summary>
        public int PrepareTime { get; set; }

        /// <summary>
        /// 制造时间
        /// </summary>
        public int ManufactureTime { get; set; }

        /// <summary>
        /// 上下料时间
        /// </summary>
        public int UnloadingTime { get; set; }

        /// <summary>
        /// 排队时间
        /// </summary>
        public int QueueTime { get; set; }

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
