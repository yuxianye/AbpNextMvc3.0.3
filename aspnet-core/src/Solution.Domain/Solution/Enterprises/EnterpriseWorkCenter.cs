using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Enterprises
{
    /// <summary>
    /// 工作中心，操作中心
    /// </summary>
    public class EnterpriseWorkCenter : AuditedEntity<Guid>
    {

        /// <summary>
        /// 所属产线
        /// </summary>
        public Guid EnterpriseProductionLineId { get; set; }

        /// <summary>
        /// 工作中心名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 工作中心负责人
        /// </summary>
        public string Manager { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected EnterpriseWorkCenter()
        {
        }

        public EnterpriseWorkCenter(Guid id, Guid enterpriseProductionLineId, string name, string manager, string remark) : base(id)
        {
            EnterpriseProductionLineId = enterpriseProductionLineId;
            Name = name;
            Manager = manager;
            Remark = remark;
        }
    }
}
