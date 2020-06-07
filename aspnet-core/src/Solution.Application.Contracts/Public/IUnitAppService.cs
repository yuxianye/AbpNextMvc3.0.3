using System;
using Solution.Public.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Public
{
    public interface IUnitAppService :
        ICrudAppService< 
            UnitDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateUnitDto,
            CreateUpdateUnitDto>
    {

    }
}