using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentSparePartDto
    {
        public Guid? EquipmentSparePartTypeId { get; set; }

        public string Name { get; set; }

        public string Remark { get; set; }
    }
}