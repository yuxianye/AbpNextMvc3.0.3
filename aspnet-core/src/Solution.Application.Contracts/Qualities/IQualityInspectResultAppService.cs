using System;
using Solution.Qualities.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Qualities
{
    public interface IQualityInspectResultAppService :
        ICrudAppService< 
            QualityInspectResultDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateQualityInspectResultDto,
            CreateUpdateQualityInspectResultDto>
    {

    }
}