using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Public
{
    /// <summary>
    /// 计量单位
    /// </summary>
    public class Unit : AuditedEntity<Guid>
    {

        /// <summary>
        /// 工序名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected Unit()
        {
        }

        public Unit(Guid id, string name, string remark) : base(id)
        {
            Name = name;
            Remark = remark;
        }
    }
}
