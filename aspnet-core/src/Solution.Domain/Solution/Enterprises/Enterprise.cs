using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Enterprises
{
    /// <summary>
    /// 企业
    /// </summary>
    public class Enterprise : AuditedEntity<Guid>
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 企业电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected Enterprise()
        {
        }

        public Enterprise(Guid id, string name, string address, string phone, string remark) : base(id)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Remark = remark;
        }
    }
}
