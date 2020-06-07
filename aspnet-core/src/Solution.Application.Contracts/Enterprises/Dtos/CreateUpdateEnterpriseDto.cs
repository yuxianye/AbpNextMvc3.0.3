using System;
using System.ComponentModel;
namespace Solution.Enterprises.Dtos
{
    public class CreateUpdateEnterpriseDto
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }
    }
}