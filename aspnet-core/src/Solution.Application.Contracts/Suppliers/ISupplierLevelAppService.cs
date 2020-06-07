using System;
using Solution.Suppliers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Suppliers
{
    public interface ISupplierLevelAppService :
        ICrudAppService< 
            SupplierLevelDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateSupplierLevelDto,
            CreateUpdateSupplierLevelDto>
    {

    }
}