using Solution.ProcessRoutes;
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
        /// 编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 质检人
        /// </summary>
        public string InspectPerson { get; set; }

        /// <summary>
        /// 检查类型编号
        /// </summary>
        public Guid QualityInspectTypeId { get; set; }

        /// <summary>
        /// 检查类型
        /// </summary>
        [ForeignKey(nameof(QualityInspectTypeId))]
        public virtual QualityInspectType QualityInspectType { get; set; }

        /// <summary>
        /// 检查时间
        /// </summary>
        public DateTime InspectTime { get; set; }

        /// <summary>
        /// 工序编号
        /// </summary>
        public Guid ProcessId { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        [ForeignKey(nameof(ProcessId))]
        public virtual Process Process { get; set; }

        /// <summary>
        /// 质量问题编号
        /// </summary>
        public Guid QualityProblemLibId { get; set; }

        /// <summary>
        /// 质量问题
        /// </summary>
        [ForeignKey(nameof(QualityProblemLibId))]
        public virtual QualityProblemLib QualityProblemLib { get; set; }

        /// <summary>
        /// 质量检查结果编号
        /// </summary>
        public Guid QualityInspectResultId { get; set; }

        /// <summary>
        /// 质量检查结果
        /// </summary>
        [ForeignKey(nameof(QualityInspectResultId))]
        public virtual QualityInspectResult QualityInspectResult { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected QualityInspect()
        {
        }

        public QualityInspect(Guid id, string code, string inspectPerson, Guid qualityInspectTypeId, DateTime inspectTime, Guid qualityProblemLibId, Guid qualityInspectResultId, string remark) : base(id)
        {
            Code = code;
            InspectPerson = inspectPerson;
            QualityInspectTypeId = qualityInspectTypeId;
            InspectTime = inspectTime;
            QualityProblemLibId = qualityProblemLibId;
            QualityInspectResultId = qualityInspectResultId;
            Remark = remark;
        }
    }
}
