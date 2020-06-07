using System;
using Solution.Permissions;
using Solution.Enterprises.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Solution.Enterprises
{
    public class EnterpriseWorkLocationAppService : CrudAppService<EnterpriseWorkLocation, EnterpriseWorkLocationDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEnterpriseWorkLocationDto, CreateUpdateEnterpriseWorkLocationDto>,
        IEnterpriseWorkLocationAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EnterpriseWorkLocations.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EnterpriseWorkLocations.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EnterpriseWorkLocations.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EnterpriseWorkLocations.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EnterpriseWorkLocations.Delete;

        public EnterpriseWorkLocationAppService(IRepository<EnterpriseWorkLocation, Guid> repository) : base(repository)
        {
        }
    }
}