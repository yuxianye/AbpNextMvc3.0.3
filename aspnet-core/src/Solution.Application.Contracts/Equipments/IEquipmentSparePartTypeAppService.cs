using System;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Equipments
{
    public interface IEquipmentSparePartTypeAppService :
        ICrudAppService< 
            EquipmentSparePartTypeDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateEquipmentSparePartTypeDto,
            CreateUpdateEquipmentSparePartTypeDto>
    {

    }
}