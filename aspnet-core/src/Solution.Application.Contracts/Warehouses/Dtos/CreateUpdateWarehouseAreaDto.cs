using System;
using System.ComponentModel;
namespace Solution.Warehouses.Dtos
{
    public class CreateUpdateWarehouseAreaDto
    {
        public Guid WarehouseId { get; set; }

        public string Name { get; set; }

        public string Remark { get; set; }
    }
}