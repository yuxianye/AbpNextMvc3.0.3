using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Suppliers
{
    /// <summary>
    /// 供应商
    /// </summary>
    public class Suppliers : AuditedEntity<Guid>
    {
        /// <summary>
        /// 供应商编号，不能重复
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 供应商等级编号
        /// </summary>
        public Guid SupplierLevelId { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 供应商电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 供应商传真
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// 供应商地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 供应商邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected Suppliers()
        {
        }

        public Suppliers(Guid id, string code, string name, Guid supplierLevelId, string contact, string phone, string fax, string address, string email, string remark) : base(id)
        {
            Code = code;
            Name = name;
            SupplierLevelId = supplierLevelId;
            Contact = contact;
            Phone = phone;
            Fax = fax;
            Address = address;
            Email = email;
            Remark = remark;
        }
    }
}
