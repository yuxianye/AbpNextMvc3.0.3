using System;
using System.ComponentModel;
namespace Solution.Suppliers.Dtos
{
    public class CreateUpdateSuppliersDto
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public Guid SupplierLevelId { get; set; }

        public string Contact { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Remark { get; set; }
    }
}