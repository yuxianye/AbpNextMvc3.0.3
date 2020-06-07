using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Enterprises.Dtos
{
    public class EnterpriseWorkLocationDto : AuditedEntityDto<Guid>
    {
        public Guid EnterpriseWorkCenterId { get; set; }

        public string Name { get; set; }

        public Guid EquipmentId { get; set; }

        public Guid ProcessId { get; set; }

        public string Remark { get; set; }
    }
}