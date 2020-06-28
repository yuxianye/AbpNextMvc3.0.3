using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Qualities.Dtos
{
    public class CreateUpdateQualityInspectTypeDto
    {
        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}