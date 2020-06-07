using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Qualities
{
    /// <summary>
    /// 质量问题库
    /// </summary>
    public class QualityProblemLib : AuditedEntity<Guid>
    {

        /// <summary>
        /// 问题编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 问题名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected QualityProblemLib()
        {
        }

        public QualityProblemLib(Guid id, string code, string name, string remark) : base(id)
        {
            Code = code;
            Name = name;
            Remark = remark;
        }
    }
}
