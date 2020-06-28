using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Suppliers.Dtos
{
    public class CreateUpdateSuppliersDto
    {
        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string Name { get; set; }

        public Guid SupplierLevelId { get; set; }

        [StringLength(MySolutionConsts.NameLength)]
        public string Contact { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        public string Phone { get; set; }

        [Phone]
        [StringLength(MySolutionConsts.PhoneLength)]
        public string Fax { get; set; }

        [StringLength(MySolutionConsts.AddressLength)]
        public string Address { get; set; }

        [EmailAddress]
        [StringLength(MySolutionConsts.EmailLength)]
        public string Email { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}