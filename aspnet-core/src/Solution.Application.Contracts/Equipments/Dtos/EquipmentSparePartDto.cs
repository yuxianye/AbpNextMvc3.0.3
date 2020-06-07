using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Equipments.Dtos
{
    public class EquipmentSparePartDto : AuditedEntityDto<Guid>
    {
        public Guid? EquipmentSparePartTypeId { get; set; }

        public string Name { get; set; }

        public string Remark { get; set; }
    }
}