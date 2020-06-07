using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Qualities.Dtos
{
    public class QualityInspectTypeDto : AuditedEntityDto<Guid>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Remark { get; set; }
    }
}