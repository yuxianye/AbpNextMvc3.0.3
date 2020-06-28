using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentSparePartDto
    {
        public Guid EquipmentSparePartTypeId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}