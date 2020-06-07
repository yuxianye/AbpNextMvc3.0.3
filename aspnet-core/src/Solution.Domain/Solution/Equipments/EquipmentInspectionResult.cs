using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Equipments
{
    /// <summary>
    /// 设备巡检结果实体
    /// </summary>
    public class EquipmentInspectionResult : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected EquipmentInspectionResult()
        {
        }

        public EquipmentInspectionResult(
            Guid id,
            string name,
            string remark
        ) :base(id)
        {
            Name = name;
            Remark = remark;
        }
    }

}
