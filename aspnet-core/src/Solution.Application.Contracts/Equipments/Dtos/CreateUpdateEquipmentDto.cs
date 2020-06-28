using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentDto
    {
        public Guid EquipmentTypeId { get; set; }

        public Guid EquipmentBrandId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.StringLength64)]
        public string Specification { get; set; }

        public DateTime ManufactureDate { get; set; }

        public Guid EquipmentStatusId { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}