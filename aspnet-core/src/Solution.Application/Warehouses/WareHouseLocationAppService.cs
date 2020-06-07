using System;
using Solution.Permissions;
using Solution.Warehouses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Warehouses
{
    public class WareHouseLocationAppService : CrudAppService<WareHouseLocation, WareHouseLocationDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateWareHouseLocationDto, CreateUpdateWareHouseLocationDto>,
        IWareHouseLocationAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.WareHouseLocations.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.WareHouseLocations.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.WareHouseLocations.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.WareHouseLocations.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.WareHouseLocations.Delete;

        public WareHouseLocationAppService(IRepository<WareHouseLocation, Guid> repository) : base(repository)
        {
        }
    }
}