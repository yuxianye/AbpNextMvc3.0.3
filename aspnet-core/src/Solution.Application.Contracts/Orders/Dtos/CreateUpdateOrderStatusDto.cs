using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Orders.Dtos
{
    public class CreateUpdateOrderStatusDto
    {
        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}