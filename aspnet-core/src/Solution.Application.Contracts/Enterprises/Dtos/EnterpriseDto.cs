using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Enterprises.Dtos
{
    public class EnterpriseDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }
    }
}