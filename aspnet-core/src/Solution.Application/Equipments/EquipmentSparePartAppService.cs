using System;
using Solution.Permissions;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    public class EquipmentSparePartAppService : CrudAppService<EquipmentSparePart, EquipmentSparePartDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentSparePartDto, CreateUpdateEquipmentSparePartDto>,
        IEquipmentSparePartAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EquipmentSpareParts.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EquipmentSpareParts.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EquipmentSpareParts.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EquipmentSpareParts.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EquipmentSpareParts.Delete;

        public EquipmentSparePartAppService(IRepository<EquipmentSparePart, Guid> repository) : base(repository)
        {
        }
    }
}