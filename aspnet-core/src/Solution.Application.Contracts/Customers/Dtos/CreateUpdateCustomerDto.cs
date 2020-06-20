using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Customers.Dtos
{
    public class CreateUpdateCustomerDto
    {
        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }
    }
}