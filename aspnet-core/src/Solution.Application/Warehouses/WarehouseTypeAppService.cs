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
    public class WarehouseTypeAppService : CrudAppService<WarehouseType, WarehouseTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateWarehouseTypeDto, CreateUpdateWarehouseTypeDto>,
        IWarehouseTypeAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.WarehouseTypes.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.WarehouseTypes.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.WarehouseTypes.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.WarehouseTypes.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.WarehouseTypes.Delete;

        public WarehouseTypeAppService(IRepository<WarehouseType, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<WarehouseTypeDto> CreateAsync(CreateUpdateWarehouseTypeDto input)
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