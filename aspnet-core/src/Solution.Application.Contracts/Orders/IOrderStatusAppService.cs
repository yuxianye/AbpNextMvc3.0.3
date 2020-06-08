using System;
using Solution.Orders.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Orders
{
    public interface IOrderStatusAppService :
        ICrudAppService< 
            OrderStatusDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateOrderStatusDto,
            CreateUpdateOrderStatusDto>
    {

    }
}