using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Customers
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Customer : AuditedEntity<Guid>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

       

        protected Customer()
        {
        }

        public Customer(Guid id, string name, string address, string contact, string phone, string remark) : base(id)
        {
            Name = name;
            Address = address;
            Contact = contact;
            Phone = phone;
            Remark = remark;
        }
    }
}
