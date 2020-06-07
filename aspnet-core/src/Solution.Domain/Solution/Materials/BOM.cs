using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Materials
{
    /// <summary>
    /// 物料清单
    /// </summary>
    public class BOM : AuditedEntity<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// BOM版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 物料编号
        /// </summary>
        public Guid MaterialId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        public override object[] GetKeys()
        {
            return new Object[] { ProductId, MaterialId,Version };
        }


        protected BOM()
        {
        }

        public BOM(Guid id, string name, Guid productId, string version, Guid materialId, int count, bool isEnabled, string remark) : base(id)
        {
            Name = name;
            ProductId = productId;
            Version = version;
            MaterialId = materialId;
            Count = count;
            IsEnabled = isEnabled;
            Remark = remark;
        }
    }
}
