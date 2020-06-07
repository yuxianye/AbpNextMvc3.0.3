using System;
using Solution.Suppliers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Suppliers
{
    public interface ISuppliersAppService :
        ICrudAppService< 
            SuppliersDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateSuppliersDto,
            CreateUpdateSuppliersDto>
    {

    }
}