using System;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Enterprises
{
    public interface IEnterpriseSiteAppService :
        ICrudAppService< 
            EnterpriseSiteDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateEnterpriseSiteDto,
            CreateUpdateEnterpriseSiteDto>
    {

    }
}