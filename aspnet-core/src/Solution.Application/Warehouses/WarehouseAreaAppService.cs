using System;
using Solution.Permissions;
using Solution.Warehouses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Warehouses
{
    public class WarehouseAreaAppService : CrudAppService<WarehouseArea, WarehouseAreaDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateWarehouseAreaDto, CreateUpdateWarehouseAreaDto>,
        IWarehouseAreaAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.WarehouseAreas.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.WarehouseAreas.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.WarehouseAreas.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.WarehouseAreas.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.WarehouseAreas.Delete;

        public WarehouseAreaAppService(IRepository<WarehouseArea, Guid> repository) : base(repository)
        {
        }
    }
}