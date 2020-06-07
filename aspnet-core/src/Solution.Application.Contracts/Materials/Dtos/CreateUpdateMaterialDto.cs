using System;
using System.ComponentModel;
namespace Solution.Materials.Dtos
{
    public class CreateUpdateMaterialDto
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Specification { get; set; }

        public Guid UnitId { get; set; }

        public string Remark { get; set; }
    }
}