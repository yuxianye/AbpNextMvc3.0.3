using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Enterprises.Dtos
{
    public class EnterpriseSiteDto : AuditedEntityDto<Guid>
    {
        public Guid EnterpriseId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Manager { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }
    }
}