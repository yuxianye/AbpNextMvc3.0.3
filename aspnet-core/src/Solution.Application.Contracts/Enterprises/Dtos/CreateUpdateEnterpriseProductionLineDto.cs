using System;
using System.ComponentModel;
namespace Solution.Enterprises.Dtos
{
    public class CreateUpdateEnterpriseProductionLineDto
    {
        public Guid EnterpriseAreaId { get; set; }

        public string Name { get; set; }

        public string Manager { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }
    }
}