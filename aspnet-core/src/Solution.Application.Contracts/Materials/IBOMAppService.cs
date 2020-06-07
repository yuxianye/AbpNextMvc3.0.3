using System;
using Solution.Materials.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Materials
{
    public interface IBOMAppService :
        ICrudAppService< 
            BOMDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateBOMDto,
            CreateUpdateBOMDto>
    {

    }
}