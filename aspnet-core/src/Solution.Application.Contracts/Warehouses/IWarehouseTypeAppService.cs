using System;
using Solution.Warehouses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Warehouses
{
    public interface IWarehouseTypeAppService :
        ICrudAppService< 
            WarehouseTypeDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateWarehouseTypeDto,
            CreateUpdateWarehouseTypeDto>
    {

    }
}