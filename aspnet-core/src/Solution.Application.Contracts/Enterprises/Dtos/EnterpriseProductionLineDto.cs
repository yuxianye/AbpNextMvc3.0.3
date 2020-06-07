using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Enterprises.Dtos
{
    public class EnterpriseProductionLineDto : AuditedEntityDto<Guid>
    {
        public Guid EnterpriseAreaId { get; set; }

        public string Name { get; set; }

        public string Manager { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }
    }
}