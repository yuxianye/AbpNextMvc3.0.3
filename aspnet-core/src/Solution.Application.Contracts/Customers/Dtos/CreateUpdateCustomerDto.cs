using System;
using System.ComponentModel;
namespace Solution.Customers.Dtos
{
    public class CreateUpdateCustomerDto
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }
    }
}