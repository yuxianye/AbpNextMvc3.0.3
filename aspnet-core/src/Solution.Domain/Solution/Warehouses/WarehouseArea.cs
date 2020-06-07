using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Warehouses
{
    /// <summary>
    /// 仓库区域
    /// </summary>
    public class WarehouseArea : AuditedEntity<Guid>
    {

        /// <summary>
        /// 仓库编号
        /// </summary>
        public Guid WarehouseId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected WarehouseArea()
        {
        }

        public WarehouseArea(Guid id, Guid warehouseId, string name, string remark) : base(id)
        {
            WarehouseId = warehouseId;
            Name = name;
            Remark = remark;
        }
    }
}
