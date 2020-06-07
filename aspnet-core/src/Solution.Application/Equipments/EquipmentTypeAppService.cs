using System;
using Solution.Permissions;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    public class EquipmentTypeAppService : CrudAppService<EquipmentType, EquipmentTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentTypeDto, CreateUpdateEquipmentTypeDto>,
        IEquipmentTypeAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EquipmentTypes.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EquipmentTypes.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EquipmentTypes.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EquipmentTypes.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EquipmentTypes.Delete;

        public EquipmentTypeAppService(IRepository<EquipmentType, Guid> repository) : base(repository)
        {
        }
    }
}