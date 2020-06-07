using System;
using System.ComponentModel;
namespace Solution.Warehouses.Dtos
{
    public class CreateUpdateWareHouseLocationDto
    {
        public Guid WareHouseAreaId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Remark { get; set; }
    }
}