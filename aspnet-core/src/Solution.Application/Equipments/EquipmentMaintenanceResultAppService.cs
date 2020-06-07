using System;
using Solution.Permissions;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    public class EquipmentMaintenanceResultAppService : CrudAppService<EquipmentMaintenanceResult, EquipmentMaintenanceResultDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentMaintenanceResultDto, CreateUpdateEquipmentMaintenanceResultDto>,
        IEquipmentMaintenanceResultAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EquipmentMaintenanceResults.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EquipmentMaintenanceResults.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EquipmentMaintenanceResults.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EquipmentMaintenanceResults.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EquipmentMaintenanceResults.Delete;

        public EquipmentMaintenanceResultAppService(IRepository<EquipmentMaintenanceResult, Guid> repository) : base(repository)
        {
        }
    }
}