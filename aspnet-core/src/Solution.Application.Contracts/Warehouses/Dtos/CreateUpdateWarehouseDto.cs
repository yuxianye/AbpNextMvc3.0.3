using System;
using System.ComponentModel;
namespace Solution.Warehouses.Dtos
{
    public class CreateUpdateWarehouseDto
    {
        public Guid EnterpriseAreaId { get; set; }

        public string Name { get; set; }

        public string Manager { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }
    }
}