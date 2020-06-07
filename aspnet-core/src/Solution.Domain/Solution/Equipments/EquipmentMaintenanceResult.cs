using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Equipments
{
    /// <summary>
    /// 设备维修结果实体
    /// </summary>
    public class EquipmentMaintenanceResult : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected EquipmentMaintenanceResult()
        {
        }

        public EquipmentMaintenanceResult(
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
