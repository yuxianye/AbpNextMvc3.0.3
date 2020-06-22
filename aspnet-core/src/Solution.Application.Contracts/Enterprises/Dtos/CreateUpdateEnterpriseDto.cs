using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Enterprises.Dtos
{
    public class CreateUpdateEnterpriseDto
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.AddressLength)]
        public string Address { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        public string Phone { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}