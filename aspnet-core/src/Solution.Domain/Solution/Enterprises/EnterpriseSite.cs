using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Enterprises
{
    /// <summary>
    /// 企业厂区
    /// </summary>
    public class EnterpriseSite : AuditedEntity<Guid>
    {

        /// <summary>
        /// 所属企业
        /// </summary>
        public Guid EnterpriseId { get; set; }

        /// <summary>
        /// 厂区名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 厂区负责人、管理人
        /// </summary>
        [StringLength(50)]
        public string Manager { get; set; }

        /// <summary>
        /// 厂区电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected EnterpriseSite()
        {
        }

        public EnterpriseSite(Guid id, Guid enterpriseId, string name, string address, string manager, string phone, string remark) : base(id)
        {
            EnterpriseId = enterpriseId;
            Name = name;
            Address = address;
            Manager = manager;
            Phone = phone;
            Remark = remark;
        }
    }
}
