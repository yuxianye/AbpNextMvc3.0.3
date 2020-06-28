using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Suppliers.Dtos
{
    public class CreateUpdateSupplierLevelDto
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}