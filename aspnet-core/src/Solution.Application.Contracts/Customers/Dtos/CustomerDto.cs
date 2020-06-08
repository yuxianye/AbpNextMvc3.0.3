using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Customers.Dtos
{
    public class CustomerDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }
    }
}