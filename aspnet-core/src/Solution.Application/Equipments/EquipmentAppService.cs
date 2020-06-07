using System;
using Solution.Permissions;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    public class EquipmentAppService : CrudAppService<Equipment, EquipmentDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentDto, CreateUpdateEquipmentDto>,
        IEquipmentAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Equipments.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Equipments.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Equipments.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Equipments.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Equipments.Delete;

        public EquipmentAppService(IRepository<Equipment, Guid> repository) : base(repository)
        {
        }
    }
}