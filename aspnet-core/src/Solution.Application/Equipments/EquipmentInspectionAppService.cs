using System;
using Solution.Permissions;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Equipments
{
    public class EquipmentInspectionAppService : CrudAppService<EquipmentInspection, EquipmentInspectionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentInspectionDto, CreateUpdateEquipmentInspectionDto>,
        IEquipmentInspectionAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EquipmentInspections.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EquipmentInspections.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EquipmentInspections.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EquipmentInspections.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EquipmentInspections.Delete;

        public EquipmentInspectionAppService(IRepository<EquipmentInspection, Guid> repository) : base(repository)
        {
        }
    }
}