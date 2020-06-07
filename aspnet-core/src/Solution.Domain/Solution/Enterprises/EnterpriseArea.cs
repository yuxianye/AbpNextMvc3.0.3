using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Enterprises
{
    /// <summary>
    /// 企业车间
    /// </summary>
    public class EnterpriseArea : AuditedEntity<Guid>
    {

        /// <summary>
        /// 所属厂区
        /// </summary>
        public Guid EnterpriseSiteId { get; set; }

        /// <summary>
        /// 车间名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 车间负责人、管理人
        /// </summary>
        public string Manager { get; set; }

        /// <summary>
        /// 车间电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected EnterpriseArea()
        {
        }

        public EnterpriseArea(Guid id, Guid enterpriseSiteId, string name, string manager, string phone, string remark) : base(id)
        {
            EnterpriseSiteId = enterpriseSiteId;
            Name = name;
            Manager = manager;
            Phone = phone;
            Remark = remark;
        }
    }
}
