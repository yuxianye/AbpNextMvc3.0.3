using System;
using System.Linq;
using System.Threading.Tasks;
using Solution.Localization;
using Solution.Permissions;
using Solution.Warehouses.Dtos;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Warehouses
{
    public class WarehouseLocationAppService : CrudAppService<WarehouseLocation, WarehouseLocationDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateWarehouseLocationDto, CreateUpdateWarehouseLocationDto>,
        IWarehouseLocationAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.WarehouseLocations.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.WarehouseLocations.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.WarehouseLocations.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.WarehouseLocations.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.WarehouseLocations.Delete;

        public WarehouseLocationAppService(IRepository<WarehouseLocation, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<WarehouseLocationDto> CreateAsync(CreateUpdateWarehouseLocationDto input)
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