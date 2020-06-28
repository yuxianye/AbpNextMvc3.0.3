using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Customers.Dtos
{
    public class CreateUpdateCustomerDto
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.AddressLength)]
        public string Address { get; set; }

        [StringLength(MySolutionConsts.NameLength)]
        public string Contact { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        public string Phone { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }






    }
}