using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Public.Dtos
{
    public class CreateUpdateUnitDto
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}