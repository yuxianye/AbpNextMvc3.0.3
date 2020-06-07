using System;
using Solution.Permissions;
using Solution.Warehouses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Warehouses
{
    public class WarehouseAppService : CrudAppService<Warehouse, WarehouseDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateWarehouseDto, CreateUpdateWarehouseDto>,
        IWarehouseAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Warehouses.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Warehouses.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Warehouses.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Warehouses.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Warehouses.Delete;

        public WarehouseAppService(IRepository<Warehouse, Guid> repository) : base(repository)
        {
        }
    }
}