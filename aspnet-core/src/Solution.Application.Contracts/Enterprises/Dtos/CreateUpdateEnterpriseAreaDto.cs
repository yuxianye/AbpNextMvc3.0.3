using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Enterprises.Dtos
{
    public class CreateUpdateEnterpriseAreaDto
    {
        public Guid EnterpriseSiteId { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.NameLength)]
        public string Manager { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        public string Phone { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}