using System;
using Solution.Permissions;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    public class EquipmentStatusAppService : CrudAppService<EquipmentStatus, EquipmentStatusDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentStatusDto, CreateUpdateEquipmentStatusDto>,
        IEquipmentStatusAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EquipmentStatus.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EquipmentStatus.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EquipmentStatus.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EquipmentStatus.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EquipmentStatus.Delete;

        public EquipmentStatusAppService(IRepository<EquipmentStatus, Guid> repository) : base(repository)
        {
        }
    }
}