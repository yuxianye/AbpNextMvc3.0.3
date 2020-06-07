using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Equipments.Dtos
{
    public class EquipmentInspectionDto : AuditedEntityDto<Guid>
    {
        public Guid EquipmentId { get; set; }

        public string InspectPerson { get; set; }

        public DateTime InspectionTime { get; set; }

        public Guid EquipmentInspectionResultId { get; set; }

        public string Problem { get; set; }

        public string Cause { get; set; }

        public string Solution { get; set; }

        public string Remark { get; set; }
    }
}