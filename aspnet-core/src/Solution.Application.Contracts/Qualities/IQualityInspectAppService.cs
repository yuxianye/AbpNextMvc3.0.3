using System;
using Solution.Qualities.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Qualities
{
    public interface IQualityInspectAppService :
        ICrudAppService< 
            QualityInspectDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateQualityInspectDto,
            CreateUpdateQualityInspectDto>
    {

    }
}