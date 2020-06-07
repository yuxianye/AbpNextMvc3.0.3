using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Equipments
{
    /// <summary>
    /// 设备巡检实体
    /// </summary>
    public class EquipmentInspection : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 设备Id
        /// </summary>
        public Guid EquipmentId { get; set; }

        /// <summary>
        /// 检查人
        /// </summary>
        public string InspectPerson { get; set; }

        /// <summary>
        /// 巡检时间
        /// </summary>
        public DateTime InspectionTime { get; set; }

        /// <summary>
        /// 巡检结果
        /// </summary>
        public Guid EquipmentInspectionResultId { get; set; }

        /// <summary>
        /// 设备存在问题
        /// </summary>
        public string Problem { get; set; }

        /// <summary>
        /// 设备存在问题的原因
        /// </summary>
        public string Cause { get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        public string Solution { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected EquipmentInspection()
        {
        }

        public EquipmentInspection(
            Guid id,
            Guid equipmentId,
            DateTime inspectionTime,
            Guid equipmentInspectionResultId,
            string problem,
            string cause,
            string solution,
            string remark
        ) :base(id)
        {
            EquipmentId = equipmentId;
            InspectionTime = inspectionTime;
            EquipmentInspectionResultId = equipmentInspectionResultId;
            Problem = problem;
            Cause = cause;
            Solution = solution;
            Remark = remark;
        }

        public EquipmentInspection(Guid id, Guid equipmentId, string inspectPerson, DateTime inspectionTime, Guid equipmentInspectionResultId, string problem, string cause, string solution, string remark) : base(id)
        {
            EquipmentId = equipmentId;
            InspectPerson = inspectPerson;
            InspectionTime = inspectionTime;
            EquipmentInspectionResultId = equipmentInspectionResultId;
            Problem = problem;
            Cause = cause;
            Solution = solution;
            Remark = remark;
        }
    }




}
