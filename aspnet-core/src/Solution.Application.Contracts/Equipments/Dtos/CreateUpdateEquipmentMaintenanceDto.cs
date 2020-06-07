using System;
using System.ComponentModel;
namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentMaintenanceDto
    {
        public Guid EquipmentId { get; set; }

        public string Problem { get; set; }

        public string Cause { get; set; }

        public string Solution { get; set; }

        public DateTime ActualStartTime { get; set; }

        public DateTime ActualFinishTime { get; set; }

        public string Consumable { get; set; }

        public string ResponsiblePerson { get; set; }

        public DateTime MaintenanceTime { get; set; }

        public Guid EquipmentMaintenanceResultId { get; set; }

        public string Remark { get; set; }
    }
}