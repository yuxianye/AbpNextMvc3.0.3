using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Materials.Dtos
{
    public class CreateUpdateMaterialDto
    {
        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.StringLength64)]
        public string Specification { get; set; }

        public Guid UnitId { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }




    }
}