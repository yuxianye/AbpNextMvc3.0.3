using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Materials.Dtos
{
    public class CreateUpdateProductTypeDto
    {
        [Required]
        [StringLength(MySolutionConsts.RemarkLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}