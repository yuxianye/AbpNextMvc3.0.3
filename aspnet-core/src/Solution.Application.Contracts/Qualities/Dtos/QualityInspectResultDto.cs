using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Qualities.Dtos
{
    public class QualityInspectResultDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Remark { get; set; }
    }
}