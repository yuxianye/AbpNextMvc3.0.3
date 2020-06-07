using System;
using System.ComponentModel;
namespace Solution.Qualities.Dtos
{
    public class CreateUpdateQualityInspectDto
    {
        public string InspectPerson { get; set; }

        public Guid QualityInspectTypeId { get; set; }

        public DateTime InspectTime { get; set; }

        public string Name { get; set; }

        public Guid QualityProblemLibId { get; set; }

        public Guid QualityInspectResultId { get; set; }

        public string Remark { get; set; }
    }
}