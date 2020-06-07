using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Enterprises
{
    public class EnterpriseAreaAppService : CrudAppService<EnterpriseArea, EnterpriseAreaDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEnterpriseAreaDto, CreateUpdateEnterpriseAreaDto>,
        IEnterpriseAreaAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EnterpriseAreas.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EnterpriseAreas.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EnterpriseAreas.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EnterpriseAreas.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EnterpriseAreas.Delete;

        public EnterpriseAreaAppService(IRepository<EnterpriseArea, Guid> repository) : base(repository)
        {
        }
    }
}