using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Orders.Dtos
{
    public class OrderStatusDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Remark { get; set; }
    }
}