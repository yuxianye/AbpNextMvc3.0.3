using System;
using Solution.Warehouses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Warehouses
{
    public interface IWareHouseLocationAppService :
        ICrudAppService< 
            WareHouseLocationDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateWareHouseLocationDto,
            CreateUpdateWareHouseLocationDto>
    {

    }
}