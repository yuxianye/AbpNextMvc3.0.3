using System;
using Solution.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Customers
{
    public interface ICustomerAppService :
        ICrudAppService< 
            CustomerDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateCustomerDto,
            CreateUpdateCustomerDto>
    {

    }
}