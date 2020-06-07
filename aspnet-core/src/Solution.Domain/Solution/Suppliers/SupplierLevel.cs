using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Suppliers
{
    /// <summary>
    /// 供应商等级
    /// </summary>
    public class SupplierLevel : AuditedEntity<Guid>
    {

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected SupplierLevel()
        {
        }

        public SupplierLevel(Guid id, string name, string remark) : base(id)
        {
            Name = name;
            Remark = remark;
        }
    }
}
