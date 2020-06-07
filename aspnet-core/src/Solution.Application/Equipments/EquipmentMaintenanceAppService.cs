using System;
using Solution.Permissions;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    public class EquipmentMaintenanceAppService : CrudAppService<EquipmentMaintenance, EquipmentMaintenanceDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentMaintenanceDto, CreateUpdateEquipmentMaintenanceDto>,
        IEquipmentMaintenanceAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EquipmentMaintenances.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EquipmentMaintenances.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EquipmentMaintenances.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EquipmentMaintenances.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EquipmentMaintenances.Delete;

        public EquipmentMaintenanceAppService(IRepository<EquipmentMaintenance, Guid> repository) : base(repository)
        {
        }
    }
}