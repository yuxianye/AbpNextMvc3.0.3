using System;
using Solution.Warehouses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Warehouses
{
    public interface IWarehouseAreaAppService :
        ICrudAppService< 
            WarehouseAreaDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateWarehouseAreaDto,
            CreateUpdateWarehouseAreaDto>
    {

    }
}