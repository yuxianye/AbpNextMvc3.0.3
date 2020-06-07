using System;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Enterprises
{
    public interface IEnterpriseProductionLineAppService :
        ICrudAppService< 
            EnterpriseProductionLineDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateEnterpriseProductionLineDto,
            CreateUpdateEnterpriseProductionLineDto>
    {

    }
}