using System;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Equipments
{
    public interface IEquipmentInspectionAppService :
        ICrudAppService< 
            EquipmentInspectionDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateEquipmentInspectionDto,
            CreateUpdateEquipmentInspectionDto>
    {

    }
}