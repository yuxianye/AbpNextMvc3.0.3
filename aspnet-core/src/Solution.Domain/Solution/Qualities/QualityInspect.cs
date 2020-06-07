using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Qualities
{
    /// <summary>
    /// 质量检查
    /// </summary>
    public class QualityInspect : AuditedEntity<Guid>
    {
        /// <summary>
        /// 质检人
        /// </summary>
        public string InspectPerson { get; set; }

        /// <summary>
        /// 检查类型编号
        /// </summary>
        public Guid QualityInspectTypeId { get; set; }

        /// <summary>
        /// 检查时间
        /// </summary>
        public DateTime InspectTime { get; set; }

        /// <summary>
        /// 工序名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 质量问题编号
        /// </summary>
        public Guid QualityProblemLibId { get; set; }

        /// <summary>
        /// 质量检查结果编号
        /// </summary>
        public Guid QualityInspectResultId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected QualityInspect()
        {
        }

        public QualityInspect(Guid id, string inspectPerson, Guid qualityInspectTypeId, DateTime inspectTime, string name, Guid qualityProblemLibId, Guid qualityInspectResultId, string remark) : base(id)
        {
            InspectPerson = inspectPerson;
            QualityInspectTypeId = qualityInspectTypeId;
            InspectTime = inspectTime;
            Name = name;
            QualityProblemLibId = qualityProblemLibId;
            QualityInspectResultId = qualityInspectResultId;
            Remark = remark;
        }
    }
}
