using System;
using Solution.Warehouses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Warehouses
{
    public interface IWarehouseAppService :
        ICrudAppService< 
            WarehouseDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateWarehouseDto,
            CreateUpdateWarehouseDto>
    {

    }
}