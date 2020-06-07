using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Materials.Dtos
{
    public class ProductDto : AuditedEntityDto<Guid>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public Guid ProductTypeId { get; set; }

        public string Specification { get; set; }

        public Guid UnitId { get; set; }

        public string Remark { get; set; }
    }
}