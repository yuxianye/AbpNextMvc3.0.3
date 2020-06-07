using System;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Enterprises
{
    public interface IEnterpriseWorkLocationAppService :
        ICrudAppService< 
            EnterpriseWorkLocationDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateEnterpriseWorkLocationDto,
            CreateUpdateEnterpriseWorkLocationDto>
    {

    }
}