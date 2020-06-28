using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Warehouses
{
    /// <summary>
    /// 库位
    /// </summary>
    public class WarehouseLocation : FullAuditedEntity<Guid>
    {

        /// <summary>
        /// 库区编号
        /// </summary>
        public Guid WarehouseAreaId { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [ForeignKey(nameof(WarehouseAreaId))]
        public virtual WarehouseArea WarehouseArea { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected WarehouseLocation()
        {
        }

        public WarehouseLocation(Guid id, Guid warehouseAreaId, string code, string name, string remark) : base(id)
        {
            WarehouseAreaId = warehouseAreaId;
            Code = code;
            Name = name;
            Remark = remark;
        }
    }
}
