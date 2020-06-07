using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Materials
{
    /// <summary>
    /// 产品类型
    /// </summary>
    public class ProductType : AuditedEntity<Guid>
    {
        /// <summary>
        /// 产品类型名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected ProductType()
        {
        }

        public ProductType(Guid id, string name, string remark) : base(id)
        {
            Name = name;
            Remark = remark;
        }
    }
}
