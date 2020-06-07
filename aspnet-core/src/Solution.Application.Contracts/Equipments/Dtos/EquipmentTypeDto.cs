using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Equipments.Dtos
{
    public class EquipmentTypeDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Remark { get; set; }
    }
}