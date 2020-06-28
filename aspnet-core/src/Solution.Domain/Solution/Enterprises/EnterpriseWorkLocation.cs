using Solution.Equipments;
using Solution.ProcessRoutes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Enterprises
{
    /// <summary>
    /// 工位
    /// </summary>
    public class EnterpriseWorkLocation : FullAuditedEntity<Guid>
    {

        /// <summary>
        /// 所属工作中心
        /// </summary>
        public Guid EnterpriseWorkCenterId { get; set; }

        /// <summary>
        /// 所属工作中心
        /// </summary>
        [ForeignKey(nameof(EnterpriseWorkCenterId))]
        public virtual EnterpriseWorkCenter EnterpriseWorkCenter { get; set; }

        /// <summary>
        /// 工位名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        public Guid EquipmentId { get; set; }

        /// <summary>
        /// 设备
        /// </summary>
        [ForeignKey(nameof(EquipmentId))]
        public virtual Equipment Equipment { get; set; }

        /// <summary>
        /// 工序编号
        /// </summary>
        public Guid ProcessId { get; set; }

        /// <summary>
        /// 设备
        /// </summary>
        [ForeignKey(nameof(ProcessId))]
        public virtual Process Process { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected EnterpriseWorkLocation()
        {
        }

        public EnterpriseWorkLocation(Guid id, Guid enterpriseWorkCenterId, string name, Guid equipmentId, Guid processId, string remark) : base(id)
        {
            EnterpriseWorkCenterId = enterpriseWorkCenterId;
            Name = name;
            EquipmentId = equipmentId;
            ProcessId = processId;
            Remark = remark;
        }
    }
}
