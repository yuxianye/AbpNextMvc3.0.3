using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Equipments
{
    /// <summary>
    /// 设备备件
    /// </summary>
    public class EquipmentSparePart : AuditedAggregateRoot<Guid>
    {

        /// <summary>
        /// 设备备件类别Id
        /// </summary>
        public Guid? EquipmentSparePartTypeId { get; set; }

        /// <summary>
        /// 设备备件名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }



        protected EquipmentSparePart()
        {
        }

        public EquipmentSparePart(
            Guid id,
            Guid? equipmentSparePartTypeId,
            string name,
            string remark
        ) :base(id)
        {
            EquipmentSparePartTypeId = equipmentSparePartTypeId;
            Name = name;
            Remark = remark;
        }
    }
}
