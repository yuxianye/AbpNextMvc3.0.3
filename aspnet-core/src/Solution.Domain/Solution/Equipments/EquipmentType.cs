using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Equipments
{
    /// <summary>
    /// 设备类别
    /// </summary>
    public class EquipmentType : AuditedEntity<Guid>
    {
        /// <summary>
        /// 设备类别名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        protected EquipmentType()
        {
        }

        public EquipmentType(
            Guid id,
            string name,
            string remark
        ) : base(id)
        {
            Name = name;
            Remark = remark;
        }
    }
}
