using System;
using Solution.Permissions;
using Solution.Suppliers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Suppliers
{
    public class SuppliersAppService : CrudAppService<Suppliers, SuppliersDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSuppliersDto, CreateUpdateSuppliersDto>,
        ISuppliersAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Suppliers.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Suppliers.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Suppliers.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Suppliers.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Suppliers.Delete;

        public SuppliersAppService(IRepository<Suppliers, Guid> repository) : base(repository)
        {
        }
    }
}