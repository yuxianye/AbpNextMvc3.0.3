using System;
using Solution.Permissions;
using Solution.Materials.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Materials
{
    public class BOMAppService : CrudAppService<BOM, BOMDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBOMDto, CreateUpdateBOMDto>,
        IBOMAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.BOMs.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.BOMs.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.BOMs.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.BOMs.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.BOMs.Delete;

        public BOMAppService(IRepository<BOM, Guid> repository) : base(repository)
        {
        }
    }
}