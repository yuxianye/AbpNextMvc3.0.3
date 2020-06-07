using System;
using Volo.Abp.Application.Dtos;

namespace Solution.Suppliers.Dtos
{
    public class SupplierLevelDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Remark { get; set; }
    }
}