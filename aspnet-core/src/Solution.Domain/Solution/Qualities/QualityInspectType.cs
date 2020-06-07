using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Qualities
{
    /// <summary>
    /// 质量检验类型
    /// </summary>
    public class QualityInspectType : AuditedEntity<Guid>
    {
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 工序名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected QualityInspectType()
        {
        }

        public QualityInspectType(Guid id, string code, string name, string remark) : base(id)
        {
            Code = code;
            Name = name;
            Remark = remark;
        }
    }
}
