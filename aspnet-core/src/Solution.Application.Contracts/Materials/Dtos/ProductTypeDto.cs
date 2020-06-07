using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Materials.Dtos
{
    public class ProductTypeDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Remark { get; set; }
    }
}