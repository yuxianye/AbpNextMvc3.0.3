using System;
using Solution.Warehouses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Warehouses
{
    public interface IWarehouseLocationAppService :
        ICrudAppService< 
            WarehouseLocationDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateWarehouseLocationDto,
            CreateUpdateWarehouseLocationDto>
    {

    }
}