using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Warehouses.Dtos
{
    public class CreateUpdateWarehouseTypeDto
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}