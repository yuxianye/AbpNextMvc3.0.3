using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Enterprises.Dtos
{
    public class CreateUpdateEnterpriseWorkCenterDto
    {
        public Guid EnterpriseProductionLineId { get; set; }
     
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.NameLength)]
        public string Manager { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}