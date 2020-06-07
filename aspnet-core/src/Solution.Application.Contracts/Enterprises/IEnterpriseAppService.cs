using System;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Enterprises
{
    public interface IEnterpriseAppService :
        ICrudAppService< 
            EnterpriseDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateEnterpriseDto,
            CreateUpdateEnterpriseDto>
    {

    }
}