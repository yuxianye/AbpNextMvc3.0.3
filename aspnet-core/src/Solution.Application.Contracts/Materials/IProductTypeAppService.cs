using System;
using Solution.Materials.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Materials
{
    public interface IProductTypeAppService :
        ICrudAppService< 
            ProductTypeDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateProductTypeDto,
            CreateUpdateProductTypeDto>
    {

    }
}