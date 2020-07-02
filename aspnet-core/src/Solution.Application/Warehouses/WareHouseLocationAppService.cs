using System;
using Solution.Localization;
using Solution.Permissions;
using Solution.Warehouses.Dtos;
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
    }
}