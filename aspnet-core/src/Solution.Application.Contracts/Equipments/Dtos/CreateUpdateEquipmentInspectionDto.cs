using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Equipments.Dtos
{
    public class CreateUpdateEquipmentInspectionDto
    {
        public Guid EquipmentId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string InspectPerson { get; set; }

        public DateTime InspectionTime { get; set; }

        public Guid EquipmentInspectionResultId { get; set; }

        [StringLength(MySolutionConsts.StringLength256)]
        public string Problem { get; set; }

        [StringLength(MySolutionConsts.StringLength256)]
        public string Cause { get; set; }

        [StringLength(MySolutionConsts.StringLength256)]
        public string Solution { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}