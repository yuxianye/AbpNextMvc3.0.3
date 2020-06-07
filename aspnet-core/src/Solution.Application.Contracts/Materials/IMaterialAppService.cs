using System;
using Solution.Materials.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Materials
{
    public interface IMaterialAppService :
        ICrudAppService< 
            MaterialDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateMaterialDto,
            CreateUpdateMaterialDto>
    {

    }
}