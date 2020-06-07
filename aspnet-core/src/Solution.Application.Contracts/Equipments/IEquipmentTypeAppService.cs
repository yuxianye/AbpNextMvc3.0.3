using System;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Equipments
{
    public interface IEquipmentTypeAppService :
        ICrudAppService< 
            EquipmentTypeDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateEquipmentTypeDto,
            CreateUpdateEquipmentTypeDto>
    {

    }
}