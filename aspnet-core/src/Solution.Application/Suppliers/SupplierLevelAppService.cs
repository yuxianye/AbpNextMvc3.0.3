using System;
using Solution.Permissions;
using Solution.Suppliers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Suppliers
{
    public class SupplierLevelAppService : CrudAppService<SupplierLevel, SupplierLevelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSupplierLevelDto, CreateUpdateSupplierLevelDto>,
        ISupplierLevelAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.SupplierLevels.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.SupplierLevels.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.SupplierLevels.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.SupplierLevels.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.SupplierLevels.Delete;

        public SupplierLevelAppService(IRepository<SupplierLevel, Guid> repository) : base(repository)
        {
        }
    }
}