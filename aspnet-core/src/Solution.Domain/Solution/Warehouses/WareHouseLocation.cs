using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.Warehouses
{
    /// <summary>
    /// 库位
    /// </summary>
    public class WareHouseLocation : AuditedEntity<Guid>
    {

        /// <summary>
        /// 库区编号
        /// </summary>
        public Guid WareHouseAreaId { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        protected WareHouseLocation()
        {
        }

        public WareHouseLocation(Guid id, Guid wareHouseAreaId, string code, string name, string remark) : base(id)
        {
            WareHouseAreaId = wareHouseAreaId;
            Code = code;
            Name = name;
            Remark = remark;
        }
    }
}
