using System;
using System.Linq;
using System.Threading.Tasks;
using Solution.Localization;
using Solution.Permissions;
using Solution.Suppliers.Dtos;
using Volo.Abp;
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
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<SupplierLevelDto> CreateAsync(CreateUpdateSupplierLevelDto input)
        {
            await CheckCreatePolicyAsync();

            if (Repository.Any(a => a.Name == input.Name))
            {
                throw new UserFriendlyException(message: L["Error"], details: L["NameAlreadyExists", input.Name]);
            }

            var entity = MapToEntity(input);

            TryToSetTenantId(entity);

            await Repository.InsertAsync(entity, autoSave: true);

            return MapToGetOutputDto(entity);
        }
    }
}