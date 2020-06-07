using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Warehouses
{
    /// <summary>
    /// 仓库类型
    /// </summary>
    public class WarehouseType : AuditedEntity<Guid>
    {

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summ
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected WarehouseType()
        {
        }

        public WarehouseType(Guid id, string name, string remark) : base(id)
        {
            Name = name;
            Remark = remark;
        }
    }
}
