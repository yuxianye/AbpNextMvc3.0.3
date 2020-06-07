using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Equipments.Dtos
{
    public class EquipmentInspectionResultDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Remark { get; set; }
    }
}