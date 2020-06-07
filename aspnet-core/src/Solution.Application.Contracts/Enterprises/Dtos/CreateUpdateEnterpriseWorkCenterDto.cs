using System;
using System.ComponentModel;
namespace Solution.Enterprises.Dtos
{
    public class CreateUpdateEnterpriseWorkCenterDto
    {
        public Guid EnterpriseProductionLineId { get; set; }

        public string Name { get; set; }

        public string Manager { get; set; }

        public string Remark { get; set; }
    }
}