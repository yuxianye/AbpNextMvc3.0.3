using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Qualities.Dtos
{
    public class QualityInspectDto : AuditedEntityDto<Guid>
    {
        public string Code { get; set; }

        public string InspectPerson { get; set; }

        public Guid QualityInspectTypeId { get; set; }

        public DateTime InspectTime { get; set; }

        public Guid QualityProblemLibId { get; set; }

        public Guid QualityInspectResultId { get; set; }

        public string Remark { get; set; }
    }
}