using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Warehouses.Dtos
{
    public class WareHouseLocationDto : AuditedEntityDto<Guid>
    {
        public Guid WareHouseAreaId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Remark { get; set; }
    }
}