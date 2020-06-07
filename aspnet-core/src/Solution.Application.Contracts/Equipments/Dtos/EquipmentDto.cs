using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Equipments.Dtos
{
    public class EquipmentDto : AuditedEntityDto<Guid>
    {
        public Guid EquipmentTypeId { get; set; }

        public Guid EquipmentBrandId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Specification { get; set; }

        public DateTime ManufactureDate { get; set; }

        public Guid? EquipmentStatusId { get; set; }

        public string Remark { get; set; }
    }
}