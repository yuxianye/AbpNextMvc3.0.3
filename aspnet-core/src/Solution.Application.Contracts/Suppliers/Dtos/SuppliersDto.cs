using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Suppliers.Dtos
{
    public class SuppliersDto : AuditedEntityDto<Guid>
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