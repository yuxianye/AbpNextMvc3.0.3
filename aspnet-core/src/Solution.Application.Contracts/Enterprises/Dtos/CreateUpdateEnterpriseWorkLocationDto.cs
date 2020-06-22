using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Enterprises.Dtos
{
    public class CreateUpdateEnterpriseWorkLocationDto
    {
        public Guid EnterpriseWorkCenterId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        public Guid EquipmentId { get; set; }

        public Guid ProcessId { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}