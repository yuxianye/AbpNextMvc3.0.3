using System;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Equipments
{
    public interface IEquipmentBrandAppService :
        ICrudAppService< 
            EquipmentBrandDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateEquipmentBrandDto,
            CreateUpdateEquipmentBrandDto>
    {

    }
}