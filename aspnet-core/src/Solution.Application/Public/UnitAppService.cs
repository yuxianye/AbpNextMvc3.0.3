using System;
using Solution.Permissions;
using Solution.Public.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Public
{
    public class UnitAppService : CrudAppService<Unit, UnitDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUnitDto, CreateUpdateUnitDto>,
        IUnitAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.Units.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.Units.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.Units.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.Units.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.Units.Delete;

        public UnitAppService(IRepository<Unit, Guid> repository) : base(repository)
        {
        }
    }
}