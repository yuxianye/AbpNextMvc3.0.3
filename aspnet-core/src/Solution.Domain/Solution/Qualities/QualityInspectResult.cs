using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Qualities
{
    /// <summary>
    /// 质量检查结果
    /// </summary>
    public class QualityInspectResult : AuditedEntity<Guid>
    {

        /// <summary>
        /// 结果名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected QualityInspectResult()
        {
        }

        public QualityInspectResult(Guid id, string name, string remark) : base(id)
        {
            Name = name;
            Remark = remark;
        }
    }
}
