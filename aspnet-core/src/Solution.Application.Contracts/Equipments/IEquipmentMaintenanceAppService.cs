using System;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Solution.Equipments
{
    public interface IEquipmentMaintenanceAppService :
        ICrudAppService< 
            EquipmentMaintenanceDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateEquipmentMaintenanceDto,
            CreateUpdateEquipmentMaintenanceDto>
    {

    }
}