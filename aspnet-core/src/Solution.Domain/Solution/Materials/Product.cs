using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Materials
{
    /// <summary>
    /// 产品
    /// </summary>
    public class Product : AuditedEntity<Guid>
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品类型编号
        /// </summary>
        public Guid ProductTypeId { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public Guid UnitId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected Product()
        {
        }

        public Product(Guid id, string code, string name, Guid productTypeId, string specification, Guid unitId, string remark) : base(id)
        {
            Code = code;
            Name = name;
            ProductTypeId = productTypeId;
            Specification = specification;
            UnitId = unitId;
            Remark = remark;
        }
    }
}
