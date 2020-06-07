using System;
using System.ComponentModel;
namespace Solution.Enterprises.Dtos
{
    public class CreateUpdateEnterpriseWorkLocationDto
    {
        public Guid EnterpriseWorkCenterId { get; set; }

        public string Name { get; set; }

        public Guid EquipmentId { get; set; }

        public Guid ProcessId { get; set; }

        public string Remark { get; set; }
    }
}